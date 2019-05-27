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
    public partial class frmBankAccounts : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Bank Accounts";
        public frmBankAccounts()
        {
            InitializeComponent();

            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";

        }

        private void frmBankAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBankAccounts.COA' table. You can move, or remove it, as needed.
            try
            {
                this.cOATableAdapter.Fill(this.dsBankAccounts.COA);
                LoadGrid();
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

                this.spSelectAllBankAccountsTableAdapter.Fill(this.dsBankAccounts.spSelectAllBankAccounts,AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
                GLAccLookUpEdit.EditValue = "0";
                AccNameTextEdit.Text = "0";
                AccNumberTextEdit.Text = "0";
                EffectiveDateDateEdit.DateTime = DateTime.Now;
                   MinBalanceTextEdit.Text = "0";
                OverdraftLimitTextEdit.Text = "0";
                NarrationMemoExEdit.Text = "Bank account";
                
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
                GLAccLookUpEdit.Enabled = false;
                AccNameTextEdit.Enabled = false;
                AccNumberTextEdit.Enabled = false;
                EffectiveDateDateEdit.Enabled = false;
                MinBalanceTextEdit.Enabled = false;
                AllowOverdraftCheckEdit.Enabled = false;
               OverdraftLimitTextEdit.Enabled = false;
                NarrationMemoExEdit.Enabled = false;

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
                GLAccLookUpEdit.Enabled = true;
                AccNameTextEdit.Enabled = true;
                AccNumberTextEdit.Enabled = true;
                EffectiveDateDateEdit.Enabled = true;
                MinBalanceTextEdit.Enabled = true;
                AllowOverdraftCheckEdit.Enabled = true;
                OverdraftLimitTextEdit.Enabled = true;
                NarrationMemoExEdit.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void Saverecord()
        {
            try
            {
                spSelectAllBankAccountsTableAdapter.Insert(
                    AppConstant.CompCode,
                    GLAccLookUpEdit.EditValue.ToString(),
                    AccNameTextEdit.Text,AccNumberTextEdit.Text,
                    EffectiveDateDateEdit.DateTime,
                    Convert.ToDecimal(MinBalanceTextEdit.Text),
                    AllowOverdraftCheckEdit.Checked,
                    Convert.ToDecimal(OverdraftLimitTextEdit.Text),
                    NarrationMemoExEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID);
                MessageBox.Show("Bank account saved successfully");
                LoadGrid();
                ClearFields();
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
        public void SelectRecord()
        {
            try
            {
                var AccNumber = Convert.ToString(this.gridView1.GetFocusedRowCellValue("AccNumber"));
                spSelectBankAccountsTableAdapter.Fill(dsBankAccounts.spSelectBankAccounts, AccNumber, AppConstant.UserID, Environment.MachineName);
                disableFields();
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

                var AccNumber = Convert.ToString(AccNumberTextEdit.Text);
               
              

                if (MessageBox.Show("Do you want to delete bank account  " + AccNumber, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllBankAccountsTableAdapter.Delete(AccNumber, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    LoadGrid();
                }


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
                    Saverecord();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add bank accounts", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Delete", AppConstant.UserID))
            {
                DeleteRecord();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to delete bank accounts", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {

            if (this.ValidateRight("Edit", AppConstant.UserID))
            {
                EnableField();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Edit bank accounts", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Export", AppConstant.UserID))
            {
                this.gridView1.ShowPrintPreview();
            }


            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Export bank accounts", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}