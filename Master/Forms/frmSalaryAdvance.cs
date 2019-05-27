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
    public partial class frmSalaryAdvance : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Salary Advance";
        public frmSalaryAdvance()
        {
            InitializeComponent();
        }

        private void frmSalaryAdvance_Load(object sender, EventArgs e)
        {
          try
            {
                if (this.ValidateRight("View", AppConstant.UserID))
                {
                 LoadGrid();
                this.approverTableAdapter.Fill(this.dsSalaryAdvance.Approver);
               
                this.costCenterTableAdapter.Fill(this.dsSalaryAdvance.CostCenter, AppConstant.CompCode,AppConstant.UserID);
                    CostCenterTextEdit.EditValue = dsSalaryAdvance.CostCenter.DataSet.Tables["CostCenter"].Rows[0]["cccode"].ToString();
                this.userCodesTableAdapter.Fill(this.dsSalaryAdvance.UserCodes, "Advance Type");
                }
                else
                {
                MessageBox.Show("Privilege Violation.You have insufficient right to View Salary Advance", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

                this.spSelectAllSalaryAdvancesTableAdapter.Fill(this.dsSalaryAdvance.spSelectAllSalaryAdvances, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
                this.spSelectAllSalaryAdvancesTableAdapter.Insert(
                   EmpNoTextEdit.EditValue.ToString(),
                   AppConstant.CompCode,
                   CostCenterTextEdit.EditValue.ToString(),
                   FromDateDateEdit.DateTime,
                   ToDateDateEdit.DateTime,
                   PayDateDateEdit.DateTime,
                   AdvanceTypeTextEdit.EditValue.ToString(),
                   Convert.ToDecimal(AmountTextEdit.Text),
                   ApproverTextEdit.EditValue.ToString(),
                   ApproverNameTextEdit.Text,
                   ApprovalStatusTextEdit.Text,
                   NarrationTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Salary advance saved successfully");
                this.spSelectAllSalaryAdvancesTableAdapter.Fill(this.dsSalaryAdvance.spSelectAllSalaryAdvances, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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

                
                   FromDateDateEdit.DateTime = DateTime.Now;
                ToDateDateEdit.DateTime = DateTime.Now;
                PayDateDateEdit.DateTime = DateTime.Now;
                   AmountTextEdit.Text = "0";
                  // ApproverTextEdit.EditValue = AppConstant.UserID;
                  
                   ApprovalStatusTextEdit.Text = "Approved";
                
                NarrationTextEdit.Text = "Salary Advance";
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
                FromDateDateEdit.Enabled = false;
                ToDateDateEdit.Enabled = false;
                PayDateDateEdit.Enabled = false;
                AdvanceTypeTextEdit.Enabled = false;
                AmountTextEdit.Enabled = false;
                ApproverTextEdit.Enabled = false;
                ApproverNameTextEdit.Enabled = false;
                ApprovalStatusTextEdit.Enabled = false;

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
                EmpNoTextEdit.Enabled = true;
                CostCenterTextEdit.Enabled = true;
                FromDateDateEdit.Enabled = true;
                ToDateDateEdit.Enabled = true;
                PayDateDateEdit.Enabled = true;
                AdvanceTypeTextEdit.Enabled = true;
                AmountTextEdit.Enabled = true;
                ApproverTextEdit.Enabled = true;
                ApproverNameTextEdit.Enabled = true;
                ApprovalStatusTextEdit.Enabled = true;

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

                var EmpNo = Convert.ToString(EmpNoTextEdit.EditValue);
                var PayDate = Convert.ToDateTime(PayDateDateEdit.DateTime);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete salary for Employee  " + EmpNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllSalaryAdvancesTableAdapter.Delete(EmpNo, PayDate, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllSalaryAdvancesTableAdapter.Fill(this.dsSalaryAdvance.spSelectAllSalaryAdvances, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
                var PayDate = Convert.ToDateTime(this.gridView1.GetFocusedRowCellValue("PayDate"));
                this.spSelectSalaryAdvancesTableAdapter.Fill(this.dsSalaryAdvance.spSelectSalaryAdvances, EmpNo, PayDate, AppConstant.UserID, Environment.MachineName);

                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ApproverTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ApproverNameTextEdit.Text = ApproverTextEdit.Text;
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Salary Advance", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Salary Advance", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Salary Advance", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Salary Advance", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void CostCenterTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.employeesMasterTableAdapter.Fill(this.dsSalaryAdvance.EmployeesMaster, AppConstant.CompCode,CostCenterTextEdit.EditValue.ToString());
                EmpNoTextEdit.EditValue = dsSalaryAdvance.EmployeesMaster.DataSet.Tables["EmployeesMaster"].Rows[0]["EmpNo"].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}