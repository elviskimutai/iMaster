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
using  Master.Class.DataSet;
using Master.Class.Report;

namespace Master.ReportLaunchers
{
    public partial class frmNssfreturns : DevExpress.XtraEditors.XtraForm
    {
        public frmNssfreturns()
        {
            InitializeComponent();
        }

        private void frmNssfreturns_Load(object sender, EventArgs e)
        {
            //AppConstant.UserID = "steve@live.com";
            //AppConstant.CompCode = "001";
            postingPeriodsTableAdapter.Fill(dsNSSFReturns.PostingPeriods,AppConstant.CompCode);
            glPeriod.EditValue = dsNSSFReturns.PostingPeriods.DataSet.Tables["PostingPeriods"].Rows[0]["PeriodID"].ToString();
        }
        public void LaunchReport()
        {
           // AppConstant.ReportName = "NHIF Returns";
            try
            {
                switch (AppConstant.ReportName)
                {
                    case "NHIF Returns":
                        this.LaunchNHifReturns();
                        break;
                    case "NSSF Returns":
                        this.LaunchNSSFReturns();
                        break;
                    case "Remitance Report":
                        this.LaunchRemitanceReport();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
               
            }
        }

        public void LaunchNSSFReturns()
        {
            try
            {
                
                documentViewer1.PrintingSystem = null;
                rptNSSFReturns _rptNSSFReturns = new rptNSSFReturns();
                sprptNSSFReturnsTableAdapter.Fill(dsNSSFReturns.sprptNSSFReturns,AppConstant.CompCode,glPeriod.EditValue.ToString(),AppConstant.UserID,Environment.MachineName);
                _rptNSSFReturns.DataSource = dsNSSFReturns.sprptNSSFReturns;
                _rptNSSFReturns.DataSourceSchema = dsNSSFReturns.sprptNSSFReturns.DataSet.GetXmlSchema();
                _rptNSSFReturns.DataMember = "sprptNSSFReturns";
                _rptNSSFReturns.CreateDocument();

                this.documentViewer1.DocumentSource = _rptNSSFReturns;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }
        public void LaunchNHifReturns()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptNHIFReturns _rptNHIFReturns = new rptNHIFReturns();
                sprptNHIFReturnsTableAdapter.Fill(dsNHIFReturns.sprptNHIFReturns, AppConstant.CompCode, glPeriod.EditValue.ToString(), AppConstant.UserID, Environment.MachineName);
           
                _rptNHIFReturns.DataSource = dsNHIFReturns.sprptNHIFReturns;
                _rptNHIFReturns.DataSourceSchema = dsNHIFReturns.sprptNHIFReturns.DataSet.GetXmlSchema();
                _rptNHIFReturns.DataMember = "sprptNHIFReturns";
                _rptNHIFReturns.CreateDocument();

                this.documentViewer1.DocumentSource = _rptNHIFReturns;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }
        public void LaunchRemitanceReport()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptRemitance _rptRemitance = new rptRemitance();
                sprptRemitanceTableAdapter.Fill(dsRemitance.sprptRemitance, AppConstant.CompCode, glPeriod.EditValue.ToString());
                _rptRemitance.DataSource = dsRemitance.sprptRemitance;
                _rptRemitance.DataSourceSchema = dsRemitance.sprptRemitance.DataSet.GetXmlSchema();
                _rptRemitance.DataMember = "sprptRemitance";
                _rptRemitance.CreateDocument();

                this.documentViewer1.DocumentSource = _rptRemitance;
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

        private void glPeriod_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
