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
using Master.Class.Report;

namespace Master.ReportLaunchers
{
    public partial class frmPayslip : DevExpress.XtraEditors.XtraForm
    {
        public frmPayslip()
        {
            InitializeComponent();
            //AppConstant.UserID = "steve@live.com";
            //AppConstant.CompCode = "001";
        }

        private void frmPayslip_Load(object sender, EventArgs e)
        {
            try
            {
                this.employeeMasterTableAdapter.Fill(this.dsPayslip.EmployeeMaster,AppConstant.CompCode);

                userCodesTableAdapter.Fill(dsPayslip.UserCodes, "Payment Types");
                glpaytype.EditValue = dsPayslip.UserCodes.DataSet.Tables["UserCodes"].Rows[0][0].ToString();
                this.postingPeriodsTableAdapter.Fill(this.dsPayslip.PostingPeriods, AppConstant.CompCode);
                glPeriod.EditValue = dsPayslip.PostingPeriods.DataSet.Tables["PostingPeriods"].Rows[0]["PeriodID"].ToString();
                glEmployee.EditValue = dsPayslip.EmployeeMaster.DataSet.Tables["EmployeeMaster"].Rows[0]["EmpNo"].ToString();
                chkAllEmployees.Checked = true;
                if (!(AppConstant.Period == null))
                {
                    glPeriod.EditValue = AppConstant.Period;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void LaunchReport1()
        {
            try
            {
                
                rptPayslips _rptPayslips = new rptPayslips();
                sprptEmployeePayslipTableAdapter.ClearBeforeFill = true;
                sprptEmployeePayslipTableAdapter.Fill(dsPayslip.sprptEmployeePayslip,AppConstant.CompCode, glEmployee.EditValue.ToString(),chkAllEmployees.Checked,Convert.ToInt32(glPeriod.EditValue),glpaytype.EditValue.ToString(),  AppConstant.UserID, Environment.MachineName);
                _rptPayslips.DataSource = dsPayslip.sprptEmployeePayslip;
                _rptPayslips.DataSourceSchema = dsPayslip.sprptEmployeePayslip.DataSet.GetXmlSchema();
                _rptPayslips.DataMember = "sprptEmployeePayslip";
                _rptPayslips.CreateDocument();

                this.documentViewer1.DocumentSource = _rptPayslips;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }

        public void LaunchReport()
        {
            try
            {

                rptPslips _rptPayslips = new rptPslips();
                sprptEmployeePayslipTableAdapter.ClearBeforeFill = true;
                sprptEmployeePayslipTableAdapter.Fill(dsPayslip.sprptEmployeePayslip,AppConstant.CompCode, glEmployee.EditValue.ToString(), chkAllEmployees.Checked, Convert.ToInt32(glPeriod.EditValue), glpaytype.EditValue.ToString(), AppConstant.UserID, Environment.MachineName);
                _rptPayslips.DataSource = dsPayslip.sprptEmployeePayslip;
                _rptPayslips.DataSourceSchema = dsPayslip.sprptEmployeePayslip.DataSet.GetXmlSchema();
                _rptPayslips.DataMember = "sprptEmployeePayslip";
                _rptPayslips.CreateDocument();

                this.documentViewer1.DocumentSource = _rptPayslips;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }
        private void lblLaunch_Click(object sender, EventArgs e)
        {
            if (AppConstant.ReportName== "Pay Slips")
            {
                LaunchReport();
            }
            else
            {
                LaunchReport();
            }
           

        }
    }
}