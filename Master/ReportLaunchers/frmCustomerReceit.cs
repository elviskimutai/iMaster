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
    public partial class frmCustomerReceit : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomerReceit()
        {
            InitializeComponent();
            
        }

       public void LunchQoutation()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptQuotation _rptQuotation = new rptQuotation();
                sprptQuotationTableAdapter.Fill(dsrptQuotation.sprptQuotation,AppConstant.Quotation, AppConstant.CompCode);
                _rptQuotation.DataSource = dsrptQuotation.sprptQuotation.DataSet;
                _rptQuotation.DataSourceSchema = dsrptQuotation.sprptQuotation.DataSet.GetXmlSchema();
                _rptQuotation.DataMember = "sprptQuotation";
                _rptQuotation.CreateDocument();

                this.documentViewer1.DocumentSource = _rptQuotation;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }
        public void LunchReceipt()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptCustomerreceit _rptBeneficiaries = new rptCustomerreceit();
                sprptCustomerreceitTableAdapter1.Fill(dssprptCustomerreceit1.sprptCustomerreceit, AppConstant.OrderNo, AppConstant.CompCode);
                _rptBeneficiaries.DataSource = dssprptCustomerreceit1.sprptCustomerreceit;
                _rptBeneficiaries.DataSourceSchema = dssprptCustomerreceit1.sprptCustomerreceit.DataSet.GetXmlSchema();
                _rptBeneficiaries.DataMember = "sprptCustomerreceit";
                _rptBeneficiaries.CreateDocument();

                this.documentViewer1.DocumentSource = _rptBeneficiaries;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }

        private void frmCustomerReceit_Load(object sender, EventArgs e)
        {
            LaunchReport();
        }
        public void LaunchReport()
        {
           
            try
            {
                switch (AppConstant.ReportName)
                {
                    case "Receipt":
                        this.LunchReceipt();
                        break;
                    case "Quotation":
                        this.LunchQoutation();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}