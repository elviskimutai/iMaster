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
    public partial class frmPayrollReverse : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Payroll Reversal";
        public frmPayrollReverse()
        {
            InitializeComponent();
           
        }

        private void frmPayrollReverse_Load(object sender, EventArgs e)
        {
            spGetCompanyCostCentersTableAdapter.Fill(dspayrollreview.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
            glCostcenter.EditValue = dspayrollreview.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0][0].ToString();
            userCodesTableAdapter.Fill(dspayrollreview.UserCodes, "Payment Types");
            glpaytype.EditValue = dspayrollreview.UserCodes.DataSet.Tables["UserCodes"].Rows[0][0].ToString();
            postingPeriodsTableAdapter.Fill(dspayrollreview.PostingPeriods, AppConstant.CompCode);
            glPeriod.EditValue = dspayrollreview.PostingPeriods.DataSet.Tables["PostingPeriods"].Rows[0][0].ToString();
            chkAllCostCenters.Checked = true;
            LoadGrid();
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
                spProcessPayrollReversalTableAdapter.Fill(dspayrollreview.spProcessPayrollReversal, AppConstant.CompCode, glCostcenter.EditValue.ToString(), chkAllCostCenters.Checked, Convert.ToInt32(glPeriod.EditValue), glpaytype.EditValue.ToString());
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
                LoadGrid();
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
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to reverse this salary for period " + glPeriod.EditValue.ToString(), "Confirm!", MessageBoxButtons.YesNoCancel,
                     MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {

                    spProcessPayrollReversalTableAdapter.spReversePayroll(AppConstant.CompCode, glCostcenter.EditValue.ToString(), chkAllCostCenters.Checked, Convert.ToInt32(glPeriod.EditValue), glpaytype.EditValue.ToString());
                    LoadGrid();
                    MessageBox.Show("You have reversed the salary for period " + glPeriod.EditValue.ToString());
                }
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Reverse Payroll", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}