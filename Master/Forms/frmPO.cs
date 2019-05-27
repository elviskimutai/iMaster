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
using Master.ReportLaunchers;

namespace Master.Forms
{
    public partial class frmPO : DevExpress.XtraEditors.XtraForm
    {
        public frmPO()
        {
            InitializeComponent();
          
        }

        private void frmPO_Load(object sender, EventArgs e)
        {
            try
            {
                spSelectAllPurchaseOrderBufferTableAdapter.ClearGrid(AppConstant.UserID);
                this.spSelectAllPurchaseOrderBufferTableAdapter.Fill(this.dsPurchaseOrder.spSelectAllPurchaseOrderBuffer);
                this.purchaseOrderBufferTableAdapter.Fill(this.dsPurchaseOrder.PurchaseOrderBuffer);
                this.spGetItemsTableAdapter.Fill(this.dsPurchaseOrder.spGetItems, AppConstant.CompCode);
                this.spGetSuppliersTableAdapter.Fill(this.dsPurchaseOrder.spGetSuppliers, AppConstant.CompCode);
                glSuppliers.EditValue = this.dsPurchaseOrder.spGetSuppliers.DataSet.Tables["spGetSuppliers"].Rows[0]["Supplier Code"].ToString();
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsPurchaseOrder.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsPurchaseOrder.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                this.spGetWarehousesTableAdapter.Fill(this.dsPurchaseOrder.spGetWarehouses, AppConstant.CompCode);
                glWarehouse.EditValue = dsPurchaseOrder.spGetWarehouses.DataSet.Tables["spGetWarehouses"].Rows[0]["LocationCode"].ToString();
                txtDeliveryPeriod.Text = "7";

            }
            catch (Exception)
            {

                //MessageBox.Show(ex.Message);
            }
        }
        public bool Saverecord()
        {
            try
            {
                for (int i = 0; i < ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    spSelectAllPurchaseOrderBufferTableAdapter.Insert(
                        AppConstant.CompCode,
                        glCostCenter.EditValue.ToString(),
                        glSuppliers.EditValue.ToString(),
                        glWarehouse.EditValue.ToString(),
                        Convert.ToString(gridView1.GetRowCellValue(i, colItemCode)),
                         Convert.ToString(gridView1.GetRowCellValue(i, colItemDescription)),
                        Convert.ToDouble(gridView1.GetRowCellValue(i, colQuantity)),
                         gridView1.GetRowCellValue(i, colUOM).ToString(),
                         gridView1.GetRowCellValue(i, colCurrency).ToString(),
                        Convert.ToDecimal(gridView1.GetRowCellValue(i, colUnitCost)),
                        glQuotation.EditValue.ToString(),
                         Convert.ToDecimal(gridView1.GetRowCellValue(i, colExtendedCost)),
                         Convert.ToDouble(gridView1.GetRowCellValue(i, colTaxRate)),
                        Convert.ToDecimal(gridView1.GetRowCellValue(i, colTaxAmount)),
                          Convert.ToDouble(gridView1.GetRowCellValue(i, colDiscountRate)),
                         Convert.ToDecimal(gridView1.GetRowCellValue(i, colDiscountAmount)),
                         Convert.ToDecimal(gridView1.GetRowCellValue(i, colNetAmount)),
                           Convert.ToDouble(txtDeliveryPeriod.Text),
                           Environment.MachineName,
                         AppConstant.UserID

                        );
                }
                lblNetCost.Text = String.Format("{0:n2}", TotalSales());
                // this.spGetNetAmountPurchaseOrderBufferTableAdapter.Fill(dsPurchaseOrder.spGetNetAmountPurchaseOrderBuffer);
                // lblNetCost.Text = dsPurchaseOrder.spGetNetAmountPurchaseOrderBuffer.DataSet.Tables["spGetNetAmountPurchaseOrderBuffer"].Rows[0][0].ToString();

                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public decimal TotalSales()
        {
            try
            {
                Decimal Total = 0;
                for (int i = 0; i <= ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    Total += Convert.ToDecimal(gridView1.GetRowCellValue(i, colExtendedCost));
                }

                return Total;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
                DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));

                spSelectAllPurchaseOrderBufferTableAdapter.Delete(selRow["CompCode"].ToString(), selRow["CostCenter"].ToString(), selRow["ItemCode"].ToString());
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception)
            {


            }
            finally
            {
                lblNetCost.Text = String.Format("{0:n2}", TotalSales());
                

            }
        }


        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                spSelectAllPurchaseOrderBufferTableAdapter.ClearGrid(AppConstant.UserID);

                lblNetCost.Text = "0";
                this.purchaseOrderBufferTableAdapter.Fill(this.dsPurchaseOrder.PurchaseOrderBuffer);
            }
            catch (Exception)
            {


            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Saverecord();
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to order this items?", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    var orderNo = spSelectAllPurchaseOrderBufferTableAdapter.spSavePurchaseOrders(AppConstant.UserID, AppConstant.CompCode);
                    spSelectAllPurchaseOrderBufferTableAdapter.ClearGrid(AppConstant.UserID);
                    this.purchaseOrderBufferTableAdapter.Fill(this.dsPurchaseOrder.PurchaseOrderBuffer);
                    dsPurchaseOrder.spSelectAllPurchaseOrderBuffer.Clear();
                    lblNetCost.Text = "0";
                    AppConstant.ReportName = orderNo.ToString();
                    glSuppliers_EditValueChanged(sender, e);
                }
            }
           
            finally
            {
                
                frmAutoPOReceipt _frmAutoPOReceipt = new frmAutoPOReceipt();
                _frmAutoPOReceipt.ShowDialog();
            }
        }



        private void repositoryItemButtonEdit1_Click_3(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void glQuotation_EditValueChanged(object sender, EventArgs e)
        {
           
            try
            {
                spSelectQuotationPOTableAdapter.Fill(dsPurchaseOrder.spSelectQuotationPO, glQuotation.EditValue.ToString());
            }
            finally
            {
                lblNetCost.Text = String.Format("{0:n2}", TotalSales());
                
            }
        }

        private void glSuppliers_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetSupplierQuotationsTableAdapter.Fill(dsPurchaseOrder.spGetSupplierQuotations, glSuppliers.EditValue.ToString());
            }
            finally
            {
                dsPurchaseOrder.spSelectQuotationPO.Clear();
                lblNetCost.Text = String.Format("{0:n2}", TotalSales());
            }
        }
    }
}