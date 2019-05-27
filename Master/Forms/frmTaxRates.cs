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
    public partial class frmTaxRates : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Tax Rates";
        public frmTaxRates()
        {
            InitializeComponent();
        }

        private void frmTaxRates_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("View", AppConstant.UserID))
                {
                    this.taxTablesTableAdapter.Fill(this.dsTaxRates.TaxTables);
                LoadGrid();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to View Tax Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

                this.spSelectAllTaxRatesTableAdapter.Fill(this.dsTaxRates.spSelectAllTaxRates, AppConstant.UserID, Environment.MachineName);
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
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    this.spSelectAllTaxRatesTableAdapter.Insert(
                   Convert.ToString(TableNameLookUpEdit.EditValue),
                   Convert.ToDecimal(FromAmountTextEdit.Text),
                   Convert.ToDecimal(ToAmountTextEdit.Text),
                   Convert.ToDouble(RateTextEdit.Text),
                   EffectiveDateDateEdit.DateTime,
                  
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Tax Rates saved successfully");
                this.spSelectAllTaxRatesTableAdapter.Fill(this.dsTaxRates.spSelectAllTaxRates, AppConstant.UserID, Environment.MachineName);
                ClearFields();
            }
                else
                {
                MessageBox.Show("Privilege Violation.You have insufficient right to add approvers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
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
                TableNameLookUpEdit.EditValue = "PAYE";
                FromAmountTextEdit.Text = "0";
                 ToAmountTextEdit.Text = "20000";
                RateTextEdit.Text = "0";
                EffectiveDateDateEdit.DateTime = DateTime.Now;

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

                TableNameLookUpEdit.Enabled = false;
                FromAmountTextEdit.Enabled = false;
                ToAmountTextEdit.Enabled = false;
                RateTextEdit.Enabled = false;

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
                TableNameLookUpEdit.Enabled = true;
                FromAmountTextEdit.Enabled = true;
                ToAmountTextEdit.Enabled = true;
                RateTextEdit.Enabled = true;
                
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

                var TableName = Convert.ToString(TableNameLookUpEdit.EditValue);
                var FromAmount = Convert.ToDecimal(FromAmountTextEdit.Text);
                var EffectiveDate = Convert.ToDateTime(EffectiveDateDateEdit.DateTime);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete Tax Rate  " + TableName, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllTaxRatesTableAdapter.Delete(TableName, FromAmount, EffectiveDate, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllTaxRatesTableAdapter.Fill(this.dsTaxRates.spSelectAllTaxRates, AppConstant.UserID, Environment.MachineName);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void SelectRecord()
        {
            try
            {

                var TableName = Convert.ToString(this.gridView1.GetFocusedRowCellValue("TableName"));
                var EffectiveDate = Convert.ToDateTime(this.gridView1.GetFocusedRowCellValue("EffectiveDate"));
                var FromAmount = Convert.ToDecimal(this.gridView1.GetFocusedRowCellValue("FromAmount"));

                this.spSelectTaxRatesTableAdapter.Fill(this.dsTaxRates.spSelectTaxRates, TableName, FromAmount, EffectiveDate, AppConstant.UserID, Environment.MachineName);

                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    SaveRecord();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Tax Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Tax Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Tax Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Tax Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                SelectRecord();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}