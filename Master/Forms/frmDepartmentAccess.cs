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
    public partial class frmDepartmentAccess : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Department Access";
      
        public frmDepartmentAccess()
        {
            InitializeComponent();
            
        }

        private void frmDepartmentAccess_Load(object sender, EventArgs e)
        {
            try
            {
                spgetUDCByCategoryTableAdapter.Fill(dsDepartmentAccess.spgetUDCByCategory, "Departments");
                spgetUsersTableAdapter.Fill(dsDepartmentAccess.spgetUsers, AppConstant.CompCode);
                RemarksTextEdit.Text = "New Department Access";
                spSelectAllDepartmentAccessTableAdapter.Fill(dsDepartmentAccess.spSelectAllDepartmentAccess, AppConstant.CompCode);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void DisableFields()
        {
            try
            {
                RemarksTextEdit.Enabled = false;
                UserNameSearchLookUpEdit.Enabled = false;
                DeptCodeGridLookUpEdit.Enabled = false;
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
                    RemarksTextEdit.Enabled = true;
                    UserNameSearchLookUpEdit.Enabled = true;
                    DeptCodeGridLookUpEdit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit department Access", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export department Access", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                    this.spSelectAllDepartmentAccessTableAdapter.Insert(AppConstant.CompCode, DeptCodeGridLookUpEdit.EditValue.ToString(), UserNameSearchLookUpEdit.EditValue.ToString(), RemarksTextEdit.Text, AppConstant.UserID, Environment.MachineName);

                    MessageBox.Show("department access saved successfully");
                    spSelectAllDepartmentAccessTableAdapter.Fill(dsDepartmentAccess.spSelectAllDepartmentAccess, AppConstant.CompCode);

                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add CostCenter Access", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                    if (this.gridView1.SelectedRowsCount < 0)
                    {
                        MessageBox.Show("select a record to delete");
                        return;
                    }

                    if (MessageBox.Show("Do you want to delete department Access " + DeptCodeGridLookUpEdit.EditValue.ToString() + " for CompCode " + AppConstant.CompCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {

                    }
                    else
                    {
                        this.spSelectAllDepartmentAccessTableAdapter.Delete(AppConstant.CompCode, DeptCodeGridLookUpEdit.EditValue.ToString(), UserNameSearchLookUpEdit.EditValue.ToString());

                        MessageBox.Show("Record deleted successfully");
                        spSelectAllDepartmentAccessTableAdapter.Fill(dsDepartmentAccess.spSelectAllDepartmentAccess, AppConstant.CompCode);
                    }

                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete department Access", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                string DeptCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("DeptCode"));
                

                this.spSelectDepartmentAccessTableAdapter.Fill(dsDepartmentAccess.spSelectDepartmentAccess,AppConstant.CompCode,DeptCode,UserName);
                DisableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}