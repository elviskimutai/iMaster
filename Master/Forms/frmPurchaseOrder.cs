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
    public partial class frmPurchaseOrder : DevExpress.XtraEditors.XtraForm
    {
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPurchaseOrder.Currencies' table. You can move, or remove it, as needed.
          
            try
            {
                this.currenciesTableAdapter.Fill(this.dsPurchaseOrder.Currencies);
                spSelectAllPurchaseOrderBufferTableAdapter.ClearGrid(AppConstant.UserID);
                this.spSelectAllPurchaseOrderBufferTableAdapter.Fill(this.dsPurchaseOrder.spSelectAllPurchaseOrderBuffer);
                this.purchaseOrderBufferTableAdapter.Fill(this.dsPurchaseOrder.PurchaseOrderBuffer);
              
                this.spGetSuppliersTableAdapter.Fill(this.dsPurchaseOrder.spGetSuppliers, AppConstant.CompCode);
                glSuppliers.EditValue = this.dsPurchaseOrder.spGetSuppliers.DataSet.Tables["spGetSuppliers"].Rows[0]["Supplier Code"].ToString();
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsPurchaseOrder.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsPurchaseOrder.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                this.spGetWarehousesTableAdapter.Fill(this.dsPurchaseOrder.spGetWarehouses, AppConstant.CompCode);
                glWarehouse.EditValue = dsPurchaseOrder.spGetWarehouses.DataSet.Tables["spGetWarehouses"].Rows[0]["LocationCode"].ToString();
                txtDeliveryPeriod.Text = "7";
                this.spGetItemsTableAdapter.Fill(this.dsPurchaseOrder.spGetItems, AppConstant.CompCode);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void GridLoad()
        {
            try
            {
                this.spGetItemCodesTableAdapter.Fill(this.dsPurchaseOrder.spGetItemCodes, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCompCode, AppConstant.CompCode);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCostCenter, glCostCenter.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSupplierCode, glSuppliers.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemCode, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colShipToAddress, glWarehouse.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemDescription, dsPurchaseOrder.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["ItemDescription"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQuantity, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUnitCost, dsPurchaseOrder.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UnitCost"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUOM, dsPurchaseOrder.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UOM"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colExtendedCost, dsPurchaseOrder.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UnitCost"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTaxRate, dsPurchaseOrder.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["VATRate"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTaxAmount, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDiscountRate, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDiscountAmount, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colNetAmount, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDeliveryPeriod, 7);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTerminus, Environment.MachineName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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
                        "0",
                        Convert.ToDouble(gridView1.GetRowCellValue(i, colQuantity)),
                         gridView1.GetRowCellValue(i, colUOM).ToString(),
                         glCurrency.EditValue.ToString(),
                        Convert.ToDecimal(gridView1.GetRowCellValue(i, colUnitCost)),
                        "0",
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

        private void glItemCode_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridView1.AddNewRow();
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemCode, glItemCode.EditValue.ToString());
                GridLoad();
            }
            catch (Exception)
            {
            }
            finally
            {
                gridView1.RefreshData();
                lblNetCost.Text = String.Format("{0:n2}", TotalSales());
            }
        }
        public decimal TotalSales()
        {
            try
            {
                Decimal Total = 0;
                for (int i = 0; i <= ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    Total += Convert.ToDecimal(gridView1.GetRowCellValue(i, colPayableAmount));
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
                //this.spGetNetAmountPurchaseOrderBufferTableAdapter.Fill(dsPurchaseOrder.spGetNetAmountPurchaseOrderBuffer);
                //lblNetCost.Text = dsPurchaseOrder.spGetNetAmountPurchaseOrderBuffer.DataSet.Tables["spGetNetAmountPurchaseOrderBuffer"].Rows[0][0].ToString();

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
                    var orderNo = spSelectAllPurchaseOrderBufferTableAdapter.spSavePurchaseOrders(AppConstant.UserID,AppConstant.CompCode);
                    spSelectAllPurchaseOrderBufferTableAdapter.ClearGrid(AppConstant.UserID);

                    lblNetCost.Text = "0"; //dsInventoryReceipt.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
                    this.purchaseOrderBufferTableAdapter.Fill(this.dsPurchaseOrder.PurchaseOrderBuffer);
                    AppConstant.ReportName = orderNo.ToString();
                       frmAutoPOReceipt _frmAutoPOReceipt = new frmAutoPOReceipt();
                    _frmAutoPOReceipt.ShowDialog();
                }
            }
            catch (Exception)
            {

            }
           
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                lblNetCost.Text = String.Format("{0:n2}", TotalSales());
            }
            catch (Exception)
            {

                
            }
        }
        private void repositoryItemSpinEdit1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lblNetCost.Text = String.Format("{0:n2}", TotalSales());
            }
            catch (Exception)
            {


            }
        }

        private void repositoryItemSpinEdit1_ValueChanged(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                lblNetCost.Text = String.Format("{0:n2}", TotalSales());
            }
            catch (Exception)
            {


            }
        }

        private void gridView1_ColumnUnboundExpressionChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            lblNetCost.Text = String.Format("{0:n2}", TotalSales());
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lblNetCost.Text = String.Format("{0:n2}", TotalSales());
        }

        private void gridView1_FocusedRowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
            lblNetCost.Text = String.Format("{0:n2}", TotalSales());
        }
    }
}