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
    public partial class frmJobAppraisals : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Job Appraisals";
        public frmJobAppraisals()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void JobPositionLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var jobTitle = JobPositionLookUpEdit.GetColumnValue("JobTitle").ToString();
                jobApplicationsTableAdapter.Fill(dsJobAppraisals.JobApplications, AppConstant.CompCode, jobTitle);
                AppNoLookUpEdit.EditValue = dsJobAppraisals.JobApplications.DataSet.Tables["JobApplications"].Rows[0]["AppNo"].ToString();
                JobTitleTextEdit.Text = JobPositionLookUpEdit.GetColumnValue("JobTitle").ToString();
                hRRecruitmentParamsTableAdapter.Fill(dsJobAppraisals.HRRecruitmentParams, AppConstant.CompCode, JobPositionLookUpEdit.EditValue.ToString());
                ParameterLookUpEdit.EditValue = dsJobAppraisals.HRRecruitmentParams.DataSet.Tables["HRRecruitmentParams"].Rows[0]["Parameter"].ToString();

            }
            catch (Exception)
            {
                
            }
        }

        private void AppNoLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ApplicantNamesTextEdit.Text = AppNoLookUpEdit.GetColumnValue("ApplicantNames").ToString();
            }
            catch (Exception)
            {

                
            }
        }
        public void LoadGrid()
        {
            try
            {

                this.spSelectAllHRJobAppraisalsTableAdapter.Fill(this.dsJobAppraisals.spSelectAllHRJobAppraisals, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
        public void SaveRecord()
        {
            try
            {
                this.spSelectAllHRJobAppraisalsTableAdapter.Insert(
                   AppConstant.CompCode,
                   JobPositionLookUpEdit.EditValue.ToString(),
                   JobTitleTextEdit.Text,
                   AppNoLookUpEdit.EditValue.ToString(),
                   ApplicantNamesTextEdit.Text,
                   IDNumberTextEdit.Text,
                   ParameterLookUpEdit.EditValue.ToString(),
                   Convert.ToDouble(ScoreTextEdit.Text),
                   RemarksTextEdit.Text,
                   InterViewerTextEdit.Text,
                   StatusTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Absence registered successfully");
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
               
                   IDNumberTextEdit.Text = "0";
              
                 ScoreTextEdit.Text = "0";
                RemarksTextEdit.Text = "Remarks";
                StatusTextEdit.Text = "0";
                InterViewerTextEdit.Text = "0";
                

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
                JobPositionLookUpEdit.Enabled = false;
                JobTitleTextEdit.Enabled = false;
                AppNoLookUpEdit.Enabled = false;
                ApplicantNamesTextEdit.Enabled = false;
                IDNumberTextEdit.Enabled = false;
                ParameterLookUpEdit.Enabled = false;
                ScoreTextEdit.Enabled = false;
                RemarksTextEdit.Enabled = false;
                StatusTextEdit.Enabled = false;
                InterViewerTextEdit.Enabled = false;


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
                JobPositionLookUpEdit.Enabled = true;
                JobTitleTextEdit.Enabled = true;
                AppNoLookUpEdit.Enabled = true;
                ApplicantNamesTextEdit.Enabled = true;
                IDNumberTextEdit.Enabled = true;
                ParameterLookUpEdit.Enabled = true;
                ScoreTextEdit.Enabled = true;
                RemarksTextEdit.Enabled = true;
                StatusTextEdit.Enabled = true;
                InterViewerTextEdit.Enabled = true;
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

                var JobPosition = Convert.ToString(JobPositionLookUpEdit.EditValue);
                var AppNo = Convert.ToString(AppNoLookUpEdit.EditValue);
                var Parameter = Convert.ToString(ParameterLookUpEdit.EditValue);
                var InterViewer = Convert.ToString(InterViewerTextEdit.EditValue);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete job appraisals  " + JobPosition, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllHRJobAppraisalsTableAdapter.Delete(AppConstant.CompCode, JobPosition, AppNo, InterViewer, Parameter, AppConstant.UserID, Environment.MachineName);
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

                var JobPosition = Convert.ToString(this.gridView1.GetFocusedRowCellValue("JobPosition"));
                var AppNo = Convert.ToString(this.gridView1.GetFocusedRowCellValue("AppNo"));
                var Parameter = Convert.ToString(this.gridView1.GetFocusedRowCellValue("Parameter"));
                var InterViewer = Convert.ToString(this.gridView1.GetFocusedRowCellValue("InterViewer"));

                this.spSelectHRJobAppraisalsTableAdapter.Fill(this.dsJobAppraisals.spSelectHRJobAppraisals, AppConstant.CompCode, JobPosition, AppNo, InterViewer, Parameter, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add job appraisals", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit job appraisals", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete job apprisals", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export job  appraisals", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void frmJobAppraisals_Load(object sender, EventArgs e)
        {
            try
            {
                spGetJobReqNoTableAdapter.Fill(dsJobAppraisals.spGetJobReqNo, AppConstant.CompCode);
                JobPositionLookUpEdit.EditValue = dsJobAppraisals.spGetJobReqNo.DataSet.Tables["spGetJobReqNo"].Rows[0]["ReqNo"].ToString();
                
                LoadGrid();
            }
            catch (Exception)
            {

                
            }
            
        }
    }
}