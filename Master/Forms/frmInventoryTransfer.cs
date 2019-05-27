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
    public partial class frmInventoryTransfer : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Approvers";
        public frmInventoryTransfer()
        {
            InitializeComponent();
        }

        private void frmInventoryTransfer_Load(object sender, EventArgs e)
        {
            try
            {
              
              
                spSelectAllInventoryTransactionsTransferBufferTableAdapter.spDeleteAllInventoryTransfer(AppConstant.UserID);
                // TODO: This line of code loads data into the 'dsInventoryIssuesBuffer.spGetItems' table. You can move, or remove it, as needed.
                this.spGetItemsTableAdapter.Fill(this.dsInventoryIssuesBuffer.spGetItems,AppConstant.CompCode);
                // TODO: This line of code loads data into the 'dsInventoryTranfer.InventoryTransactionsTransferBuffer' table. You can move, or remove it, as needed.
                this.inventoryTransactionsTransferBufferTableAdapter.Fill(this.dsInventoryTranfer.InventoryTransactionsTransferBuffer);
                this.spGetWarehousesTableAdapter.Fill(this.dsInventoryTranfer.spGetWarehouses, AppConstant.CompCode);
                glWarehouse.EditValue = dsInventoryTranfer.spGetWarehouses.DataSet.Tables["spGetWarehouses"].Rows[0]["LocationCode"].ToString();
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsInventoryTranfer.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsInventoryTranfer.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                this.totalCostTableAdapter.Fill(this.dsInventoryTranfer.TotalCost);
                lblTotalCost.Text = dsInventoryTranfer.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();

                glToWarehouse.EditValue = dsInventoryTranfer.spGetWarehouses.DataSet.Tables["spGetWarehouses"].Rows[1]["LocationCode"].ToString();

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
             this.spGetItemCodesTableAdapter.Fill(this.dsInventoryTranfer.spGetItemCodes, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCompCode, AppConstant.CompCode);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCostCenter, glCostCenter.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemCode, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUOM, dsInventoryTranfer.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UOM"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQuantity, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUserName, AppConstant.UserID);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colLocation, glWarehouse.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colToLocation, glToWarehouse.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUnitPrice, dsInventoryTranfer.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UnitPrice"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSerialNo, "0");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colRemarks, "Inventory Transfer");

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

        public bool Saverecord()
        {
            try
            {
                if (glCostCenter.EditValue.ToString().Equals(string.Empty))
                {
                    MessageBox.Show("Enter CostCenter to proceed.");
                    return false;
                }
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    spSelectAllInventoryTransactionsTransferBufferTableAdapter.Insert(
                        gridView1.GetRowCellValue(i, colCompCode).ToString(),
                        glCostCenter.EditValue.ToString(),
                       // gridView1.GetRowCellValue(i, colCostCenter).ToString(),
                         gridView1.GetRowCellValue(i, colItemCode).ToString(),
                          Convert.ToDouble(gridView1.GetRowCellValue(i, colQuantity)),
                          gridView1.GetRowCellValue(i, colUOM).ToString(),
                          Convert.ToDecimal(gridView1.GetRowCellValue(i, colUnitPrice)),
                           glWarehouse.EditValue.ToString(),
                          glToWarehouse.EditValue.ToString(),
                           //gridView1.GetRowCellValue(i, colToLocation).ToString(),
                          gridView1.GetRowCellValue(i, colSerialNo).ToString(),
                          gridView1.GetRowCellValue(i, colRemarks).ToString(),
                          AppConstant.UserID,
                          Environment.MachineName
                         );
                }
                this.totalCostTableAdapter.Fill(dsInventoryTranfer.TotalCost);
                lblTotalCost.Text = dsInventoryTranfer.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
                return true;
            }
            catch (Exception)
            {
                return false;

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

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
                DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));

                spSelectAllInventoryTransactionsTransferBufferTableAdapter.Delete(selRow["ItemCode"].ToString());
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception)
            {
            }
            finally
            {
                gridView1.RefreshData();
                this.totalCostTableAdapter.Fill(dsInventoryTranfer.TotalCost);
                lblTotalCost.Text = dsInventoryTranfer.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                spSelectAllInventoryTransactionsTransferBufferTableAdapter.spDeleteAllInventoryTransfer(AppConstant.UserID);
                lblTotalCost.Text = "0";
                this.inventoryTransactionsTransferBufferTableAdapter.Fill(this.dsInventoryTranfer.InventoryTransactionsTransferBuffer);

            }
            catch (Exception)
            {

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to transfer this inventory?", "Confirm!", MessageBoxButtons.YesNoCancel,
                       MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    spSelectAllInventoryTransactionsTransferBufferTableAdapter.spsaveInventoryTransfer(AppConstant.UserID);
                    spSelectAllInventoryTransactionsTransferBufferTableAdapter.spDeleteAllInventoryTransfer(AppConstant.UserID);

                    lblTotalCost.Text = "0";
                    this.inventoryTransactionsTransferBufferTableAdapter.Fill(this.dsInventoryTranfer.InventoryTransactionsTransferBuffer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_ColumnUnboundExpressionChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            try
            {

                Saverecord();

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
            finally
            {
                gridView1.RefreshData();
            }
        }
    }

}