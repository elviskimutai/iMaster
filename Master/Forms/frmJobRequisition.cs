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
    public partial class frmJobRequisition : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Job Requisition";
        public frmJobRequisition()
        {
            InitializeComponent();
           

        }
        public void LoadGrid()
        {
            try
            {

                this.spSelectAllHRJobRequisitionsTableAdapter.Fill(this.dsJobRequisition.spSelectAllHRJobRequisitions, AppConstant.CompCode,  AppConstant.UserID, Environment.MachineName);
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
                this.spSelectAllHRJobRequisitionsTableAdapter.Insert(
                    AppConstant.CompCode,
                    CostCenterTextEdit.EditValue.ToString(),
                    DepartmentLookUpEdit.EditValue.ToString(),
                    ReqNoTextEdit.Text,
                    ReqDateDateEdit.DateTime,
                    JobTitleTextEdit.Text,
                    PayGradeLookUpEdit.EditValue.ToString(),
                   Convert.ToDecimal(SalaryEstimateTextEdit.Text),
                    NarrationMemoEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Job requisition saved successfully");
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

                ReqNoTextEdit.Text = "0";
                ReqDateDateEdit.DateTime = DateTime.Now;
                JobTitleTextEdit.Text = "0";
                   // PayGradeLookUpEdit.EditValue.ToString(),
                   SalaryEstimateTextEdit.Text = "0";
                NarrationMemoEdit.Text = "Remarks";

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
                CostCenterTextEdit.Enabled = false;
                DepartmentLookUpEdit.Enabled = false;
                ReqNoTextEdit.Enabled = false;
                ReqDateDateEdit.Enabled = false;
                JobTitleTextEdit.Enabled = false;
                PayGradeLookUpEdit.Enabled = false;
                SalaryEstimateTextEdit.Enabled = false;
                NarrationMemoEdit.Enabled = false;



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
                CostCenterTextEdit.Enabled = true;
                DepartmentLookUpEdit.Enabled = true;
                ReqNoTextEdit.Enabled = true;
                ReqDateDateEdit.Enabled = true;
                JobTitleTextEdit.Enabled = true;
                PayGradeLookUpEdit.Enabled = true;
                SalaryEstimateTextEdit.Enabled = true;
                NarrationMemoEdit.Enabled = true;
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

                var ReqNo = Convert.ToString(ReqNoTextEdit.Text);
                
                
                if (MessageBox.Show("Do you want to delete Job requisition  " + ReqNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllHRJobRequisitionsTableAdapter.Delete(AppConstant.CompCode, ReqNo, AppConstant.UserID, Environment.MachineName);
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
                

                this.spSelectHRJobRequisitionsTableAdapter.Fill(this.dsJobRequisition.spSelectHRJobRequisitions, AppConstant.CompCode, ReqNo, AppConstant.UserID, Environment.MachineName);

                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmJobRequisition_Load(object sender, EventArgs e)
        {
            try
            {
                spGetCompanyCostCentersTableAdapter.Fill(dsJobRequisition.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                CostCenterTextEdit.EditValue = dsJobRequisition.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["cccode"].ToString();
                spgetUDCByCategoryTableAdapter.Fill(dsJobRequisition.spgetUDCByCategory, "Departments");
                DepartmentLookUpEdit.EditValue= dsJobRequisition.spgetUDCByCategory.DataSet.Tables["spgetUDCByCategory"].Rows[0]["Code"].ToString();
                
                spgetJobGradeTableAdapter.Fill(dsJobRequisition.spgetJobGrade, "Job Grade");
                PayGradeLookUpEdit.EditValue = dsJobRequisition.spgetJobGrade.DataSet.Tables["spgetJobGrade"].Rows[0]["Code"].ToString();
                LoadGrid();
            }
            catch (Exception)
            {

               
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Job requisition", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit job requisition", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Job Requisition", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Exportjob requisition", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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