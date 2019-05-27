using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Master.Forms
{
    public partial class frmTaxTables : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Tax Tables";
        public frmTaxTables()
        {
            InitializeComponent();
        }

        private void frmTaxTables_Load(object sender, EventArgs e)
        {
            if (this.ValidateRight("View", AppConstant.UserID))
            {
                //AppConstant.CompCode = "001";
                //AppConstant.UserID = "steve@live.com";
                LoadGrid();
                }
                else
                {
                        MessageBox.Show("Privilege Violation.You have insufficient right to View Tax Tables", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
}
        public bool ValidateRight(string Right, string UserGroup)
        {
            try
            {
                _Security.SecurityModule = this.SecurityModule;
                _Security.Right = Right;
                _Security.Usergroup = UserGroup;
                return _Security.ValidatePrivilege();
            }
            catch (Exception)
            {


                return false;
            }
        }
        public void LoadGrid()
        {
            try
            {

                this.spSelectAllTaxTablesTableAdapter.Fill(this.dsTaxTables.spSelectAllTaxTables, AppConstant.UserID, Environment.MachineName);
                ClearFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void SaveRecord()
        {
            try
            {
                this.spSelectAllTaxTablesTableAdapter.Insert(
                   Convert.ToString(TaxCodeTextEdit.Text),
                   Convert.ToString(TaxDescriptionTextEdit.Text),
                   Convert.ToDouble(TaxRateTextEdit.Text),
                   EffectiveDateDateEdit.DateTime,
                   TaxAuthorityTextEdit.Text,
                   NarrationTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Tax table saved successfully");
                this.spSelectAllTaxTablesTableAdapter.Fill(this.dsTaxTables.spSelectAllTaxTables, AppConstant.UserID, Environment.MachineName);
                ClearFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void ClearFields()
        {
            try
            {
                TaxCodeTextEdit.Text = "0";
                TaxDescriptionTextEdit.Text = "0";
                TaxRateTextEdit.Text = "0";
                EffectiveDateDateEdit.DateTime = DateTime.Now;
                TaxAuthorityTextEdit.Text = "0";
                NarrationTextEdit.Text = "Tax table";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void disableFields()
        {
            try
            {

                TaxCodeTextEdit.Enabled = false;
                TaxDescriptionTextEdit.Enabled = false;
                TaxRateTextEdit.Enabled = false;
                EffectiveDateDateEdit.Enabled = false;
                TaxAuthorityTextEdit.Enabled = false;
                NarrationTextEdit.Enabled = false;
                EffectiveDateDateEdit.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EnableField()
        {
            try
            {
                TaxCodeTextEdit.Enabled = true;
                TaxDescriptionTextEdit.Enabled = true;
                TaxRateTextEdit.Enabled = true;
                EffectiveDateDateEdit.Enabled = true;
                TaxAuthorityTextEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
                EffectiveDateDateEdit.Enabled = true;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void DeleteRecord()
        {
            try
            {

                var TaxCode = Convert.ToString(TaxCodeTextEdit.Text);
                var TaxAuthority = Convert.ToString(TaxAuthorityTextEdit.Text);
                var EffectiveDate = Convert.ToDateTime(EffectiveDateDateEdit.DateTime);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete tax code  " + TaxCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllTaxTablesTableAdapter.Delete(TaxCode, EffectiveDate, TaxAuthority, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllTaxTablesTableAdapter.Fill(this.dsTaxTables.spSelectAllTaxTables, AppConstant.UserID, Environment.MachineName);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void SelectTaxTables()
        {
            try
            {

                var TaxCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("TaxCode"));
                var EffectiveDate = Convert.ToDateTime(this.gridView1.GetFocusedRowCellValue("EffectiveDate"));
                var TaxAuthority = Convert.ToString(this.gridView1.GetFocusedRowCellValue("TaxAuthority"));

                this.spSelectTaxTablesTableAdapter.Fill(this.dsTaxTables.spSelectTaxTables, TaxCode, EffectiveDate, TaxAuthority, AppConstant.UserID, Environment.MachineName);

                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Add", AppConstant.UserID))
            {
                SaveRecord();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to add Tax Tables", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Edit", AppConstant.UserID))
                {
                    EnableField();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Tax Tables", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Delete", AppConstant.UserID))
                {
                    DeleteRecord();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Tax Tables", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Export", AppConstant.UserID))
                {
                    this.gridView1.ShowPrintPreview();
                }


                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Tax Tables", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                SelectTaxTables();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }
    }
}