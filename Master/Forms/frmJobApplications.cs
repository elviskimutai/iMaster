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
    public partial class frmJobApplications : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Job Applications";
        public frmJobApplications()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmJobApplications_Load(object sender, EventArgs e)
        {
            try
            {
                
                spGetJobReqNoTableAdapter.Fill(dsJobApplications.spGetJobReqNo, AppConstant.CompCode);
                PositionIDLookUpEdit.EditValue = dsJobApplications.spGetJobReqNo.DataSet.Tables["spGetJobReqNo"].Rows[0]["ReqNo"].ToString();
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

                this.spSelectAllJobApplicationsTableAdapter.Fill(this.dsJobApplications.spSelectAllJobApplications, AppConstant.CompCode,AppConstant.UserID, Environment.MachineName);
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
                this.spSelectAllJobApplicationsTableAdapter.Insert(
                    AppConstant.CompCode,
                    AppNoTextEdit.Text,
                    PositionIDLookUpEdit.EditValue.ToString(),
                    JobTitleTextEdit.Text,
                    AppDateDateEdit.DateTime,
                    ApplicantNamesTextEdit.Text,
                    IDNumberTextEdit.Text,
                    PINNoTextEdit.Text,
                    RemarksMemoEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Job application saved successfully");
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
                AppNoTextEdit.Text = "0";
                 //PositionIDLookUpEdit.EditValue.ToString(),
                  //  JobTitleTextEdit.Text = "0";
                AppDateDateEdit.DateTime = DateTime.Now;
                    ApplicantNamesTextEdit.Text = "0";
                IDNumberTextEdit.Text = "0";
                PINNoTextEdit.Text = "0";
                RemarksMemoEdit.Text = "Remarks";

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
                AppNoTextEdit.Enabled = false;
                PositionIDLookUpEdit.Enabled = false;
                JobTitleTextEdit.Enabled = false;
                AppDateDateEdit.Enabled = false;
                ApplicantNamesTextEdit.Enabled = false;
                IDNumberTextEdit.Enabled = false;
                PINNoTextEdit.Enabled = false;
                RemarksMemoEdit.Enabled = false;


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
                AppNoTextEdit.Enabled = true;
                PositionIDLookUpEdit.Enabled = true;
                JobTitleTextEdit.Enabled = true;
                AppDateDateEdit.Enabled = true;
                ApplicantNamesTextEdit.Enabled = true;
                IDNumberTextEdit.Enabled = true;
                PINNoTextEdit.Enabled = true;
                RemarksMemoEdit.Enabled = true;
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

                var AppNo = Convert.ToString(AppNoTextEdit.Text);
               /// var CostCenter = Convert.ToString(CostCenterLookUpEdit.EditValue);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete job application  " + AppNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllJobApplicationsTableAdapter.Delete(AppConstant.CompCode, AppNo, AppConstant.UserID, Environment.MachineName);
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

                var AppNo = Convert.ToString(this.gridView1.GetFocusedRowCellValue("AppNo"));
               // var RegNo = Convert.ToString(this.gridView1.GetFocusedRowCellValue("RegNo"));

                this.spSelectJobApplicationsTableAdapter.Fill(this.dsJobApplications.spSelectJobApplications,AppConstant.CompCode, AppNo, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to save job applications", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit job applications", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete job applications", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export job  application", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void PositionIDLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                JobTitleTextEdit.Text = PositionIDLookUpEdit.GetColumnValue("JobTitle").ToString();
            }
            catch (Exception)
            {
                
            }
        }
    }
}