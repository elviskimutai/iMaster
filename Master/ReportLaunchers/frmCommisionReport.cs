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
    public partial class frmCommisionReport : DevExpress.XtraEditors.XtraForm
    {
        public frmCommisionReport()
        {
            InitializeComponent();
            //AppConstant.UserID = "steve@live.com";
            //AppConstant.CompCode = "001";
        }

        private void frmCommisionReport_Load(object sender, EventArgs e)
        {
            this.spGetCompanyCostCentersTableAdapter.Fill(dsCommisionReport.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
            glCostCenter.EditValue = dsCommisionReport.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["cccode"].ToString();
            this.spGetEmployeeCodesTableAdapter.Fill(dsCommisionReport.spGetEmployeeCodes, AppConstant.CompCode);
            glEmployee.EditValue = dsCommisionReport.spGetEmployeeCodes.DataSet.Tables["spGetEmployeeCodes"].Rows[0]["EmpNo"].ToString();
        }

        public void LaunchReport()
        {
            // AppConstant.ReportName = "Leave Applications";
            try
            {
                switch (AppConstant.ReportName)
                {
                    case "Commission Report":
                        this.Launchcommission();
                        break;
                    case "Salary Advance":
                        this.LaunchSalaryAdvance();
                        break;
                    case "DBAs Report":
                        this.LaunchDBAs();
                        break;
                    case "Leave Applications":
                        this.LaunchLeaveApplication();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }
        public void LaunchLeaveApplication()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptLeaveAppication _rptLeaveAppication = new rptLeaveAppication();
                sprptLeaveAppicationsTableAdapter.Fill(dsLeaveApplicationReport.sprptLeaveAppications, AppConstant.CompCode, glCostCenter.EditValue.ToString(), chkAllCostCenters.Checked, glEmployee.EditValue.ToString(), chkAllEmployees.Checked);
                _rptLeaveAppication.DataSource = dsLeaveApplicationReport.sprptLeaveAppications;
                _rptLeaveAppication.DataSourceSchema = dsLeaveApplicationReport.sprptLeaveAppications.DataSet.GetXmlSchema();
                _rptLeaveAppication.DataMember = "sprptLeaveAppications";
                _rptLeaveAppication.CreateDocument();

                this.documentViewer1.DocumentSource = _rptLeaveAppication;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }
        public void LaunchDBAs()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptDBAs _rptDBAs = new rptDBAs();
                sprptDBAsTableAdapter.Fill(dsDBAReport.sprptDBAs, AppConstant.CompCode, glCostCenter.EditValue.ToString(), chkAllCostCenters.Checked, glEmployee.EditValue.ToString(), chkAllEmployees.Checked);
                _rptDBAs.DataSource = dsDBAReport.sprptDBAs;
                _rptDBAs.DataSourceSchema = dsDBAReport.sprptDBAs.DataSet.GetXmlSchema();
                _rptDBAs.DataMember = "sprptDBAs";
                _rptDBAs.CreateDocument();

                this.documentViewer1.DocumentSource = _rptDBAs;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }
        public void LaunchSalaryAdvance()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptSalaryAdvance _rptSalaryAdvance = new rptSalaryAdvance();
                sprptSalaryAdvanceTableAdapter.Fill(dsSalaryAdvanceReport.sprptSalaryAdvance, AppConstant.CompCode, glCostCenter.EditValue.ToString(), chkAllCostCenters.Checked, glEmployee.EditValue.ToString(), chkAllEmployees.Checked);
                _rptSalaryAdvance.DataSource = dsSalaryAdvanceReport.sprptSalaryAdvance;
                _rptSalaryAdvance.DataSourceSchema = dsSalaryAdvanceReport.sprptSalaryAdvance.DataSet.GetXmlSchema();
                _rptSalaryAdvance.DataMember = "sprptSalaryAdvance";
                _rptSalaryAdvance.CreateDocument();

                this.documentViewer1.DocumentSource = _rptSalaryAdvance;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }

        public void Launchcommission()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptCommisionEntry _rptCommisionEntry = new rptCommisionEntry();
                sprptCommissionReportTableAdapter.Fill(dsCommisionReport.sprptCommissionReport, AppConstant.CompCode, glCostCenter.EditValue.ToString(), chkAllCostCenters.Checked, glEmployee.EditValue.ToString(), chkAllEmployees.Checked);
                _rptCommisionEntry.DataSource = dsCommisionReport.sprptCommissionReport;
                _rptCommisionEntry.DataSourceSchema = dsCommisionReport.sprptCommissionReport.DataSet.GetXmlSchema();
                _rptCommisionEntry.DataMember = "sprptGetOvertimeReport";
                _rptCommisionEntry.CreateDocument();

                this.documentViewer1.DocumentSource = _rptCommisionEntry;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LaunchReport();
        }
    }
}