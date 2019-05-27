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

namespace Master.Forms
{
    public partial class frmrptSupplierBalance : DevExpress.XtraEditors.XtraForm
    {
        public frmrptSupplierBalance()
        {
            InitializeComponent();
           
        }

        private void frmrptSupplierBalance_Load(object sender, EventArgs e)
        {
            try
            {
                this.spGetSuppliersTableAdapter.Fill(dsrptSupplierBalance.spGetSuppliers, AppConstant.CompCode);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptSupplierBalance _rptSupplierBalance = new rptSupplierBalance();
                // sprptCustomerCreditNoteTableAdapter.Fill(dsrptCustomerCreditNote.sprptCustomerCreditNote, "CUSTCR-001-1"gridLookUpEdit1.EditValue.ToString(), AppConstant.CompCode);
                sprptSupplierBalanceTableAdapter.Fill(dsrptSupplierBalance.sprptSupplierBalance, gridLookUpEdit1.EditValue.ToString(),checkEdit1.Checked, AppConstant.CompCode);
                _rptSupplierBalance.DataSource = dsrptSupplierBalance.sprptSupplierBalance;
                _rptSupplierBalance.DataSourceSchema = dsrptSupplierBalance.sprptSupplierBalance.DataSet.GetXmlSchema();
                _rptSupplierBalance.DataMember = "sprptSupplierBalance";
                _rptSupplierBalance.CreateDocument();

                this.documentViewer1.DocumentSource = _rptSupplierBalance;



            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }
    }
}