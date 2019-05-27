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
using DevExpress.XtraGrid.Views.Grid;

namespace Master.Forms
{
    public partial class frmReturnInwards : DevExpress.XtraEditors.XtraForm
    {
        public frmReturnInwards()
        {
            InitializeComponent();
            
        }

        private void frmReturnInwards_Load(object sender, EventArgs e)
        {
            try
            {
                spGetCompanyCostCentersTableAdapter.Fill(dsReturnInwards.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsReturnInwards.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                mmoRemarks.Text = "Sales returns for date " + DateTime.Now;
            }
            catch (Exception)
            {

            
            }
        }

        private void glCostCenter_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetCustomersWithInvoicesTableAdapter.Fill(dsReturnInwards.spGetCustomersWithInvoices, AppConstant.CompCode, glCostCenter.EditValue.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void glCustomer_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetCustomerOrderNosTableAdapter.Fill(dsReturnInwards.spGetCustomerOrderNos, glCustomer.EditValue.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void glOrderNo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spSelectCustomerOrderNosTableAdapter.ClearBeforeFill = true;
                spSelectCustomerOrderNosTableAdapter.Fill(dsReturnInwards.spSelectCustomerOrderNos,glOrderNo.EditValue.ToString());
                lblOrderTotal.Text = dsReturnInwards.spSelectCustomerOrderNos.DataSet.Tables["spSelectCustomerOrderNos"].Rows[0]["OrderAmount"].ToString();
                lbAmountPaid.Text = dsReturnInwards.spSelectCustomerOrderNos.DataSet.Tables["spSelectCustomerOrderNos"].Rows[0]["AmountPaid"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        public bool SavReturnInwards()
        {
            try
            {
                string DocNo = spSelectCustomerOrderNosTableAdapter.spGenerateDocNos(AppConstant.CompCode).ToString();
                AppConstant.DocNo = DocNo;
                AppConstant.CustCode = glCustomer.EditValue.ToString();
                for (int i = 0; i < ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    string itemCode = gridView1.GetRowCellValue(i, colItemCode).ToString();
                    Double origQty = Convert.ToDouble(gridView1.GetRowCellValue(i, colQty));
                    Double QtyToReturned = Convert.ToDouble(gridView1.GetRowCellValue(i, colQtyToReturned));
                    string Currency = gridView1.GetRowCellValue(i, colCurrency).ToString();
                    if (QtyToReturned>0)
                    {
                        spSelectCustomerOrderNosTableAdapter.spSaveReturnInwards(AppConstant.CompCode, glCostCenter.EditValue.ToString(), glCustomer.EditValue.ToString(), glOrderNo.EditValue.ToString(), itemCode, origQty, QtyToReturned, Currency, DocNo, mmoRemarks.Text.Trim(), AppConstant.UserID, Environment.MachineName);
                    }
                   
                }
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public string validateForm()
        {
            try
            {
                for (int i = 0; i <= ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    Double OrigQty = Convert.ToDouble(gridView1.GetRowCellValue(i, colQty));
                    Double QtyReturned = Convert.ToDouble(gridView1.GetRowCellValue(i, colQtyReturned));
                    Double QtyToReturned = Convert.ToDouble(gridView1.GetRowCellValue(i, colQtyToReturned));
                    if ((QtyReturned+ QtyToReturned) > OrigQty)
                    {
                        return "Quantity you need to return should not be greater than the Original quantity.";
                    }
                }
                return "Success";
            }
            catch (Exception)
            {

                return "Validation failed. Please try again.";
            }
        }
        private void spSave_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to make this returns?", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    if (this.validateForm() == "Success")
                    {
                        if (SavReturnInwards() == true)
                        {
                            if (chkAllowREfund.Checked == true)
                            {
                                frmCustomerRefund _frmCustomerRefund = new frmCustomerRefund();
                                _frmCustomerRefund.ShowDialog();
                            }
                            MessageBox.Show("Return inwards made successfully");
                        }
                        else
                        {
                            MessageBox.Show("Return inwards failed.");
                        }
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
            finally
            {
                dsReturnInwards.spSelectCustomerOrderNos.Clear();
                lblOrderTotal.Text = "0.00";
                lbAmountPaid.Text = "0.00";

               
            }
        }
    }
}