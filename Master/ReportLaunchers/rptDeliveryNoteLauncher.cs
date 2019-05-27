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
    public partial class rptDeliveryNoteLauncher : DevExpress.XtraEditors.XtraForm
    {
        public rptDeliveryNoteLauncher()
        {
            InitializeComponent();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptDeliveryNote _rptDeliveryNote = new rptDeliveryNote();
                sprptDeliveryNoteTableAdapter.Fill(dsDeliveryNote.sprptDeliveryNote, gridLookUpEdit1.EditValue.ToString(), AppConstant.CompCode);
                _rptDeliveryNote.DataSource = dsDeliveryNote.sprptDeliveryNote;
                _rptDeliveryNote.DataSourceSchema = dsDeliveryNote.sprptDeliveryNote.DataSet.GetXmlSchema();
                _rptDeliveryNote.DataMember = "sprptDeliveryNote";
                _rptDeliveryNote.CreateDocument();

                this.documentViewer1.DocumentSource = _rptDeliveryNote;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }

        private void rptDeliveryNoteLauncher_Load(object sender, EventArgs e)
        {
            try
            {
                spgetDeliverNotesTableAdapter.Fill(dsDeliveryNote.spgetDeliverNotes, AppConstant.CompCode);
            }
            catch (Exception)
            {

                
            }
        }
    }
}