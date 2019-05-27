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
    public partial class frmPoReprint : DevExpress.XtraEditors.XtraForm
    {
        public frmPoReprint()
        {
            InitializeComponent();
           
        }

        private void frmPoReprint_Load(object sender, EventArgs e)
        {
            try
            {
                spgetPurchaseOrdersReprintTableAdapter.Fill(dsspsrptPurchaseOrder.spgetPurchaseOrdersReprint, AppConstant.CompCode);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void LaunchReport()
        {
            AppConstant.ReportName = "Purchase Order";
            try
            {
                switch (AppConstant.ReportName)
                {

                    case "Purchase Order":
                        this.LaunchPOReport();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        public void LaunchPOReport()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptPurchaseOrder _rptBeneficiaries = new rptPurchaseOrder();
                spsrptPurchaseOrderTableAdapter.Fill(dsspsrptPurchaseOrder.spsrptPurchaseOrder, gridLookUpEdit1.EditValue.ToString(),AppConstant.CompCode);
                _rptBeneficiaries.DataSource = dsspsrptPurchaseOrder.spsrptPurchaseOrder;
                _rptBeneficiaries.DataSourceSchema = dsspsrptPurchaseOrder.spsrptPurchaseOrder.DataSet.GetXmlSchema();
                _rptBeneficiaries.DataMember = "spsrptPurchaseOrder";
                _rptBeneficiaries.CreateDocument();

                this.documentViewer1.DocumentSource = _rptBeneficiaries;
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