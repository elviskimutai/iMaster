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
    public partial class frmLedger1 : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Ledgers";
        Security _Security = new Security();
        public frmLedger1()
        {
            InitializeComponent();
           

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            SelectRecord();
        }

        private void frmLedger1_Load(object sender, EventArgs e)
        {
            try
            {
                spGetCompanyCostCentersTableAdapter.Fill(dsLedger.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                LoadGrid();
                glcostcenter.EditValue = dsLedger.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();

            }
            catch (Exception)
            {

               
            }
        }
        public void SelectRecord()
        {
            try
            {

                // var TableName = Convert.ToString(this.gridView1.GetFocusedRowCellValue("TableName"));
                var LedgerCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("LedgerCode"));
                var CostCenter = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CostCenter"));
                spSelectLedgersTableAdapter.Fill(dsLedger.spSelectLedgers, LedgerCode, AppConstant.CompCode, CostCenter);
                //this.spSelectTaxRatesTableAdapter.Fill(this.dsTaxRates.spSelectTaxRates, TableName, FromAmount, EffectiveDate, AppConstant.UserID, Environment.MachineName);
                disableFields();
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

                glcostcenter.Enabled = false;
                txtCode.Enabled = false;
                txtName.Enabled = false;

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

                txtCode.Enabled = true;
                txtName.Enabled = true;
                glcostcenter.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void LoadGrid()
        {
            try
            {
                spSelectAllLedgersTableAdapter.Fill(dsLedger.spSelectAllLedgers, AppConstant.CompCode);

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
                MessageBox.Show("Privilege Violation.You have insufficient right to Add Ledgers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void DeleteRecord()
        {
            if (this.ValidateRight("Delete", AppConstant.UserID))
            {
                try
                {


                    if (gridView1.SelectedRowsCount < 0)
                    {
                        MessageBox.Show("select a record to delete");
                        return;
                    }

                    if (MessageBox.Show("Do you want to delete Ledger  " + txtCode.Text, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {

                    }
                    else
                    {
                        this.spSelectAllLedgersTableAdapter.spDeleteLedger(txtCode.Text, AppConstant.CompCode, glcostcenter.EditValue.ToString());
                        MessageBox.Show("Record deleted successfully");
                        LoadGrid();
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to delete Ledgers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void SaveRecord()
        {
            try
            {
                if (this.ValidateRight("Add", AppConstant.UserID))
                {

                    spSelectAllLedgersTableAdapter.spSaveLedgers(txtCode.Text, txtName.Text, AppConstant.CompCode, glcostcenter.EditValue.ToString(), AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Saved Succesfully", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Ledger", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Delete", AppConstant.UserID))
            {
                DeleteRecord();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Delete Ledger", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Edit", AppConstant.UserID))
            {
                EnableField();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Edit Ledger", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Export", AppConstant.UserID))
            {
                gridView1.ShowPrintPreview();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Export Ledger", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}