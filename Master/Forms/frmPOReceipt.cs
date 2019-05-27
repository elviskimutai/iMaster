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
    public partial class frmPOReceipt : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Approvers";
        public frmPOReceipt()
        {
            InitializeComponent();
            
        }

        private void frmPOReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                this.spGetWarehousesTableAdapter.Fill(this.dsPOReceipt.spGetWarehouses, AppConstant.CompCode);
                glWarehouse.EditValue = dsPOReceipt.spGetWarehouses.DataSet.Tables["spGetWarehouses"].Rows[0]["LocationCode"].ToString();
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsPOReceipt.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsPOReceipt.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                spGetPurchaseOrderTableAdapter.Fill(dsPOReceipt.spGetPurchaseOrder,AppConstant.CompCode,glCostCenter.EditValue.ToString(),glWarehouse.EditValue.ToString());
                txtContainer.Text = "0";
                txtDeliveryNote.Text = "0";
            }
            catch (Exception)
            {

                
            }
        }

        private void glCostCenter_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetPurchaseOrderTableAdapter.Fill(dsPOReceipt.spGetPurchaseOrder, AppConstant.CompCode, glCostCenter.EditValue.ToString(), glWarehouse.EditValue.ToString());
                lblTotalCost.Text = string.Format("{0:n2}", Total());

            }
            catch (Exception)
            {

              
            }
           
        }

      

        private void glWarehouse_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetPurchaseOrderTableAdapter.Fill(dsPOReceipt.spGetPurchaseOrder, AppConstant.CompCode, glCostCenter.EditValue.ToString(), glWarehouse.EditValue.ToString());
                lblTotalCost.Text = string.Format("{0:n2}", Total());

            }
            catch (Exception)
            {

               
            }
           
        }

        private void glIOrderNo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetPurchaseOrderDetailsTableAdapter.Fill(dsPOReceipt.spGetPurchaseOrderDetails, glOrderNo.EditValue.ToString());
                lblTotalCost.Text = string.Format("{0:n2}", Total());

            }
            catch (Exception)
            {


            }
          
        }
        public void SaveRecord()
        {
            try
            {
             

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    spGetPurchaseOrderDetailsTableAdapter.spSavePOReceipt(
                        gridView1.GetRowCellValue(i, colSerialNumber).ToString(),
                        glOrderNo.EditValue.ToString(),
                        AppConstant.CompCode,
                        glCostCenter.EditValue.ToString(),
                         gridView1.GetRowCellValue(i, "ItemCode").ToString(),
                        gridView1.GetRowCellValue(i, colItemDescription).ToString(),

                         Convert.ToDouble(gridView1.GetRowCellValue(i, colQuantity)),
                         Convert.ToDouble(gridView1.GetRowCellValue(i, colQtyToReceive)),
                         Convert.ToString(gridView1.GetRowCellValue(i, colUOM)),
                         Convert.ToDecimal(gridView1.GetRowCellValue(i, colUnitCost)),

                         Convert.ToDecimal(gridView1.GetRowCellValue(i, colExtendedCost)),
                         Convert.ToDouble(gridView1.GetRowCellValue(i, colTaxRate)),
                         Convert.ToDecimal(gridView1.GetRowCellValue(i, colTaxAmount)),
                         Convert.ToDouble(gridView1.GetRowCellValue(i, colDiscountRate)),
                          Convert.ToDecimal(gridView1.GetRowCellValue(i, colDiscountAmount)),
                          Convert.ToDecimal(gridView1.GetRowCellValue(i, colNetAmount)),
                         txtDeliveryNote.Text,
                         txtContainer.Text,
                         gridView1.GetRowCellValue(i, colShipToAddress).ToString(),
                         Convert.ToDateTime(gridView1.GetRowCellValue(i, colOrderDate)),
                         gridView1.GetRowCellValue(i, colCurrency).ToString(),
                         Convert.ToDouble(gridView1.GetRowCellValue(i, colDeliveryPeriod)),
                         gridView1.GetRowCellValue(i, colSupplierCode).ToString(),
                         AppConstant.UserID,
                         Environment.MachineName
                        );
                }
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
                DialogResult dr = MessageBox.Show("Are you sure you want to receive this inventory?", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {

                    SaveRecord();
                    spGetPurchaseOrderDetailsTableAdapter.Fill(dsPOReceipt.spGetPurchaseOrderDetails, glOrderNo.EditValue.ToString());
                }
            }
            catch (Exception)
            {
               
            }
            finally
            {
                lblTotalCost.Text = "0.00";
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to cancel this order?", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        spGetPurchaseOrderDetailsTableAdapter.spDeclineInventory(
                           AppConstant.CompCode,
                           glCostCenter.EditValue.ToString(),
                           gridView1.GetRowCellValue(i, colShipToAddress).ToString(),
                            glOrderNo.EditValue.ToString(),
                            gridView1.GetRowCellValue(i, colItemCode).ToString(),
                             gridView1.GetRowCellValue(i, colCurrency).ToString()
                            );
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                lblTotalCost.Text = "0.00";
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
                DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));
                spGetPurchaseOrderDetailsTableAdapter.spDeclineInventory(
                          AppConstant.CompCode,
                          glCostCenter.EditValue.ToString(),
                          selRow["ShipToAddress"].ToString(),
                           glOrderNo.EditValue.ToString(),
                           selRow["ItemCode"].ToString(),
                           selRow["Currency"].ToString()
                           );
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                lblTotalCost.Text = string.Format("{0:n2}", Total());
            }
            catch (Exception)
            {
            }
            
        }
        public decimal Total()
        {
            try
            {
                Decimal Total = 0;
                for (int i = 0; i <= ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    Total += (Convert.ToDecimal(gridView1.GetRowCellValue(i, colExtendedCost))- Convert.ToDecimal(gridView1.GetRowCellValue(i, colDiscountAmount)));
                }

                return Total;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        private void repositoryItemSpinEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                lblTotalCost.Text = string.Format("{0:n2}", Total());
            }
            catch (Exception)
            {

               
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                lblTotalCost.Text = string.Format("{0:n2}", Total());
            }
            catch (Exception)
            {


            }
        }

        private void gridView1_ColumnUnboundExpressionChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            try
            {
                lblTotalCost.Text = string.Format("{0:n2}", Total());
            }
            catch (Exception)
            {


            }
        }
    }
}