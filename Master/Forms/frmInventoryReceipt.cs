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
using DevExpress.XtraGrid.Columns;
namespace Master.Forms
{
    public partial class frmInventoryReceipt : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Approvers";
        public frmInventoryReceipt()
        {
            InitializeComponent();
        }

        private void frmInventoryReceipt_Load(object sender, EventArgs e)
        {
          
            try
            {
                //AppConstant.CompCode = "001";
                //AppConstant.UserID = "steve@live.com";
                spSelectAllInventoryReceiptBufferTableAdapter.spDelteAllInventoryBuffer(AppConstant.UserID);
                this.inventoryReceiptBufferTableAdapter.Fill(this.dsInventoryReceipt.InventoryReceiptBuffer);
                this.spGetWarehousesTableAdapter.Fill(this.dsInventoryReceipt.spGetWarehouses, AppConstant.CompCode);
                glWarehouse.EditValue = dsInventoryReceipt.spGetWarehouses.DataSet.Tables["spGetWarehouses"].Rows[0]["LocationCode"].ToString();
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsInventoryReceipt.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsInventoryReceipt.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                this.spGetItemsTableAdapter.Fill(this.dsInventoryReceipt.spGetItems,AppConstant.CompCode);
                this.totalCostTableAdapter.Fill(dsInventoryReceipt.TotalCost);
                lblTotalCost.Text = dsInventoryReceipt.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
            }
            catch (Exception)
            {
              //  MessageBox.Show(ex.InnerException.Message);
               
            }
        }
        
        public void GridLoad()
        {
            try
            {
                this.spGetItemCodesTableAdapter.Fill(this.dsInventoryReceipt.spGetItemCodes, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCompCode, AppConstant.CompCode);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCostCenter, glCostCenter.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItem, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUOM, dsInventoryReceipt.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UOM"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQuantity,0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUserName, AppConstant.UserID);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colLocation, glWarehouse.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUnitPrice, dsInventoryReceipt.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UnitPrice"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSerialNo, "0");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colRemarks, "Inventory receipt");
              
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
            try
            {
                int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
                DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));
                
                this.spSelectAllInventoryReceiptBufferTableAdapter.Delete(selRow["Item"].ToString());
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception)
            {
            }
            finally
            {
                lblTotalCost.Text = String.Format("{0:n2}", TotalSales());
            }
        }
        public decimal TotalSales()
        {
            try
            {
                Decimal Total = 0;
                for (int i = 0; i <= ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    Total += Convert.ToDecimal(gridView1.GetRowCellValue(i, ExtPrice));
                }

                return Total;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public bool Saverecord()
        {
            try
            {

                for (int i = 0; i < ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    spSelectAllInventoryReceiptBufferTableAdapter.Insert(
                        gridView1.GetRowCellValue(i, colItem).ToString(),
                         Convert.ToDouble(gridView1.GetRowCellValue(i, colQuantity)),
                         gridView1.GetRowCellValue(i, colUOM).ToString(),
                         Convert.ToDecimal(gridView1.GetRowCellValue(i, colUnitPrice)),
                         gridView1.GetRowCellValue(i, colCompCode).ToString(),
                         gridView1.GetRowCellValue(i, colCostCenter).ToString(),
                         gridView1.GetRowCellValue(i, colLocation).ToString(),
                         gridView1.GetRowCellValue(i, colSerialNo).ToString(),
                         gridView1.GetRowCellValue(i, colRemarks).ToString(),
                         AppConstant.UserID,
                         Environment.MachineName
                        );
                }
                lblTotalCost.Text = String.Format("{0:n2}", TotalSales());

                return true;
            }
            catch (Exception)
            {
                return false;

            }
           
        }

      

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            lblTotalCost.Text = String.Format("{0:n2}", TotalSales());
        }
        
        private void repositoryItemGridLookUpEdit1_Click(object sender, EventArgs e)
        {
          
        }

        private void glItemCode_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridView1.AddNewRow();
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItem, glItemCode.EditValue.ToString());
                GridLoad();


            }
            catch (Exception)
            {
            }
            finally
            {
                gridView1.RefreshData();
                lblTotalCost.Text = String.Format("{0:n2}", TotalSales());
            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridLoad();
           

        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                spSelectAllInventoryReceiptBufferTableAdapter.spDelteAllInventoryBuffer(AppConstant.UserID);
                lblTotalCost.Text = "0";
                this.inventoryReceiptBufferTableAdapter.Fill(this.dsInventoryReceipt.InventoryReceiptBuffer);

            }
            catch (Exception)
            {
                
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
                    if (Saverecord())
                    {
                        spSelectAllInventoryReceiptBufferTableAdapter.spsaveInventoryReceipts(AppConstant.UserID);
                        spSelectAllInventoryReceiptBufferTableAdapter.spDelteAllInventoryBuffer(AppConstant.UserID);
                    }
                   

                    lblTotalCost.Text = "0"; //dsInventoryReceipt.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
                    this.inventoryReceiptBufferTableAdapter.Fill(this.dsInventoryReceipt.InventoryReceiptBuffer);
                
                }
            }
            catch (Exception)
            {

            }
        }

        private void gridView1_ColumnUnboundExpressionChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            lblTotalCost.Text = String.Format("{0:n2}", TotalSales());
        }

        private void repositoryItemSpinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            lblTotalCost.Text = String.Format("{0:n2}", TotalSales());
        }

        private void repositoryItemSpinEdit1_EditValueChanged(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            lblTotalCost.Text = String.Format("{0:n2}", TotalSales());
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lblTotalCost.Text = String.Format("{0:n2}", TotalSales());
        }

        private void gridView1_FocusedRowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
            lblTotalCost.Text = String.Format("{0:n2}", TotalSales());
        }
    }
}