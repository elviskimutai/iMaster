using System;

using System.Windows.Forms;

namespace Master.Forms
{
    public partial class frmAbsenceRegistration : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Absence Registration";
       
        public frmAbsenceRegistration()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmAbsenceRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                spGetCompanyCostCentersTableAdapter.Fill(dsAbsenceRegistration.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                CostCenterLookUpEdit.EditValue = dsAbsenceRegistration.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["cccode"].ToString();
                spGetEmployeeCodesTableAdapter.Fill(dsAbsenceRegistration.spGetEmployeeCodes, AppConstant.CompCode,CostCenterLookUpEdit.EditValue.ToString());
                EmpNoLookUpEdit.EditValue = dsAbsenceRegistration.spGetEmployeeCodes.DataSet.Tables["spGetEmployeeCodes"].Rows[0]["EmpNo"].ToString();
              
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

                this.spSelectAllAbsenceRegistrationTableAdapter.Fill(this.dsAbsenceRegistration.spSelectAllAbsenceRegistration, AppConstant.UserID,  Environment.MachineName,AppConstant.CompCode);
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
                this.spSelectAllAbsenceRegistrationTableAdapter.Insert(
                    RegNoTextEdit.EditValue.ToString(),
                    EmpNoLookUpEdit.EditValue.ToString(),
                    AppConstant.CompCode,
                    CostCenterLookUpEdit.EditValue.ToString(),
                    DescriptionTextEdit.Text,
                    FromDateDateEdit.DateTime,
                    ToDateDateEdit.DateTime,
                    Convert.ToInt32(HoursTextEdit.Text),
                    NarrationTextEdit.Text,
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
                RegNoTextEdit.Text = "0";
                DescriptionTextEdit.Text = "0";
                FromDateDateEdit.DateTime = DateTime.Now;
                ToDateDateEdit.DateTime = DateTime.Now;
                HoursTextEdit.Text = "0";
                NarrationTextEdit.Text = "0";
                
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
                RegNoTextEdit.Enabled = false;
                EmpNoLookUpEdit.Enabled = false;
                CostCenterLookUpEdit.Enabled = false;
                DescriptionTextEdit.Enabled = false;
                FromDateDateEdit.Enabled = false;
                ToDateDateEdit.Enabled = false;
                HoursTextEdit.Enabled = false;
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
                RegNoTextEdit.Enabled = true;
                EmpNoLookUpEdit.Enabled = true;
                CostCenterLookUpEdit.Enabled = true;
                DescriptionTextEdit.Enabled = true;
                FromDateDateEdit.Enabled = true;
                ToDateDateEdit.Enabled = true;
                HoursTextEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
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

                var RegNo = Convert.ToString(RegNoTextEdit.Text);
                var CostCenter = Convert.ToString(CostCenterLookUpEdit.EditValue);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete Absence record  " + RegNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllAbsenceRegistrationTableAdapter.Delete(RegNo, AppConstant.CompCode, CostCenter, AppConstant.UserID, Environment.MachineName);
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

                var CostCenter = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CostCenter"));
                var RegNo = Convert.ToString(this.gridView1.GetFocusedRowCellValue("RegNo"));

                this.spSelectAbsenceRegistrationTableAdapter.Fill(this.dsAbsenceRegistration.spSelectAbsenceRegistration,RegNo, AppConstant.CompCode, CostCenter,  AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to register absence", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit absence registration", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Absence registration", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Absence  Registration", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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