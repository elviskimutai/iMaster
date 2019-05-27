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
    public partial class frmAutoPOReceipt : DevExpress.XtraEditors.XtraForm
    {
        public frmAutoPOReceipt()
        {
            InitializeComponent();
        }

        private void frmAutoPOReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                LaunchPOReport();
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
                rptPurchaseOrder _rptPurchaseOrder = new rptPurchaseOrder();
                spsrptPurchaseOrderTableAdapter.Fill(dsspsrptPurchaseOrder.spsrptPurchaseOrder, AppConstant.ReportName, AppConstant.CompCode);
                _rptPurchaseOrder.DataSource = dsspsrptPurchaseOrder.spsrptPurchaseOrder;
                _rptPurchaseOrder.DataSourceSchema = dsspsrptPurchaseOrder.spsrptPurchaseOrder.DataSet.GetXmlSchema();
                _rptPurchaseOrder.DataMember = "spsrptPurchaseOrder";
                _rptPurchaseOrder.CreateDocument();

                this.documentViewer1.DocumentSource = _rptPurchaseOrder;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }
    }
}