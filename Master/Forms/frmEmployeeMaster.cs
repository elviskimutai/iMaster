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
using System.IO;

namespace Master.Forms
{
    public partial class frmEmployeeMaster : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Employeee information";
        public frmEmployeeMaster()
        {
            InitializeComponent();
           
        }

        private void frmEmployeeMaster_Load(object sender, EventArgs e)
        {
            try
            {
                this.countiesTableAdapter.Fill(this.dsEmployeeMaster.Counties);
                this.banksTableAdapter.Fill(this.dsEmployeeMaster.Banks);
                glBank.EditValue = dsEmployeeMaster.Banks.DataSet.Tables["Banks"].Rows[0][0].ToString();
                this.countriesTableAdapter.Fill(this.dsEmployeeMaster.Countries);
                userCodesTableAdapter.Fill(dsEmployeeMaster.UserCodes, "Departments");
                userCodesJobtypeTableAdapter.Fill(dsEmployeeMaster.UserCodesJobtype, "JobType");
                userCodesJobGradeTableAdapter.Fill(dsEmployeeMaster.UserCodesJobGrade, "Job Grade");
                spGetCompanyCostCentersTableAdapter.Fill(dsEmployeeMaster.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                LoadGrid();
                CostCenterLookUpEdit.EditValue = dsEmployeeMaster.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0][0].ToString();
                EmpNoTextEdit.ReadOnly = true;
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

                spSelectAllEmployeesMasterTableAdapter.Fill(dsEmployeeMaster.spSelectAllEmployeesMaster, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
               ClearFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void glBank_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.bankBranchesTableAdapter.Fill(this.dsEmployeeMaster.BankBranches, glBank.EditValue.ToString());
                BankBranchLookUpEdit.EditValue = this.dsEmployeeMaster.BankBranches.DataSet.Tables["BankBranches"].Rows[0][0].ToString();
            }
            catch (Exception)
            {

              
            }
        }
        public void ClearFields()
        {
            try
            {


                EmpNoTextEdit.Text = "0";
                EmpNamesTextEdit.Text = "0";
                CountryLookUpEdit.EditValue = "KE";
                CountyLookUpEdit.EditValue = "Nairobi";
                    PINNoTextEdit.Text = "0";
                IDNoTextEdit.Text = "0";
                    NSSFNoTextEdit.Text = "0";
                TaxTableTextEdit.Text = "PAYE";
                TaxTableTextEdit.ReadOnly = true;
                InsuranceNoTextEdit.Text = "0";
                DepartmentLookUpEdit.EditValue = "DPT1";
                HireDateDateEdit.DateTime = DateTime.Now;
                    PayStartDateDateEdit.DateTime = DateTime.Now;
                PayEndDateDateEdit.DateTime = DateTime.Now;
                LeaveStartDateDateEdit.DateTime = DateTime.Now;
                NationalityTextEdit.Text = "Kenyan";
                PostalAddressTextEdit.Text = "0";
                PhysicalAddressTextEdit.Text = "0";
                MobileTextEdit.Text = "0";
                EmailTextEdit.Text = "0";
                DisabilityDescTextEdit.Text = "N/A";
                DOBDateEdit.DateTime = DateTime.Now.AddYears(-30);
                RetirementDateDateEdit.DateTime = DateTime.Now.AddYears(35);
                MaritalStatusComboBoxEdit.Text = "Single";
                GenderComboBoxEdit.Text = "Male";
                LanguagesTextEdit.Text = "English";
                SupervisorTextEdit.Text = "0";
                PayStatusTextEdit.Text = "Active";
                JobTypeLookUpEdit.EditValue = "parmanent";
                JobGradeLookUpEdit.EditValue = "PG1";
                   PayFreqTextEdit.Text = "30";
                AnnualSalaryTextEdit.Text = "0";
                BasicSalaryTextEdit.Text = "0";
                HrsPerDayTextEdit.Text = "8";
                HourlyRateTextEdit.Text = "0";

                ReviewTypeTextEdit.Text = "Objective";
                AccNoTextEdit.Text = "0";
                AccNameTextEdit.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public void SaveRecord()
        {
            try
            {
                spSelectAllEmployeesMasterTableAdapter.Insert(
                    AppConstant.CompCode,
                    CostCenterLookUpEdit.EditValue.ToString(),
                    EmpNoTextEdit.Text,
                    EmpNamesTextEdit.Text,
                    CountryLookUpEdit.EditValue.ToString(),
                    CountyLookUpEdit.EditValue.ToString(),
                    PINNoTextEdit.Text,
                    IDNoTextEdit.Text,
                    NSSFNoTextEdit.Text,
                    TaxTableTextEdit.Text,
                    InsuranceNoTextEdit.Text,
                    DepartmentLookUpEdit.EditValue.ToString(),
                    HireDateDateEdit.DateTime,
                    PayStartDateDateEdit.DateTime,
                    PayEndDateDateEdit.DateTime,
                    LeaveStartDateDateEdit.DateTime,
                   NationalityTextEdit.Text,
                   PostalAddressTextEdit.Text,
                   PhysicalAddressTextEdit.Text,
                   MobileTextEdit.Text,
                   EmailTextEdit.Text,
                   IsDisabledCheckEdit.Checked,
                   DisabilityDescTextEdit.Text,
                   DOBDateEdit.DateTime,
                   RetirementDateDateEdit.DateTime,
                   MaritalStatusComboBoxEdit.Text,
                   GenderComboBoxEdit.Text,
                   LanguagesTextEdit.Text,
                   SupervisorTextEdit.Text,
                    (this.ImagePictureEdit.Image != null) ? imageToByteArray(ImagePictureEdit.Image) : null,
                   PayStatusTextEdit.Text,
                   JobTypeLookUpEdit.EditValue.ToString(),
                   JobGradeLookUpEdit.EditValue.ToString(),
                   PayFreqTextEdit.Text,
                   Convert.ToDecimal(AnnualSalaryTextEdit.Text),
                   Convert.ToDecimal(BasicSalaryTextEdit.Text),
                   Convert.ToDouble(HrsPerDayTextEdit.Text),
                   Convert.ToDecimal(HourlyRateTextEdit.Text),
                   PayPerHourCheckEdit.Checked,
                   TaxableCheckEdit.Checked,
                   NSSFExemptCheckEdit.Checked,
                   NHIFExemptCheckEdit.Checked,
                  OverTimeExemptCheckEdit.Checked,
                  ReviewTypeTextEdit.Text,
                  glBank.EditValue.ToString(),
                  BankBranchLookUpEdit.EditValue.ToString(),
                  AccNoTextEdit.Text,
                  AccNameTextEdit.Text,
                  Environment.MachineName,
                  AppConstant.UserID);
                MessageBox.Show("Record saved successfully.");
                LoadGrid();
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
                
                CostCenterLookUpEdit.Enabled = false;
                EmpNoTextEdit.Enabled = false;
                EmpNamesTextEdit.Enabled = false;
                CountryLookUpEdit.Enabled = false;
                CountyLookUpEdit.Enabled = false;
                PINNoTextEdit.Enabled = false;
                IDNoTextEdit.Enabled = false;
                NSSFNoTextEdit.Enabled = false;
                TaxTableTextEdit.Enabled = false;
                InsuranceNoTextEdit.Enabled = false;
                DepartmentLookUpEdit.Enabled = false;
                HireDateDateEdit.Enabled = false;
                PayStartDateDateEdit.Enabled = false;
                PayEndDateDateEdit.Enabled = false;
                LeaveStartDateDateEdit.Enabled = false;
                NationalityTextEdit.Enabled = false;
                PostalAddressTextEdit.Enabled = false;
                PhysicalAddressTextEdit.Enabled = false;
                MobileTextEdit.Enabled = false;
                EmailTextEdit.Enabled = false;
                IsDisabledCheckEdit.Enabled = false;
                DisabilityDescTextEdit.Enabled = false;
                DOBDateEdit.Enabled = false;
                RetirementDateDateEdit.Enabled = false;
                MaritalStatusComboBoxEdit.Enabled = false;
                GenderComboBoxEdit.Enabled = false;
                LanguagesTextEdit.Enabled = false;
                SupervisorTextEdit.Enabled = false;
                   PayStatusTextEdit.Enabled = false;
                JobTypeLookUpEdit.Enabled = false;
                JobGradeLookUpEdit.Enabled = false;
                PayFreqTextEdit.Enabled = false;
                AnnualSalaryTextEdit.Enabled = false;
                BasicSalaryTextEdit.Enabled = false;
               HrsPerDayTextEdit.Enabled = false;
               HourlyRateTextEdit.Enabled = false;
                PayPerHourCheckEdit.Enabled = false;
                TaxableCheckEdit.Enabled = false;
                NSSFExemptCheckEdit.Enabled = false;
                NHIFExemptCheckEdit.Enabled = false;
                OverTimeExemptCheckEdit.Enabled = false;
                ReviewTypeTextEdit.Enabled = false;
                glBank.Enabled = false;
                BankBranchLookUpEdit.Enabled = false;
                AccNoTextEdit.Enabled = false;
                AccNameTextEdit.Enabled = false;

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

                CostCenterLookUpEdit.Enabled = true;
                EmpNoTextEdit.Enabled = true;
                EmpNamesTextEdit.Enabled = true;
                CountryLookUpEdit.Enabled = true;
                CountyLookUpEdit.Enabled = true;
                PINNoTextEdit.Enabled = true;
                IDNoTextEdit.Enabled = true;
                NSSFNoTextEdit.Enabled = true;
                TaxTableTextEdit.Enabled = true;
                InsuranceNoTextEdit.Enabled = true;
                DepartmentLookUpEdit.Enabled = true;
                HireDateDateEdit.Enabled = true;
                PayStartDateDateEdit.Enabled = true;
                PayEndDateDateEdit.Enabled = true;
                LeaveStartDateDateEdit.Enabled = true;
                NationalityTextEdit.Enabled = true;
                PostalAddressTextEdit.Enabled = true;
                PhysicalAddressTextEdit.Enabled = true;
                MobileTextEdit.Enabled = true;
                EmailTextEdit.Enabled = true;
                IsDisabledCheckEdit.Enabled = true;
                DisabilityDescTextEdit.Enabled = true;
                DOBDateEdit.Enabled = true;
                RetirementDateDateEdit.Enabled = true;
                MaritalStatusComboBoxEdit.Enabled = true;
                GenderComboBoxEdit.Enabled = true;
                LanguagesTextEdit.Enabled = true;
                SupervisorTextEdit.Enabled = true;
                PayStatusTextEdit.Enabled = true;
                JobTypeLookUpEdit.Enabled = true;
                JobGradeLookUpEdit.Enabled = true;
                PayFreqTextEdit.Enabled = true;
                AnnualSalaryTextEdit.Enabled = true;
                BasicSalaryTextEdit.Enabled = true;
                HrsPerDayTextEdit.Enabled = true;
                HourlyRateTextEdit.Enabled = true;
                PayPerHourCheckEdit.Enabled = true;
                TaxableCheckEdit.Enabled = true;
                NSSFExemptCheckEdit.Enabled = true;
                NHIFExemptCheckEdit.Enabled = true;
                OverTimeExemptCheckEdit.Enabled = true;
                ReviewTypeTextEdit.Enabled = true;
                glBank.Enabled = true;
                BankBranchLookUpEdit.Enabled = true;
                AccNoTextEdit.Enabled = true;
                AccNameTextEdit.Enabled = true;
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

                var EmpNo = Convert.ToString(EmpNoTextEdit.Text);
                
                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete employee  " + EmpNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllEmployeesMasterTableAdapter.Delete(AppConstant.CompCode, EmpNo, AppConstant.UserID, Environment.MachineName);
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

                var EmpNo = Convert.ToString(this.gridView1.GetFocusedRowCellValue("EmpNo"));
                this.spSelectEmployeesMasterTableAdapter.Fill(dsEmployeeMaster.spSelectEmployeesMaster,AppConstant.CompCode, EmpNo, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Employeee information", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Employeee information", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Employeee information", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Employeee information", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void RetirementDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BasicSalaryTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                AnnualSalaryTextEdit.Text = (Convert.ToDecimal(BasicSalaryTextEdit.Text) * 12).ToString();
                HourlyRateTextEdit.Text = ((Convert.ToDecimal(BasicSalaryTextEdit.Text) / (Convert.ToDecimal(Convert.ToDecimal(HrsPerDayTextEdit.Text) * 26))).ToString());
            }
            catch (Exception)
            {

              
            }
        }

        private void EmpNamesTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                AccNameTextEdit.Text = EmpNamesTextEdit.Text;
            }
            catch (Exception)
            {

                
            }
        }

        private void DOBDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            RetirementDateDateEdit.DateTime = DOBDateEdit.DateTime.AddYears(60);
        }

        private void tlNew_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFields();
            }
            catch (Exception)
            {

              
            }
        }
    }
}