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
    public partial class frmUserRoles : Form
    {
        Security _Security = new Security();
        string SecurityModule = "User Roles";
        public frmUserRoles()
        {
            InitializeComponent();
        }

        private void frmUserRoles_Load(object sender, EventArgs e)
        {
            if (this.ValidateRight("View", AppConstant.UserID))
            {
                // TODO: This line of code loads data into the 'dsUserRoles.SecurityGroups' table. You can move, or remove it, as needed.
                this.securityGroupsTableAdapter.Fill(this.dsUserRoles.SecurityGroups);
            // TODO: This line of code loads data into the 'dsUserRoles.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.dsUserRoles.Roles);
            // TODO: This line of code loads data into the 'userGroups.SecurityGroups' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'dsUserRoles.SecurityGroups' table. You can move, or remove it, as needed.



            try
            {
               
                this.spSelectAllUserRolesTableAdapter.Fill(this.dsUserRoles.spSelectAllUserRoles, AppConstant.UserID, Environment.MachineName);
                ClearFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to View User Roles", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    this.spSelectUserRolesTableAdapter.spSaveUserRoles(
                   UserGroupTextEdit.EditValue.ToString(),
                   SecurityModuleTextEdit.EditValue.ToString(),
                   ViewCheckEdit.Checked,
                   AddCheckEdit.Checked,
                   EditCheckEdit.Checked,
                   DeleteCheckEdit.Checked,
                   ExportCheckEdit.Checked,
                    ImportCheckEdit.Checked,
                    ExpiryDateDateEdit.DateTime,

                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("User role saved successfully");
                this.spSelectAllUserRolesTableAdapter.Fill(this.dsUserRoles.spSelectAllUserRoles, AppConstant.UserID, Environment.MachineName);
                ClearFields();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add User Roles", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                UserGroupTextEdit.EditValue = "";
                   SecurityModuleTextEdit.EditValue = "";
                ViewCheckEdit.Checked = false;
                   AddCheckEdit.Checked = false;
                EditCheckEdit.Checked = false;
                DeleteCheckEdit.Checked = false;
                ExportCheckEdit.Checked = false;
                ImportCheckEdit.Checked = false;
                checkEdit1.Checked = false;
                ExpiryDateDateEdit.DateTime = DateTime.Now.AddYears(40);
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
                UserGroupTextEdit.Enabled = false;
                SecurityModuleTextEdit.Enabled = false;
                ViewCheckEdit.Enabled = false;
                AddCheckEdit.Enabled = false;
                EditCheckEdit.Enabled = false;
                DeleteCheckEdit.Enabled = false;
                ExportCheckEdit.Enabled = false;
                ImportCheckEdit.Enabled = false;
                ExpiryDateDateEdit.Enabled = false;
                checkEdit1.Enabled = false;
               

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
                UserGroupTextEdit.Enabled = true;
                SecurityModuleTextEdit.Enabled = true;
                ViewCheckEdit.Enabled = true;
                AddCheckEdit.Enabled = true;
                EditCheckEdit.Enabled = true;
                DeleteCheckEdit.Enabled = true;
                ExportCheckEdit.Enabled = true;
                ImportCheckEdit.Enabled = true;
                ExpiryDateDateEdit.Enabled = true;
                checkEdit1.Enabled = true;




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkEdit1.Checked==true)
                {
                    ViewCheckEdit.Checked = true;
                    AddCheckEdit.Checked = true;
                    EditCheckEdit.Checked = true;
                    DeleteCheckEdit.Checked = true;
                    ExportCheckEdit.Checked = true;
                    ImportCheckEdit.Checked = true;
                }
                else
                {
                    ViewCheckEdit.Checked = false;
                    AddCheckEdit.Checked = false;
                    EditCheckEdit.Checked = false;
                    DeleteCheckEdit.Checked = false;
                    ExportCheckEdit.Checked = false;
                    ImportCheckEdit.Checked = false;
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit User Roles", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    var UserGroup = Convert.ToString(UserGroupTextEdit.Text);
                var SecurityModule = Convert.ToString(SecurityModuleTextEdit.Text);


                if (UserGroup=="")
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete user group " + UserGroup+ " for security module "+ SecurityModule, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectUserRolesTableAdapter.spDeleteUserRoles(UserGroup, SecurityModule, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllUserRolesTableAdapter.Fill(this.dsUserRoles.spSelectAllUserRoles, AppConstant.UserID, Environment.MachineName);
                }
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete User Roles", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export User Roles", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                string UserGroup = Convert.ToString(this.gridView1.GetFocusedRowCellValue("UserGroup"));
                string SecurityModule = Convert.ToString(this.gridView1.GetFocusedRowCellValue("SecurityModule"));

                this.spSelectUserRolesTableAdapter.Fill(this.dsUserRoles.spSelectUserRoles, UserGroup, SecurityModule, AppConstant.UserID, Environment.MachineName);
               
                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
