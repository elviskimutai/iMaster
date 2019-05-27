using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master.ReportLaunchers;
using DevExpress.XtraEditors;

namespace Master.Forms
{
    public partial class frmPayrollReview : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Payroll Review";
        public frmPayrollReview()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmPayrollReview_Load(object sender, EventArgs e)
        {
            if (this.ValidateRight("View", AppConstant.UserID))
            {
                try
                {
                    spGetCompanyCostCentersTableAdapter.Fill(dspayrollreview.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                    glCostCenter.EditValue = dspayrollreview.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0][0].ToString();
                    userCodesTableAdapter.Fill(dspayrollreview.UserCodes, "Payment Types");
                    glPaytype.EditValue = dspayrollreview.UserCodes.DataSet.Tables["UserCodes"].Rows[0][0].ToString();
                    postingPeriodsTableAdapter.Fill(dspayrollreview.PostingPeriods, AppConstant.CompCode);
                    chkAllCostCenters.Checked = true;
                }
                catch (Exception)
                {

                   
                }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to View Payroll Review", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void LoadPayroll()
        {
            try
            {
                
                spPostPayrollTableAdapter.Fill(dspayrollreview.spPostPayroll,AppConstant.CompCode,glCostCenter.EditValue.ToString(), chkAllCostCenters.Checked, Convert.ToInt32(glperiod.EditValue), glPaytype.EditValue.ToString(),AppConstant.UserID,Environment.MachineName);
                lblTotalSalary.Text = String.Format("{0:n2}", dspayrollreview.spPostPayroll.DataSet.Tables["spPostPayroll"].Rows[0]["TotalSalary"]) + " /=";
                lblBenefits.Text = String.Format("{0:n2}", dspayrollreview.spPostPayroll.DataSet.Tables["spPostPayroll"].Rows[0]["Benefits"]) + " /=";
                lblDeductions.Text = String.Format("{0:n2}", dspayrollreview.spPostPayroll.DataSet.Tables["spPostPayroll"].Rows[0]["Deductions"]) + " /=";



            }
            catch (Exception)
            {

                lblTotalSalary.Text = "0";
                lblBenefits.Text = "0";
                lblDeductions.Text = "0";
                //MessageBox.Show("Salary for this period has not been submitted for appproval.");
            }
        }

        private void glperiod_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadPayroll();
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
                    if (!(lblTotalSalary.Text=="0"))
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to decline this salary for period " + gridLookUpEdit1View.GetFocusedRowCellDisplayText("PeriodCode"), "Confirm!", MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        spPostPayrollTableAdapter.spDeclinePayroll(AppConstant.CompCode, glCostCenter.EditValue.ToString(), chkAllCostCenters.Checked, Convert.ToInt32(glperiod.EditValue), glPaytype.EditValue.ToString());
                        LoadPayroll();
                        MessageBox.Show("You have reversed the salary for period " + gridLookUpEdit1View.GetFocusedRowCellDisplayText("PeriodCode"));
                    }
                }else
                {
                    MessageBox.Show("There are no records for this period.");
                }
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Payroll Review", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
                    if (!(lblTotalSalary.Text == "0"))
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to post this salary for period "+ gridLookUpEdit1View.GetFocusedRowCellDisplayText("PeriodCode"), "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    spPostPayrollTableAdapter.spApprovePayroll(AppConstant.CompCode, glCostCenter.EditValue.ToString(), chkAllCostCenters.Checked, Convert.ToInt32(glperiod.EditValue), glPaytype.EditValue.ToString());
                    LoadPayroll();
                    AppConstant.Period = glperiod.EditValue.ToString();
                    MessageBox.Show("You have successfully posted the salary for period " + gridLookUpEdit1View.GetFocusedRowCellDisplayText("PeriodCode"));
                }
                }
                else
                {
                    MessageBox.Show("There are no records for this period.");
                }
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Payroll Review", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

            }
        }

      
        private void printPayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayslip _frmPayslip = new frmPayslip();
            _frmPayslip.ShowDialog();
        }
    }
}