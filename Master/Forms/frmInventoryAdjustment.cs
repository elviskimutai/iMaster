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
    public partial class frmInventoryAdjustment : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Approvers";
        public frmInventoryAdjustment()
        {
            InitializeComponent();
            
        }

        private void frmInventoryAdjustment_Load(object sender, EventArgs e)
        {
            inventoryAdjustmentBufferTableAdapter.spDeleteAllInventoryAdjustmentBuffer(AppConstant.UserID);
            // TODO: This line of code loads data into the 'dsInventoryAdjustment.spGetItems' table. You can move, or remove it, as needed.
            this.spGetItemsTableAdapter.Fill(this.dsInventoryAdjustment.spGetItems,AppConstant.CompCode);
            // TODO: This line of code loads data into the 'dsInventoryAdjustment.InventoryAdjustmentBuffer' table. You can move, or remove it, as needed.
            this.inventoryAdjustmentBufferTableAdapter.Fill(this.dsInventoryAdjustment.InventoryAdjustmentBuffer);
            this.spGetWarehousesTableAdapter.Fill(this.dsInventoryAdjustment.spGetWarehouses, AppConstant.CompCode);
            glWarehouse.EditValue = dsInventoryAdjustment.spGetWarehouses.DataSet.Tables["spGetWarehouses"].Rows[0]["LocationCode"].ToString();
            this.spGetCompanyCostCentersTableAdapter.Fill(this.dsInventoryAdjustment.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
            glCostCenter.EditValue = dsInventoryAdjustment.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
            mmoNarration.Text = "Inventory adjustments at date " + DateTime.Now; ;
        }

        private void glItemCode_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                gridView1.AddNewRow();

            }
            catch (Exception)
            {
            }
            finally
            {
                gridView1.RefreshData();
                Saverecord();



            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridLoad();
            }
            catch (Exception)
            {
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                Saverecord();

            }
            catch (Exception)
            {

            }
        }

        public bool Saverecord()
        {
            try
            {
                
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    spSelectAllInventoryAdjustmentBufferTableAdapter.Insert(
                       AppConstant.CompCode,
                        glCostCenter.EditValue.ToString(),
                        glWarehouse.EditValue.ToString(),
                         DateTime.Now,
                          gridView1.GetRowCellValue(i, colItemNo).ToString(),
                          Convert.ToDouble(gridView1.GetRowCellValue(i, colAverageCost)),
                         Convert.ToDouble(gridView1.GetRowCellValue(i, colCurrentQuantity)),
                           Convert.ToDouble(gridView1.GetRowCellValue(i, NewQty)),
                            Convert.ToDouble(gridView1.GetRowCellValue(i, colAdjustmentQuantity)),
                          //Convert.ToDecimal(gridView1.GetRowCellValue(i, colCurrentValue)),
                          // Convert.ToDecimal(gridView1.GetRowCellValue(i, colNewValue)),
                          //Convert.ToDecimal(gridView1.GetRowCellValue(i, colAdjustmentValue)),
                          mmoNarration.Text,
                          Environment.MachineName,
                          AppConstant.UserID
                         );
                }
                //this.totalCostTableAdapter.Fill(dsInventoryTranfer.TotalCost);
                //lblTotalCost.Text = dsInventoryTranfer.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }

        public void GridLoad()
        {
            try
            {
                this.spGetItemQtyTableAdapter.Fill(this.dsInventoryAdjustment.spGetItemQty, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCompCode, AppConstant.CompCode);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCostCenter, glCostCenter.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colWarehouse, glWarehouse.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colAdjustmentDate, DateTime.Now);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colReferenceNo, DateTime.Now);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemNo, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colAverageCost, dsInventoryAdjustment.spGetItemQty.DataSet.Tables["spGetItemQty"].Rows[0]["UnitCost"].ToString());
               // gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCurrentValue, dsInventoryAdjustment.spGetItemQty.DataSet.Tables["spGetItemQty"].Rows[0]["ExtendedCost"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCurrentQuantity, dsInventoryAdjustment.spGetItemQty.DataSet.Tables["spGetItemQty"].Rows[0]["Quantity"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colNewQuantity, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colAdjustmentQuantity, 0);
               // gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colNewValue, 0);
              gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTerminus, Environment.MachineName);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colNarration, mmoNarration.Text);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
             Saverecord();
            }

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));

            spSelectAllInventoryAdjustmentBufferTableAdapter.Delete(selRow["CompCode"].ToString(),selRow["CostCenter"].ToString(), selRow["Warehouse"].ToString(), Convert.ToDateTime(selRow["AdjustmentDate"]), selRow["ItemNo"].ToString(),AppConstant.UserID,Environment.MachineName);
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void repositoryItemTextEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridView1.RefreshData();
            }
            catch (Exception)
            {
                
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventoryAdjustmentBufferTableAdapter.spDeleteAllInventoryAdjustmentBuffer(AppConstant.UserID);
                this.inventoryAdjustmentBufferTableAdapter.Fill(this.dsInventoryAdjustment.InventoryAdjustmentBuffer);
            }
            catch (Exception)
            {

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to adjust this item(s)?", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    inventoryAdjustmentBufferTableAdapter.spSaveInventoryAdjustment(AppConstant.UserID,AppConstant.CompCode);
                    inventoryAdjustmentBufferTableAdapter.spDeleteAllInventoryAdjustmentBuffer(AppConstant.UserID); ;
                    this.inventoryAdjustmentBufferTableAdapter.Fill(this.dsInventoryAdjustment.InventoryAdjustmentBuffer);
                }
            }
            catch (Exception)
            {

            }
        }

        private void gridView1_ColumnUnboundExpressionChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            try
            {

                Saverecord();
              
            }
            catch (Exception)
            {

            }
            finally
            {
                gridView1.RefreshData();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {

                Saverecord();

            }
            catch (Exception)
            {

            }
            finally
            {
                gridView1.RefreshData();
            }
        }

        private void gridView1_FocusedRowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
            try
            {

                Saverecord();

            }
            catch (Exception)
            {

            }
            finally
            {
                gridView1.RefreshData();
            }
        }
    }
}