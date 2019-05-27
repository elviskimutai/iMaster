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
    public partial class frmLeaveManagent : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Leave Management";
        public frmLeaveManagent()
        {
            InitializeComponent();
        }

        private void frmLeaveManagent_Load(object sender, EventArgs e)
        {
            try
            {

                
                
                this.costCenterTableAdapter.Fill(dsLeaveManagement.CostCenter, AppConstant.CompCode,AppConstant.UserID);
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

                this.spSelectAllLeaveManagementTableAdapter.Fill(this.dsLeaveManagement.spSelectAllLeaveManagement, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
                if (Convert.ToDouble(LeaveDaysTextEdit.Text) > Convert.ToDouble(labelControl2.Text))
                {
                    MessageBox.Show("Sorry. You cannot assign more than the allowed leave days.");
                    return;
                }
                if ( labelControl2.Text=="0")
                {
                    MessageBox.Show("Sorry. You cannot assign zero leave days.");
                    return;
                }
                this.spSelectAllLeaveManagementTableAdapter.Insert(
                    EmpNoTextEdit.EditValue.ToString(),
                     AppConstant.CompCode,
                    CostCenterTextEdit.EditValue.ToString(),
                    LeaveTypeTextEdit.EditValue.ToString(),
                     Convert.ToString(labelControl2.Text),
                    Convert.ToDouble(labelControl1.Text),
                     Convert.ToDouble(LeaveDaysTextEdit.Text),
                    EffectiveDateEdit.DateTime,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Leave saved successfully");
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
                EmpNoTextEdit.Text = "EMP-001";
                LeaveTypeTextEdit.Text = "";
                LeaveDaysTextEdit.Text = "0";
                labelControl2.Text = "0";
                labelControl1.Text = "0";
                EffectiveDateEdit.DateTime = DateTime.Now;

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
                LeaveTypeTextEdit.Enabled = false;
                LeaveDaysTextEdit.Enabled = false;
                EffectiveDateEdit.Enabled = false;
                labelControl2.Enabled = false;
                labelControl1.Enabled = false;

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
                LeaveTypeTextEdit.Enabled = true;
                LeaveDaysTextEdit.Enabled = true;
                EffectiveDateEdit.Enabled = true;
                labelControl2.Enabled = true;
                labelControl1.Enabled = true;
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
                var LeaveType = Convert.ToString(LeaveTypeTextEdit.EditValue);
                var EffectiveDate = Convert.ToDateTime(EffectiveDateEdit.DateTime);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete leave for Employee  " + EmpNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllLeaveManagementTableAdapter.Delete(EmpNo, LeaveType, EffectiveDate, AppConstant.UserID, Environment.MachineName);
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
                var LeaveType = Convert.ToString(this.gridView1.GetFocusedRowCellValue("LeaveType"));
                var EffectiveDate = Convert.ToDateTime(this.gridView1.GetFocusedRowCellValue("EffectiveDate"));
                this.spSelectLeaveManagementTableAdapter.Fill(this.dsLeaveManagement.spSelectLeaveManagement, EmpNo, LeaveType, EffectiveDate, AppConstant.UserID, Environment.MachineName);

              //  disableFields();
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
               // SelectRecord();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void EmpNoTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.spGetLeaveTypesTableAdapter.Fill(dsLeaveManagement.spGetLeaveTypes, EmpNoTextEdit.EditValue.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void CalculateCarryOver()
        {
            try
            {
                var leaveType = LeaveTypeTextEdit.EditValue.ToString();
                var EmpNo = EmpNoTextEdit.EditValue.ToString();
                if (!((leaveType == null || leaveType == "") && (EmpNo == null || EmpNo == "")))
                {

                    this.spGetCarryOverTableAdapter.Fill(dsLeaveManagement.spGetCarryOver, leaveType, EmpNo);
                    DataSet ds = new DataSet();
                    ds = dsLeaveManagement.spGetCarryOver.DataSet;
                    LeaveDaysTextEdit.Text = ds.Tables["spGetCarryOver"].Rows[0]["LeaveBalance"].ToString();
                   
                    labelControl1.Text = ds.Tables["spGetCarryOver"].Rows[0]["CarryOver"].ToString();
                    labelControl2.Text = ds.Tables["spGetCarryOver"].Rows[0]["LeaveBalance"].ToString();
                }


            }
            catch (Exception )
            {

               // MessageBox.Show(ex.Message);
            }
        }
        private void LeaveTypeTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateCarryOver();
               
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Leave Management", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Leave Management", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Leave Management", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Leave Management", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LeaveDaysTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateCarryOver();
            }
            catch (Exception)
            {


            }
        }

        private void CostCenterTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.employeesMasterTableAdapter.Fill(dsLeaveManagement.EmployeesMaster, AppConstant.CompCode, CostCenterTextEdit.EditValue.ToString());
                EmpNoTextEdit.EditValue = dsLeaveManagement.EmployeesMaster.DataSet.Tables["EmployeesMaster"].Rows[0]["EmpNo"].ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}