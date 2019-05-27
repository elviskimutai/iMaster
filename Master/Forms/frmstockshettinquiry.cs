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

namespace Master.Forms
{
    public partial class frmstockshettinquiry : DevExpress.XtraEditors.XtraForm
    {
        public frmstockshettinquiry()
        {
            InitializeComponent();
        }

        private void frmstockshettinquiry_Load(object sender, EventArgs e)
        {
            try
            {
                spGetItemsTableAdapter.Fill(dsstockshettinquiry.spGetItems, AppConstant.CompCode);
                spGetCompanyCostCentersTableAdapter.Fill(dsstockshettinquiry.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                spstocksheetinquiryTableAdapter.Fill(dsstockshettinquiry.spstocksheetinquiry, AppConstant.CompCode, gridLookUpEdit1.EditValue.ToString(), checkEdit1.Checked,glCostcenter.EditValue.ToString(),chkAllCostCenters.Checked);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                gridView1.ShowPrintPreview();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}