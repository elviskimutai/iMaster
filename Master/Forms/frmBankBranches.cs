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
    public partial class frmBankBranches : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Bank Branches";
        public frmBankBranches()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmBankBranches_Load(object sender, EventArgs e)
        {
            try
            {
                this.countriesTableAdapter.Fill(this.dsBankBranches.Countries);

                LoadGrid();
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
        private void CountryCodeTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.banksTableAdapter.Fill(this.dsBankBranches.Banks, CountryCodeTextEdit.EditValue.ToString());
                BankCodeTextEdit.EditValue = dsBankBranches.Banks.DataSet.Tables["Banks"].Rows[0][0].ToString();
            }
            catch (Exception)
            {

               
            }
        }

        public void LoadGrid()
        {
            try
            {

                this.spSelectAllBankBranchesTableAdapter.Fill(this.dsBankBranches.spSelectAllBankBranches,  AppConstant.UserID, Environment.MachineName);
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

                this.spSelectAllBankBranchesTableAdapter.Insert(
                    BranchCodeTextEdit.Text,
                    BranchNameTextEdit.Text,
                    CountryCodeTextEdit.EditValue.ToString(),
                    BankCodeTextEdit.EditValue.ToString(),
                    ContactDetailsTextEdit.Text,
                    PostalAddressTextEdit.Text,
                    PhysicalAddressTextEdit.Text,
                    NarrationTextEdit.Text,

                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Bank branch saved successfully");
                LoadGrid();
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
                BranchCodeTextEdit.Text = "0";
                BranchNameTextEdit.Text = "0";
                CountryCodeTextEdit.EditValue = "KE";
                 ContactDetailsTextEdit.Text = "0";
                PostalAddressTextEdit.Text = "0";
                PhysicalAddressTextEdit.Text = "0";
                NarrationTextEdit.Text = "New bank branch ";
                
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
                BranchCodeTextEdit.Enabled = false;
                BranchNameTextEdit.Enabled = false;
                CountryCodeTextEdit.Enabled = false;
                BankCodeTextEdit.Enabled = false;
                ContactDetailsTextEdit.Enabled = false;
                PostalAddressTextEdit.Enabled = false;
                PhysicalAddressTextEdit.Enabled = false;
                NarrationTextEdit.Enabled = false;

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
                BranchCodeTextEdit.Enabled = true;
                BranchNameTextEdit.Enabled = true;
                CountryCodeTextEdit.Enabled = true;
                BankCodeTextEdit.Enabled = true;
                ContactDetailsTextEdit.Enabled = true;
                PostalAddressTextEdit.Enabled = true;
                PhysicalAddressTextEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
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

                var BranchCode = Convert.ToString(BranchCodeTextEdit.Text);
                var CountryCode = Convert.ToString(CountryCodeTextEdit.EditValue);
                var BankCode = Convert.ToString(BankCodeTextEdit.EditValue);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete bank branch  " + BranchCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllBankBranchesTableAdapter.Delete(BranchCode, CountryCode, BankCode, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    LoadGrid();
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

                var BranchCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("BranchCode"));
                var CountryCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CountryCode"));
                var BankCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("BankCode"));
                this.spSelectBankBranchesTableAdapter.Fill(this.dsBankBranches.spSelectBankBranches, BranchCode, CountryCode, BankCode, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Bank Branches", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Bank Branches", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Bank Branches", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Bank Branches", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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