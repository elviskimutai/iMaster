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
    public partial class frmPayroll : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Payroll Processing";
        public frmPayroll()
        {
            InitializeComponent();
        }

        private void frmPayroll_Load(object sender, EventArgs e)
        {
            try
            {
                glCostCenter.EditValue = "001";
                glPeriod.EditValue = "January";
                glPaymentType.EditValue = "MNS";
               // dtpPayDate.DateTime = DateTime.Now;

                //AppConstant.CompCode = "001";
                //AppConstant.UserID = "steve@live.com";
                postingPeriodsTableAdapter.Fill(dsPayroll.PostingPeriods, AppConstant.CompCode);
                this.payrollSummaryTableAdapter.Fill(this.dsPayroll.PayrollSummary, AppConstant.CompCode);
                costCenterTableAdapter.Fill(dsPayroll.CostCenter, AppConstant.CompCode);
                userCodesTableAdapter.Fill(dsPayroll.UserCodes, "Payment Types");
                chkAllCostCenters.Checked = true;
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
        public void ProcessPayroll()
        {
            try
            {

                this.spProcessPayrollTableAdapter.Insert(
                   AppConstant.CompCode,
                   glCostCenter.EditValue.ToString(),
                   chkAllCostCenters.Checked,
                   Convert.ToInt32(glPeriod.EditValue),
                   dtpPayDate.DateTime,
                   glPaymentType.EditValue.ToString(),
                   mmoNarration.Text,
                    AppConstant.UserID,
                    Environment.MachineName
                    );
                
            
            }
            catch (Exception ex)
            {
                this.payrollSummaryTableAdapter.Fill(this.dsPayroll.PayrollSummary, AppConstant.CompCode);
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    ProcessPayroll();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Process Payroll", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void glPeriod_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                //var Number = (DataRowView)glPeriod.GetSelectedDataRow();
                //var Period = glPeriod.EditValue.ToString();
                //dtpPayDate.DateTime = Convert.ToDateTime(DateTime.Parse("01 " + Period + ", " + dsPayroll.PostingPeriods.DataSet.Tables["PostingPeriods"].Rows[Number]["Year"])).AddMonths(1).AddDays(-1);

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
                if (this.ValidateRight("View", AppConstant.UserID))
                {
                    spCancelPayrollProcessingTableAdapter1.Fill(dsPayroll.spCancelPayrollProcessing,AppConstant.CompCode);
                this.payrollSummaryTableAdapter.Fill(this.dsPayroll.PayrollSummary, AppConstant.CompCode);
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to View payroll Processing", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Delete", AppConstant.UserID))
                {
                    spCancelPayrollProcessingTableAdapter1.spGetSubmitPayrollProcessing(AppConstant.CompCode);
                this.payrollSummaryTableAdapter.Fill(this.dsPayroll.PayrollSummary, AppConstant.CompCode);
                MessageBox.Show("You have successfully submitted  payroll for review");
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete payroll Processing", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Payroll has been submitted successfully.");
            }
        }
    }
}