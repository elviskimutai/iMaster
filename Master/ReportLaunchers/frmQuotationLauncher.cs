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
    public partial class frmQuotationLauncher : DevExpress.XtraEditors.XtraForm
    {
        public frmQuotationLauncher()
        {
            InitializeComponent();
           // AppConstant.CompCode = "001";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
             try
            {

                documentViewer1.PrintingSystem = null;
                rptQuotation _rptQuotation = new rptQuotation();
                sprptQuotationTableAdapter.Fill(dsrptQuotation.sprptQuotation, gridLookUpEdit1.EditValue.ToString(),AppConstant.CompCode);
                _rptQuotation.DataSource = dsrptQuotation.sprptQuotation;
                _rptQuotation.DataSourceSchema = dsrptQuotation.sprptQuotation.DataSet.GetXmlSchema();
                _rptQuotation.DataMember = "sprptQuotation";
                _rptQuotation.CreateDocument();

                this.documentViewer1.DocumentSource = _rptQuotation;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }

        private void frmQuotationLauncher_Load(object sender, EventArgs e)
        {
            try
            {
                spgetQuotationsTableAdapter.Fill(dsrptQuotation.spgetQuotations, AppConstant.CompCode);
            }
            catch (Exception)
            {

                
            }
        }
    }
}