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
    public partial class frmCustomerBalanceLauncher : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomerBalanceLauncher()
        {
            InitializeComponent();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptCustomerBalance _rptCustomerBalance = new rptCustomerBalance();
                // sprptCustomerCreditNoteTableAdapter.Fill(dsrptCustomerCreditNote.sprptCustomerCreditNote, "CUSTCR-001-1"gridLookUpEdit1.EditValue.ToString(), AppConstant.CompCode);
                sprptCustomerBalanceTableAdapter.Fill(dsrptCustomerBalance.sprptCustomerBalance, gridLookUpEdit1.EditValue.ToString(), checkEdit1.Checked, AppConstant.CompCode);
                _rptCustomerBalance.DataSource = dsrptCustomerBalance.sprptCustomerBalance;
                _rptCustomerBalance.DataSourceSchema = dsrptCustomerBalance.sprptCustomerBalance.DataSet.GetXmlSchema();
                _rptCustomerBalance.DataMember = "sprptCustomerBalance";
                _rptCustomerBalance.CreateDocument();

                this.documentViewer1.DocumentSource = _rptCustomerBalance;



            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }

        private void frmCustomerBalanceLauncher_Load(object sender, EventArgs e)
        {
            try
            {
                spGetCustomersTableAdapter.Fill(dsrptCustomerBalance.spGetCustomers, AppConstant.CompCode);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}