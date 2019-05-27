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
    public partial class frmUserGroups : Form
    {
        Security _Security = new Security();
        string SecurityModule = "User Groups";
        public frmUserGroups()
        {
            InitializeComponent();
        }

        private void frmUserGroups_Load(object sender, EventArgs e)
        {
            if (this.ValidateRight("View", AppConstant.UserID))
            {
                // TODO: This line of code loads data into the 'userGroups.SecurityGroups' table. You can move, or remove it, as needed.
                this.securityGroupsTableAdapter.Fill(this.userGroups.SecurityGroups);
            // TODO: This line of code loads data into the 'userGroups.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.userGroups.Users);

            try
            {
               
                this.spSelectAllUserGroupsTableAdapter.Fill(this.userGroups.spSelectAllUserGroups, AppConstant.UserID, Environment.MachineName);
                ClearFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to View User Groups", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    this.spSelectUserGroupsTableAdapter.spSaveUserGroups(
                   UserNameTextEdit.EditValue.ToString(),
                   GroupCodeTextEdit.EditValue.ToString(),
                   NarrationTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("User group saved successfully");
                this.spSelectAllUserGroupsTableAdapter.Fill(this.userGroups.spSelectAllUserGroups, AppConstant.UserID, Environment.MachineName);
                ClearFields();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add User Groups", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                UserNameTextEdit.EditValue = AppConstant.UserID;
                GroupCodeTextEdit.Text = "0";
                NarrationTextEdit.Text = "New user group";
               
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
                GroupCodeTextEdit.Enabled = false;
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
                GroupCodeTextEdit.Enabled = true;
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit User Groups", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    var UserName = Convert.ToString(UserNameTextEdit.EditValue.ToString());
                var GroupCode = Convert.ToString(GroupCodeTextEdit.EditValue.ToString());

                if (this.gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete this user group " + GroupCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectUserGroupsTableAdapter.spDeleteUserGroups(UserName, GroupCode, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllUserGroupsTableAdapter.Fill(this.userGroups.spSelectAllUserGroups, AppConstant.UserID, Environment.MachineName);
                }
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete User Groups", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export User Groups", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                string UserName = Convert.ToString(this.gridView1.GetFocusedRowCellValue("UserName"));
                string GroupCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("GroupCode"));

                this.spSelectUserGroupsTableAdapter.Fill(this.userGroups.spSelectUserGroups, UserName, GroupCode, AppConstant.UserID, Environment.MachineName);

                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
