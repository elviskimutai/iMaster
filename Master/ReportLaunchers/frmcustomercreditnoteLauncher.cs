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
    public partial class frmcustomercreditnoteLauncher : DevExpress.XtraEditors.XtraForm
    {
        public frmcustomercreditnoteLauncher()
        {
            InitializeComponent();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptCustomerCreditNote _rptCustomerCreditNote = new rptCustomerCreditNote();
                // sprptCustomerCreditNoteTableAdapter.Fill(dsrptCustomerCreditNote.sprptCustomerCreditNote, "CUSTCR-001-1"gridLookUpEdit1.EditValue.ToString(), AppConstant.CompCode);
                sprptCustomerCreditNoteTableAdapter.Fill(dsrptCustomerCreditNote.sprptCustomerCreditNote, gridLookUpEdit1.EditValue.ToString(), AppConstant.CompCode);
                _rptCustomerCreditNote.DataSource = dsrptCustomerCreditNote.sprptCustomerCreditNote;
                _rptCustomerCreditNote.DataSourceSchema = dsrptCustomerCreditNote.sprptCustomerCreditNote.DataSet.GetXmlSchema();
                _rptCustomerCreditNote.DataMember = "sprptCustomerCreditNote";
                _rptCustomerCreditNote.CreateDocument();

                this.documentViewer1.DocumentSource = _rptCustomerCreditNote;



            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }

        private void frmcustomercreditnoteLauncher_Load(object sender, EventArgs e)
        {
            try
            {
                spGetCustomerCreditNotesTableAdapter.Fill(dsrptCustomerCreditNote.spGetCustomerCreditNotes, AppConstant.CompCode);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}