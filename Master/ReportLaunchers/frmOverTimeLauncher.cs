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
    public partial class frmOverTimeLauncher : DevExpress.XtraEditors.XtraForm
    {
        public frmOverTimeLauncher()
        {
            InitializeComponent();
            //AppConstant.UserID = "steve@live.com";
            //AppConstant.CompCode = "001";
        }

        public void LaunchReport()
        {
            try
            {
                AppConstant.ReportName = "OverTime";
                switch (AppConstant.ReportName)
                {
                    
                    case "OverTime":
                        this.ProcessOvertime();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }
        public void ProcessOvertime()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptOverTimeReport _rptOverTimeReport = new rptOverTimeReport();
                sprptGetOvertimeReportTableAdapter.Fill(dsOverTimeReport.sprptGetOvertimeReport, AppConstant.CompCode, glEmployee.EditValue.ToString(),chkAllEmployees.Checked,dtpFromdate.DateTime,dtpToDate.DateTime);
                _rptOverTimeReport.DataSource = dsOverTimeReport.sprptGetOvertimeReport;
                _rptOverTimeReport.DataSourceSchema = dsOverTimeReport.sprptGetOvertimeReport.DataSet.GetXmlSchema();
                _rptOverTimeReport.DataMember = "sprptGetOvertimeReport";
                _rptOverTimeReport.CreateDocument();

                this.documentViewer1.DocumentSource = _rptOverTimeReport;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                LaunchReport();
            }
            catch (Exception)
            {
               
            }
        }

        private void frmOverTimeLauncher_Load(object sender, EventArgs e)
        {
            try
            {
                spGetEmployeeCodesTableAdapter.Fill(dsOverTimeReport.spGetEmployeeCodes, AppConstant.CompCode);
                glEmployee.EditValue = dsOverTimeReport.spGetEmployeeCodes.DataSet.Tables["spGetEmployeeCodes"].Rows[0]["EmpNo"].ToString();
                dtpFromdate.DateTime = DateTime.Now.AddMonths(-1);
                dtpToDate.DateTime = DateTime.Now;
            }
            catch (Exception)
            {
;
            }
        }
    }
}