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
    public partial class frmbanks : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Banks";
        public frmbanks()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmbanks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBanks.Countries' table. You can move, or remove it, as needed.
            try
            {
                this.countriesTableAdapter.Fill(this.dsBanks.Countries);
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
        public void LoadGrid()
        {
            try
            {

                this.spSelectAllBanksTableAdapter.Fill(this.dsBanks.spSelectAllBanks,  AppConstant.UserID, Environment.MachineName);
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

                this.spSelectAllBanksTableAdapter.Insert(
                    BankCodeTextEdit.Text,
                    BankNameTextEdit.Text,

                    CountryCodeLookUpEdit.EditValue.ToString(),
                    ContactDetailsTextEdit.Text,
                    PostalAddressTextEdit.Text,
                    PhysicalAddressTextEdit.Text,
                    NarrationTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Bank saved successfully");
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

                BankCodeTextEdit.Text = "0";

                CountryCodeLookUpEdit.EditValue = "KE";
                    ContactDetailsTextEdit.Text = "0";
                PostalAddressTextEdit.Text = "0";
                PhysicalAddressTextEdit.Text = "0";
                NarrationTextEdit.Text = "New bank";
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
                BankCodeTextEdit.Enabled = false;
                BankNameTextEdit.Enabled = false;

                CountryCodeLookUpEdit.Enabled = false;
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
                BankCodeTextEdit.Enabled = true;
                BankNameTextEdit.Enabled = true;

                CountryCodeLookUpEdit.Enabled = true;
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

                var BankCode = Convert.ToString(BankCodeTextEdit.Text);
                var CountryCode = Convert.ToString(CountryCodeLookUpEdit.EditValue);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete bank  " + BankCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllBanksTableAdapter.Delete(BankCode, CountryCode, AppConstant.UserID, Environment.MachineName);
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

                var BankCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("BankCode"));
                var CountryCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CountryCode"));
                this.spSelectBanksTableAdapter.Fill(this.dsBanks.spSelectBanks, BankCode, CountryCode, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Banks", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Banks", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Banks", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Banks", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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