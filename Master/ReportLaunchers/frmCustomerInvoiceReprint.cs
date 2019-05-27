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
    public partial class frmCustomerInvoiceReprint : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomerInvoiceReprint()
        {
            InitializeComponent();
           
        }
        public void LaunchReport()
        {
            AppConstant.ReportName = "Customer Invoice";
            try
            {
                switch (AppConstant.ReportName)
                {

                    case "Customer Invoice":
                        this.LaunchInvoiceReport();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        public void LaunchInvoiceReport()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptcustomerInvoice _rptcustomerInvoice = new rptcustomerInvoice();
                sprptcustomerInvoiceTableAdapter.Fill(dscustomerInvoice.sprptcustomerInvoice, gridLookUpEdit1.EditValue.ToString(), AppConstant.CompCode);
                _rptcustomerInvoice.DataSource = dscustomerInvoice.sprptcustomerInvoice;
                _rptcustomerInvoice.DataSourceSchema = dscustomerInvoice.sprptcustomerInvoice.DataSet.GetXmlSchema();
                _rptcustomerInvoice.DataMember = "sprptcustomerInvoice";
                _rptcustomerInvoice.CreateDocument();

                this.documentViewer1.DocumentSource = _rptcustomerInvoice;
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

        private void frmCustomerInvoiceReprint_Load(object sender, EventArgs e)
        {
            try
            {
                this.spgetcustomerinvoiceNoTableAdapter.Fill(dscustomerInvoice.spgetcustomerinvoiceNo, AppConstant.CompCode);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}