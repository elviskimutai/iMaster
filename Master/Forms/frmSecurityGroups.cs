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
    public partial class frmSecurityGroups : Form
    {
        Security _Security = new Security();
        string SecurityModule = "Security Groups";
        public frmSecurityGroups()
        {
            InitializeComponent();
        }

        private void frmSecurityGroups_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("View", AppConstant.UserID))
                {
                    this.spSelectAllSecurityGroupsTableAdapter.Fill(this.dsSecurityGroups.spSelectAllSecurityGroups, AppConstant.UserID, Environment.MachineName);
                 ClearFields();
            }
                else
                {
                MessageBox.Show("Privilege Violation.You have insufficient right to View Security Groups", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    this.spSelectSecurityGroupsTableAdapter.spSaveSecurityGroups(
                  GroupCodeTextEdit.Text,
                  GroupNameTextEdit.Text,
                  NarrationTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Security group saved successfully");
                this.spSelectAllSecurityGroupsTableAdapter.Fill(this.dsSecurityGroups.spSelectAllSecurityGroups, AppConstant.UserID, Environment.MachineName);
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
                GroupCodeTextEdit.Text = "0";
                GroupNameTextEdit.Text = "0";
                NarrationTextEdit.Text = "New security group";
               
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
                GroupCodeTextEdit.Enabled = false;
                GroupNameTextEdit.Enabled = false;
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
                GroupCodeTextEdit.Enabled = true;
                GroupNameTextEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Edit", AppConstant.UserID))
                {
                    EnableField();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Approvers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Delete", AppConstant.UserID))
                {
              
                var GroupCode = Convert.ToString(GroupCodeTextEdit.Text);

                if (this.gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete security group " + GroupCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectSecurityGroupsTableAdapter.spDeleteSecurityGroups(GroupCode, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllSecurityGroupsTableAdapter.Fill(this.dsSecurityGroups.spSelectAllSecurityGroups, AppConstant.UserID, Environment.MachineName);
                }

                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Approvers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Export", AppConstant.UserID))
                {
                    this.gridView1.ShowPrintPreview();
                }


                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Approvers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                string GroupCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("GroupCode"));

                this.spSelectSecurityGroupsTableAdapter.Fill(this.dsSecurityGroups.spSelectSecurityGroups, GroupCode, AppConstant.UserID, Environment.MachineName);

                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
