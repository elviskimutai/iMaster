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

namespace Master.ReportLaunchers
{
    public partial class frmPAYELuncher : DevExpress.XtraEditors.XtraForm
    {
        public frmPAYELuncher()
        {
            InitializeComponent();
            //AppConstant.UserID = "steve@live.com";
            //AppConstant.CompCode = "001";
        }

        private void frmPAYELuncher_Load(object sender, EventArgs e)
        {
            try
            {
                this.spGetCompanyCostCentersTableAdapter.Fill(dsPAYELauncher.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsPAYELauncher.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["cccode"].ToString();
                this.spGetPostingPeriodsTableAdapter.Fill(dsPAYELauncher.spGetPostingPeriods, AppConstant.CompCode);
                glPeriod.EditValue = dsPAYELauncher.spGetPostingPeriods.DataSet.Tables["spGetPostingPeriods"].Rows[0]["PeriodID"].ToString();
                this.userCodesTableAdapter.Fill(dsPAYELauncher.UserCodes, "Payment Types");
                glPayType.EditValue = dsPAYELauncher.UserCodes.DataSet.Tables["UserCodes"].Rows[0]["Code"].ToString();
                chkAllCostcenters.Checked = true;
            }
            catch (Exception)
            {

            }
        }
        public void LaunchReport()
        {
             AppConstant.ReportName = "Monthly PAYE";
            try
            {
                switch (AppConstant.ReportName)
                {
                    case "Monthly PAYE":
                        this.LaunchPAYE();
                        break;
                  
                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LaunchReport();
        }

        public void LaunchPAYE()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptPAYEMonthly _rptPAYEMonthly = new rptPAYEMonthly();
                sprptProcessPAYEMonthlyTableAdapter.Fill(dsPAYELauncher.sprptProcessPAYEMonthly, AppConstant.CompCode, glCostCenter.EditValue.ToString(), chkAllCostcenters.Checked, glPayType.EditValue.ToString(), glPeriod.EditValue.ToString(), AppConstant.UserID, Environment.MachineName);
                _rptPAYEMonthly.DataSource = dsPAYELauncher.sprptProcessPAYEMonthly;
                _rptPAYEMonthly.DataSourceSchema = dsPAYELauncher.sprptProcessPAYEMonthly.DataSet.GetXmlSchema();
                _rptPAYEMonthly.DataMember = "sprptNSSFReturns";
                _rptPAYEMonthly.CreateDocument();

                this.documentViewer1.DocumentSource = _rptPAYEMonthly;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }
    }
}