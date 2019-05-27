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
    public partial class frmReturnOutwards : DevExpress.XtraEditors.XtraForm
    {
        public frmReturnOutwards()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmReturnOutwards_Load(object sender, EventArgs e)
        {
            try
            {
                spGetCompanyCostCentersTableAdapter.Fill(dsReturnOutwards.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsReturnOutwards.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                mmoRemarks.Text = "Returns outward for date " + DateTime.Now;
            }
            catch (Exception)
            {

               
            }
        }

        private void glCostCenter_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetSuppliersWithInvoicesTableAdapter.Fill(dsReturnOutwards.spGetSuppliersWithInvoices, AppConstant.CompCode, glCostCenter.EditValue.ToString());
            }
            catch (Exception)
            {

                
            }
        }

        private void glSupplier_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetSupplierOrdersTableAdapter.Fill(dsReturnOutwards.spGetSupplierOrders, glSupplier.EditValue.ToString(),glCostCenter.EditValue.ToString());
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
                spSelectSupplierOrdersTableAdapter.ClearBeforeFill = true;
                spSelectSupplierOrdersTableAdapter.Fill(dsReturnOutwards.spSelectSupplierOrders, glOrderNo.EditValue.ToString());
                lblOrderTotal.Text = dsReturnOutwards.spSelectSupplierOrders.DataSet.Tables["spSelectSupplierOrders"].Rows[0]["OrderAmount"].ToString();
                lbAmountPaid.Text = dsReturnOutwards.spSelectSupplierOrders.DataSet.Tables["spSelectSupplierOrders"].Rows[0]["AmountPaid"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public bool SaveReturnOutwards()
        {
            try
            {
                string DocNo = spSelectSupplierOrdersTableAdapter.spGenerateROTDocNos(AppConstant.CompCode).ToString();
                for (int i = 0; i < ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    string itemCode = gridView1.GetRowCellValue(i, colItemCode).ToString();
                    Double origQty = Convert.ToDouble(gridView1.GetRowCellValue(i, colQty));
                    Double QtyToReturned = Convert.ToDouble(gridView1.GetRowCellValue(i, colQtyToReturned));
                    string Currency = gridView1.GetRowCellValue(i, colCurrency).ToString();
                    if (QtyToReturned > 0)
                    {
                        spSelectSupplierOrdersTableAdapter.spSaveReturnOutwards(AppConstant.CompCode, glCostCenter.EditValue.ToString(), glSupplier.EditValue.ToString(), glOrderNo.EditValue.ToString(), itemCode, origQty, QtyToReturned, Currency, DocNo, mmoRemarks.Text.Trim(), AppConstant.UserID, Environment.MachineName);
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
                    if ((QtyReturned + QtyToReturned) > OrigQty)
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
                        if (SaveReturnOutwards() == true)
                        {
                            MessageBox.Show("Return outwards made successfully");
                        }
                        else
                        {
                            MessageBox.Show("Return outwards failed.");
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
                dsReturnOutwards.spSelectSupplierOrders.Clear();
                dsReturnOutwards.spGetSupplierOrders.Clear();
                lblOrderTotal.Text = "0.00";
                lbAmountPaid.Text = "0.00";


            }
        }
    }
}