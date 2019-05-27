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
    public partial class frmLeaveTypes : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Leave Types";
        public frmLeaveTypes()
        {
            InitializeComponent();
        }

        private void frmLeaveTypes_Load(object sender, EventArgs e)
        {
            try
            {

                //AppConstant.CompCode = "001";
                //AppConstant.UserID = "steve@live.com";
                this.userCodesTableAdapter.Fill(dsLeaveTypes.UserCodes, "Job Grade");
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

                this.spSelectAllLeaveTypesTableAdapter.Fill(this.dsLeaveTypes.spSelectAllLeaveTypes, AppConstant.UserID, Environment.MachineName);
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
                this.spSelectAllLeaveTypesTableAdapter.Insert(
                    LeaveCodeTextEdit.Text,
                    LeaveDescriptionTextEdit.Text,
                    EffectiveDateDateEdit.DateTime,
                    AllowPayCheckEdit.Checked,
                    JobGradeTextEdit.EditValue.ToString(),
                    ApplyToAllCheckEdit.Checked,
                    chkAllowCarryOver.Checked,
                    Convert.ToDouble(txtMaxCarryOver.Text),
                   Convert.ToDouble(LeaveDaysTextEdit.Text),
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Leave types saved successfully");
                this.spSelectAllLeaveTypesTableAdapter.Fill(this.dsLeaveTypes.spSelectAllLeaveTypes, AppConstant.UserID, Environment.MachineName);
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
                LeaveCodeTextEdit.Text = "0";
                LeaveDescriptionTextEdit.Text = "0";
                    EffectiveDateDateEdit.DateTime = DateTime.Now;
                    AllowPayCheckEdit.Checked = true;
                    ApplyToAllCheckEdit.Checked = true;
                   LeaveDaysTextEdit.Text = "0";
                
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
                LeaveCodeTextEdit.Enabled = false;
                LeaveDescriptionTextEdit.Enabled = false;
                EffectiveDateDateEdit.Enabled = false;
                AllowPayCheckEdit.Enabled = false;
                JobGradeTextEdit.Enabled = false;
                ApplyToAllCheckEdit.Enabled = false;
                LeaveDaysTextEdit.Enabled = false;
                chkAllowCarryOver.Enabled = false;
                txtMaxCarryOver.Enabled = false;


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
                LeaveCodeTextEdit.Enabled = true;
                LeaveDescriptionTextEdit.Enabled = true;
                EffectiveDateDateEdit.Enabled = true;
                AllowPayCheckEdit.Enabled = true;
                JobGradeTextEdit.Enabled = true;
                ApplyToAllCheckEdit.Enabled = true;
                LeaveDaysTextEdit.Enabled = true;
                chkAllowCarryOver.Enabled = true;
                txtMaxCarryOver.Enabled = true;
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

                var LeaveCode = Convert.ToString(LeaveCodeTextEdit.Text);
                var JobGrade = Convert.ToString(JobGradeTextEdit.Text);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete leave type  " + LeaveCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllLeaveTypesTableAdapter.Delete(LeaveCode, JobGrade, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllLeaveTypesTableAdapter.Fill(this.dsLeaveTypes.spSelectAllLeaveTypes, AppConstant.UserID, Environment.MachineName);
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

                var LeaveCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("LeaveCode"));
                var JobGrade = Convert.ToString(this.gridView1.GetFocusedRowCellValue("JobGrade"));
                this.spSelectLeaveTypesTableAdapter.Fill(this.dsLeaveTypes.spSelectLeaveTypes, LeaveCode, JobGrade, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Leave Types", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Leave Types", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Leave Types", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Leave Types", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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