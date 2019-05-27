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
    public partial class frmHRRecruitmentParam : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Recruitment Parameters";
        public frmHRRecruitmentParam()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmHRRecruitmentParam_Load(object sender, EventArgs e)
        {
            try
            {
                spgetUDCByCategoryTableAdapter.Fill(dsHRRecruitmentParams.spgetUDCByCategory, "Departments");
                DepartmentLookUpEdit.EditValue = dsHRRecruitmentParams.spgetUDCByCategory.DataSet.Tables["spgetUDCByCategory"].Rows[0]["Code"].ToString();
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

                this.spSelectAllHRRecruitmentParamsTableAdapter.Fill(this.dsHRRecruitmentParams.spSelectAllHRRecruitmentParams,AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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

                this.spSelectAllHRRecruitmentParamsTableAdapter.Insert(
                    AppConstant.CompCode,
                    DepartmentLookUpEdit.EditValue.ToString(),
                    JobPositionLookUpEdit.EditValue.ToString(),
                    JobTitleTextEdit.Text,
                   Convert.ToString(ParameterTextEdit.Text),
                   Convert.ToDouble(WeightTextEdit.Text),
                   RemarksTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Parameters saved successfully");
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
                //DepartmentLookUpEdit.EditValue.ToString(),
                // JobPositionLookUpEdit.EditValue.ToString(),
                //    JobTitleTextEdit.Text,
                  ParameterTextEdit.Text = "0";
                WeightTextEdit.Text = "0";
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

                DepartmentLookUpEdit.Enabled = false;
                JobPositionLookUpEdit.Enabled = false;
                JobTitleTextEdit.Enabled = false;
               ParameterTextEdit.Enabled = false;
               WeightTextEdit.Enabled = false;
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
                DepartmentLookUpEdit.Enabled = true;
                JobPositionLookUpEdit.Enabled = true;
                JobTitleTextEdit.Enabled = true;
                ParameterTextEdit.Enabled = true;
                WeightTextEdit.Enabled = true;
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

                var JobPosition = Convert.ToString(JobPositionLookUpEdit.EditValue);
                var Parameter = Convert.ToString(ParameterTextEdit.Text);
               // var EffectiveDate = Convert.ToDateTime(EffectiveDateDateEdit.DateTime);



                if (MessageBox.Show("Do you want to delete parameters for " + JobPosition, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllHRRecruitmentParamsTableAdapter.Delete(AppConstant.CompCode, JobPosition, Parameter, AppConstant.UserID, Environment.MachineName);
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
                var Parameter = Convert.ToString(this.gridView1.GetFocusedRowCellValue("Parameter"));
               // var EffectiveDate = Convert.ToDateTime(this.gridView1.GetFocusedRowCellValue("EffectiveDate"));
                this.spSelectHRRecruitmentParamsTableAdapter.Fill(this.dsHRRecruitmentParams.spSelectHRRecruitmentParams, AppConstant.CompCode, JobPosition, Parameter, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add recruitment parameters", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit recruitment parameters", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete recruitment parameters", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export recruitment parameters", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void DepartmentLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                hRJobRequisitionsTableAdapter.Fill(dsHRRecruitmentParams.HRJobRequisitions, AppConstant.CompCode,DepartmentLookUpEdit.EditValue.ToString());
                JobPositionLookUpEdit.EditValue = dsHRRecruitmentParams.HRJobRequisitions.DataSet.Tables["HRJobRequisitions"].Rows[0]["ReqNo"];
            }
            catch (Exception)
            {

               
            }
        }

        private void JobPositionLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                JobTitleTextEdit.Text = JobPositionLookUpEdit.GetColumnValue("JobTitle").ToString();
            }
            catch (Exception)
            {

              
            }
        }
    }
}