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
    public partial class requisitionslauncher : DevExpress.XtraEditors.XtraForm
    {
        public requisitionslauncher()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptrequisitions _rptrequisitions = new rptrequisitions();
                sprptrequisitionsTableAdapter.Fill(dsrptrequisitions.sprptrequisitions, AppConstant.CompCode, gridLookUpEdit1.EditValue.ToString(), checkEdit1.Checked);
                _rptrequisitions.DataSource = dsrptrequisitions.sprptrequisitions;
                _rptrequisitions.DataSourceSchema = dsrptrequisitions.sprptrequisitions.DataSet.GetXmlSchema();
                _rptrequisitions.DataMember = "sprptrequisitions";
                _rptrequisitions.CreateDocument();

                this.documentViewer1.DocumentSource = _rptrequisitions;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void requisitionslauncher_Load(object sender, EventArgs e)
        {
            try
            {
                getRequsitionNoTableAdapter.Fill(dsrptrequisitions.getRequsitionNo ,AppConstant.CompCode);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}