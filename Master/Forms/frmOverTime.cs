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
    public partial class frmOverTime : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Over Time";
        public frmOverTime()
        {
            InitializeComponent();
        }

        private void frmOverTime_Load(object sender, EventArgs e)
        {

            try
            {
               
               
                costCenterTableAdapter.Fill(dsOverTime.CostCenter, AppConstant.CompCode,AppConstant.UserID);
                CostCenterTextEdit.EditValue = dsOverTime.CostCenter.DataSet.Tables["CostCenter"].Rows[0]["cccode"].ToString();
                userCodesTableAdapter.Fill(dsOverTime.UserCodes, "Shift Type");
                overTimeRatesTableAdapter.Fill(dsOverTime.OverTimeRates, AppConstant.CompCode);
                this.currenciesTableAdapter.Fill(this.dsOverTime.Currencies);
                LoadGrid();
                CurrencyTextEdit.EditValue = "KES";
                TotalPayTextEdit.ReadOnly = true;
                MultiplierTextEdit.ReadOnly = true;
                HourlyRateTextEdit.ReadOnly = true;
                PayrollItemTextEdit.ReadOnly = true;
                AppliedRateTextEdit.ReadOnly = true;
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

                this.spSelectAllOverTimeTableAdapter.Fill(this.dsOverTime.spSelectAllOverTime, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
                this.spSelectOverTimeTableAdapter.Insert(
                    EmpNoTextEdit.EditValue.ToString(),
                    AppConstant.CompCode,
                    CostCenterTextEdit.EditValue.ToString(),
                    EmpNameTextEdit.Text,
                    ShiftTypeTextEdit.EditValue.ToString(),
                    RateTypeTextEdit.EditValue.ToString(),
                    Convert.ToDouble(HoursWorkedTextEdit.Text),
                    WorkDateDateEdit.DateTime,
                    PayrollItemTextEdit.Text,
                    Convert.ToDecimal(HourlyRateTextEdit.Text),
                   Convert.ToDouble(MultiplierTextEdit.Text),
                   Convert.ToDecimal(AppliedRateTextEdit.Text),
                   FromDateDateEdit.DateTime,
                   ToDateDateEdit.DateTime,
                   Convert.ToDouble(TotalPayTextEdit.Text),
                   CurrencyTextEdit.EditValue.ToString(),
                     NarrationTextEdit.Text,
                    TaskTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Overtime entry saved successfully");
                this.spSelectAllOverTimeTableAdapter.Fill(this.dsOverTime.spSelectAllOverTime, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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


                CostCenterTextEdit.EditValue = dsOverTime.CostCenter.DataSet.Tables["CostCenter"].Rows[0][0].ToString();
                HoursWorkedTextEdit.Text = "0";
                   WorkDateDateEdit.DateTime = DateTime.Now;
                   PayrollItemTextEdit.Text = "";
                     HourlyRateTextEdit.Text = "0";
                     MultiplierTextEdit.Text = "0";
                     AppliedRateTextEdit.Text = "0";
                      FromDateDateEdit.DateTime = DateTime.Now;
                   ToDateDateEdit.DateTime = DateTime.Now;
                   TotalPayTextEdit.Text = "0";
                CurrencyTextEdit.EditValue = "KES";
                     NarrationTextEdit.Text = "Overtime entry";
                TaskTextEdit.Text = "";
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
                EmpNoTextEdit.Enabled = false;

                CostCenterTextEdit.Enabled = false;
                EmpNameTextEdit.Enabled = false;
                ShiftTypeTextEdit.Enabled = false;
                RateTypeTextEdit.Enabled = false;
                HoursWorkedTextEdit.Enabled = false;
                WorkDateDateEdit.Enabled = false;
                PayrollItemTextEdit.Enabled = false;
                HourlyRateTextEdit.Enabled = false;
                MultiplierTextEdit.Enabled = false;
                AppliedRateTextEdit.Enabled = false;
                FromDateDateEdit.Enabled = false;
                ToDateDateEdit.Enabled = false;
                TotalPayTextEdit.Enabled = false;
                CurrencyTextEdit.Enabled = false;
                NarrationTextEdit.Enabled = false;
                TaskTextEdit.Enabled = false;


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
                EmpNoTextEdit.Enabled = true;

                CostCenterTextEdit.Enabled = true;
                EmpNameTextEdit.Enabled = true;
                ShiftTypeTextEdit.Enabled = true;
                RateTypeTextEdit.Enabled = true;
                HoursWorkedTextEdit.Enabled = true;
                WorkDateDateEdit.Enabled = true;
                PayrollItemTextEdit.Enabled = true;
                HourlyRateTextEdit.Enabled = true;
                MultiplierTextEdit.Enabled = true;
                AppliedRateTextEdit.Enabled = true;
                FromDateDateEdit.Enabled = true;
                ToDateDateEdit.Enabled = true;
                TotalPayTextEdit.Enabled = true;
                CurrencyTextEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
                TaskTextEdit.Enabled = true;
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

                var EmpNo = Convert.ToString(EmpNoTextEdit.EditValue);
                var CostCenter = Convert.ToString(CostCenterTextEdit.EditValue);
                var ShiftType = Convert.ToString(ShiftTypeTextEdit.EditValue);
                var WorkDate = Convert.ToDateTime(WorkDateDateEdit.DateTime);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete OverTime Entry for Employee  " + EmpNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectOverTimeTableAdapter.Delete(EmpNo,AppConstant.CompCode, CostCenter, ShiftType, WorkDate, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllOverTimeTableAdapter.Fill(this.dsOverTime.spSelectAllOverTime, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
                var CostCenter = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CostCenter"));
                var ShiftType = Convert.ToString(this.gridView1.GetFocusedRowCellValue("ShiftType"));
                var WorkDate = Convert.ToDateTime(this.gridView1.GetFocusedRowCellValue("WorkDate"));
                this.spSelectOverTimeTableAdapter.Fill(this.dsOverTime.spSelectOverTime, EmpNo, AppConstant.CompCode, CostCenter, ShiftType, WorkDate, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Over Time", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Over Time", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Over Time", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Over Time", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            catch (Exception )
            {

              //  MessageBox.Show(ex.Message);
            }
        }

        private void EmpNoTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                EmpNameTextEdit.Text = EmpNoTextEdit.Text;
                spGetEmployeeRatesTableAdapter.Fill(dsOverTime.spGetEmployeeRates, EmpNoTextEdit.EditValue.ToString());
                HourlyRateTextEdit.Text= dsOverTime.spGetEmployeeRates.DataSet.Tables["spGetEmployeeRates"].Rows[0]["HourlyRate"].ToString();
            }
            catch (Exception )
            {
                
               // MessageBox.Show(ex.Message);
            }
        }

        private void RateTypeTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetRateTypeTableAdapter.Fill(dsOverTime.spGetRateType, RateTypeTextEdit.EditValue.ToString());
                MultiplierTextEdit.Text = dsOverTime.spGetRateType.DataSet.Tables["spGetRateType"].Rows[0]["RatePerHour"].ToString();
                PayrollItemTextEdit.Text = dsOverTime.spGetRateType.DataSet.Tables["spGetRateType"].Rows[0]["RateName"].ToString();
            }
            catch (Exception)
            {

               
            }
        }

        private void MultiplierTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                AppliedRateTextEdit.Text = Convert.ToString(Convert.ToDecimal(MultiplierTextEdit.Text) * Convert.ToDecimal((HourlyRateTextEdit.Text)));
            }
            catch (Exception )
            {
                
            }
        }

        private void HourlyRateTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                AppliedRateTextEdit.Text = Convert.ToString(Convert.ToDecimal(MultiplierTextEdit.Text) * Convert.ToDecimal((HourlyRateTextEdit.Text)));
            }
            catch (Exception)
            {

            }
        }

        private void HoursWorkedTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                TotalPayTextEdit.Text = Convert.ToString(Convert.ToDecimal(HoursWorkedTextEdit.Text) * Convert.ToDecimal((AppliedRateTextEdit.Text)));
            }
            catch (Exception)
            {

               
            }
        }

        private void AppliedRateTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                TotalPayTextEdit.Text = Convert.ToString(Convert.ToDecimal(HoursWorkedTextEdit.Text) * Convert.ToDecimal((AppliedRateTextEdit.Text)));
            }
            catch (Exception)
            {


            }
        }

        private void CostCenterTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                employeesMasterTableAdapter.Fill(dsOverTime.EmployeesMaster, AppConstant.CompCode, CostCenterTextEdit.EditValue.ToString());
                EmpNoTextEdit.EditValue = dsOverTime.EmployeesMaster.DataSet.Tables["EmployeesMaster"].Rows[0]["EmpNo"].ToString();
            }
            catch (Exception)
            {
                
            }
        }
    }
}