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
    public partial class frmJobDescription : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Job Description";
        public frmJobDescription()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmJobDescription_Load(object sender, EventArgs e)
        {
            try
            {
                spGetJobReqNoTableAdapter.Fill(dsDescription.spGetJobReqNo, AppConstant.CompCode);
                ReqNoLookUpEdit.EditValue = dsDescription.spGetJobReqNo.DataSet.Tables["spGetJobReqNo"].Rows[0]["ReqNo"];
                LoadGrid();
            }
            catch (Exception)
            {

                
            }
        }
        public void LoadGrid()
        {
            try
            {

                this.spSelectAllHRJobDescriptionsTableAdapter.Fill(this.dsDescription.spSelectAllHRJobDescriptions,AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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

                this.spSelectAllHRJobDescriptionsTableAdapter.Insert(
                    AppConstant.CompCode,
                    ReqNoLookUpEdit.EditValue.ToString(),
                    JobTitleTextEdit.Text,
                    AppDueDateDateEdit.DateTime,
                    JobDescMemoEdit.Text,
                    RemarksTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Job description saved successfully");
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

                // ReqNoLookUpEdit.EditValue.ToString(),
                //JobTitleTextEdit.Text,
                AppDueDateDateEdit.DateTime = DateTime.Now;
                JobDescMemoEdit.Text = "Job description";
                    RemarksTextEdit.Text = "Remarks";
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


                ReqNoLookUpEdit.Enabled = false;
                JobTitleTextEdit.Enabled = false;
                AppDueDateDateEdit.Enabled = false;
                JobDescMemoEdit.Enabled = false;
                RemarksTextEdit.Enabled = false;

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
                ReqNoLookUpEdit.Enabled = true;
                JobTitleTextEdit.Enabled = true;
                AppDueDateDateEdit.Enabled = true;
                JobDescMemoEdit.Enabled = true;
                RemarksTextEdit.Enabled = true;
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

                var ReqNo = Convert.ToString(ReqNoLookUpEdit.EditValue);
                var JobTitle = Convert.ToString(JobTitleTextEdit.Text);
                //var EffectiveDate = Convert.ToDateTime(EffectiveDateDateEdit.DateTime);



                if (MessageBox.Show("Do you want to delete ReqNo " + ReqNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllHRJobDescriptionsTableAdapter.Delete(AppConstant.CompCode, ReqNo, JobTitle, AppConstant.UserID, Environment.MachineName);
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

                var ReqNo = Convert.ToString(this.gridView1.GetFocusedRowCellValue("ReqNo"));
                var JobTitle = Convert.ToString(this.gridView1.GetFocusedRowCellValue("JobTitle"));
               
                this.spSelectHRJobDescriptionsTableAdapter.Fill(this.dsDescription.spSelectHRJobDescriptions, AppConstant.CompCode, ReqNo, JobTitle,AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add job description", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Job decription", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete job description", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export job description", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void ReqNoLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                JobTitleTextEdit.Text = ReqNoLookUpEdit.GetColumnValue("JobTitle").ToString();
            }
            catch (Exception)
            {

              
            }
        }
    }
}