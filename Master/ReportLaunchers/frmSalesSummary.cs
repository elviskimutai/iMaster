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
    public partial class frmSalesSummary : DevExpress.XtraEditors.XtraForm
    {
        public frmSalesSummary()
        {
            InitializeComponent();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptSalesSummaryReportcs _rptSalesSummaryReportcs = new rptSalesSummaryReportcs();
                sprptSalesSummaryReportTableAdapter.Fill(dssprptSalesSummaryReport.sprptSalesSummaryReport,AppConstant.CompCode, dateEdit1.DateTime, dateEdit2.DateTime);
                _rptSalesSummaryReportcs.DataSource = dssprptSalesSummaryReport.sprptSalesSummaryReport;
                _rptSalesSummaryReportcs.DataSourceSchema = dssprptSalesSummaryReport.sprptSalesSummaryReport.DataSet.GetXmlSchema();
                _rptSalesSummaryReportcs.DataMember = "sprptSalesSummaryReport";
                _rptSalesSummaryReportcs.CreateDocument();

                this.documentViewer1.DocumentSource = _rptSalesSummaryReportcs;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }

        private void frmSalesSummary_Load(object sender, EventArgs e)
        {
            try
            {
                dateEdit1.DateTime = DateTime.Now;
                dateEdit2.DateTime = DateTime.Now;
            }
            catch (Exception)
            {

               
            }
        }
    }
}