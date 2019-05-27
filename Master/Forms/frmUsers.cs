using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master.Forms
{
    public partial class frmUsers : Form
    {
        Security _Security = new Security();
        string SecurityModule = "Users";

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            if (this.ValidateRight("View", AppConstant.UserID))
            {

                ExpiryDateDateEdit.DateTime = DateTime.Now.AddYears(10);
            // TODO: This line of code loads data into the 'dsUsers.CostCenter' table. You can move, or remove it, as needed.
            this.costCenterTableAdapter.Fill(this.dsUsers.CostCenter);

            this.spSelectAllUsersTableAdapter.Fill(this.dsUsers.spSelectAllUsers,AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to View Users", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                if (this.ValidateRight("Delete", AppConstant.UserID))
                {
                    var UserName = Convert.ToString(UserNameTextEdit.Text);
                var UserID = Convert.ToString(UserNameTextEdit.Text);
                if (this.gridView1.SelectedRowsCount<0)
                {
                    MessageBox.Show("select record to delete");
                    return;
                }
               
                if (MessageBox.Show("Do you want to user "+UserName,"Confirm deletion",MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.Yes)
                {
                  
                }
                else
                {
                    this.spSelectUsersTableAdapter.spDeleteUsers(UserName, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllUsersTableAdapter.Fill(this.dsUsers.spSelectAllUsers,AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
                }
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Users", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    var password = PasswordTextEdit.Text.ToString();
                var ConfirmPassword = ConfirmPasswordTextEdit.Text.ToString();
                if (password== ConfirmPassword)
                {
                    this.spSelectUsersTableAdapter.spSaveUsers(
                                        AppConstant.CompCode,
                                       UserNameTextEdit.Text.ToString(),
                                       FullNamesTextEdit.Text.ToString(),
                                       SkypensionCryptoEngine.Encrypt(password, true),
                                       SkypensionCryptoEngine.Encrypt(ConfirmPassword, true),
                                       EmailTextEdit.Text.ToString(),
                                       TelephoneTextEdit.Text.ToString(),
                                       ExpiryDateDateEdit.DateTime,
                                       IsActiveCheckEdit.Checked,
                                       SuperUserCheckEdit.Checked,
                                       CCCodeTextEdit.EditValue.ToString(),
                                       NarrationTextEdit.Text.ToString(),
                                       Environment.MachineName,
                                       AppConstant.UserID
                                       );
                    MessageBox.Show("User saved successfully");
                    this.spSelectAllUsersTableAdapter.Fill(this.dsUsers.spSelectAllUsers,AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);

                }
                else
                {
                    MessageBox.Show("Sorry, your passwords don't match");
                }
            }
                else
                {
                MessageBox.Show("Privilege Violation.You have insufficient right to add Users", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
               
                string User = Convert.ToString(this.gridView1.GetFocusedRowCellValue("UserName"));
                this.costCenterTableAdapter.Fill(this.dsUsers.CostCenter);
                this.spSelectUsersTableAdapter.Fill(this.dsUsers.spSelectUsers, User, AppConstant.UserID, Environment.MachineName);

                disableFields();
                    }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
            } 
        }

        private void gridView1_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
           MessageBox.Show(e.ErrorText);
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Users", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
                UserNameTextEdit.Enabled = false;
                FullNamesTextEdit.Enabled = false;
                PasswordTextEdit.Enabled = false;
                ConfirmPasswordTextEdit.Enabled = false;
                EmailTextEdit.Enabled = false;
                TelephoneTextEdit.Enabled = false;
                ExpiryDateDateEdit.Enabled = false;
                IsActiveCheckEdit.Enabled = false;
                SuperUserCheckEdit.Enabled = false;
                CCCodeTextEdit.Enabled = false;
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
                UserNameTextEdit.Enabled = true;
                FullNamesTextEdit.Enabled = true;
                PasswordTextEdit.Enabled = true;
                ConfirmPasswordTextEdit.Enabled = true;
                EmailTextEdit.Enabled = true;
                TelephoneTextEdit.Enabled = true;
                ExpiryDateDateEdit.Enabled = true;
                IsActiveCheckEdit.Enabled = true;
                SuperUserCheckEdit.Enabled = true;
                CCCodeTextEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
               

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Users", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
