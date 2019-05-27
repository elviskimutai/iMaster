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
    public partial class frmInvoiceMatching : DevExpress.XtraEditors.XtraForm
    {
        public frmInvoiceMatching()
        {
            InitializeComponent();
          
        }

        private void frmInvoiceMatching_Load(object sender, EventArgs e)
        {
            try
            {
                currenciesTableAdapter.Fill(dsInvoiceMatching.Currencies);
                spGetSuppliersTableAdapter.Fill(dsInvoiceMatching.spGetSuppliers, AppConstant.CompCode);

                glCurrency.EditValue = currenciesTableAdapter.spGetDefaultCurrency(AppConstant.CompCode);
                dtDueDate.DateTime = DateTime.Now;
            }
            finally
            {
                glCurrency.Enabled = false;
            }
        }

        private void txtInvoice_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void glSupplier_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spSelectPOReceiptsTableAdapter.Fill(dsInvoiceMatching.spSelectPOReceipts, AppConstant.CompCode, glSupplier.EditValue.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void glOrderNo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetPurchaseOrderReceiptsTableAdapter.Fill(dsInvoiceMatching.spGetPurchaseOrderReceipts, glOrderNo.EditValue.ToString());
                lblTotalCost.Text = string.Format("{0:n2}", dsInvoiceMatching.spGetPurchaseOrderReceipts.DataSet.Tables["spGetPurchaseOrderReceipts"].Rows[0]["GrossAmount"].ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public string validateForm()
        {
            try
            {
                string Invoice = txtInvoice.Text;
                if (Invoice == null || Invoice == "")
                {
                    return "Enter Invoice No to proceed";
                }
                DateTime DueDate = dtDueDate.DateTime;
                if (DueDate == null)
                {
                    return "Enter DueDate to proceed";
                }
                string Currency = glCurrency.EditValue.ToString();
                if (Currency == null || Currency == "")
                {
                    return "Enter Currency to proceed";
                }
                return "Success";
            }
            catch (Exception)
            {

                return "Validation failed. Confirm figures and try again.";
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to invoice this PO?", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    if (this.validateForm() == "Success")
                    {
                        SaveSupplierInvoices();
                        dsInvoiceMatching.spGetPurchaseOrderReceipts.Clear();
                        lblTotalCost.Text = "0.00";
                    }
                    else
                    {

                        MessageBox.Show(this.validateForm(), "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    public void SaveSupplierInvoices()
        {
            try
            {
                spGetPurchaseOrderReceiptsTableAdapter.spSaveVouchers(AppConstant.CompCode, txtInvoice.Text, glOrderNo.EditValue.ToString(), dtDueDate.DateTime, glCurrency.EditValue.ToString(), Convert.ToDecimal(lblTotalCost.Text), AppConstant.UserID, Environment.MachineName);
                
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
               
            }
        }
    }
}