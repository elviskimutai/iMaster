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
    public partial class frmInventoryIssues : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Approvers";
        public frmInventoryIssues()
        {
            InitializeComponent();
        }

        private void frmInventoryIssues_Load(object sender, EventArgs e)
        {
            try
            {
              
                // TODO: This line of code loads data into the 'dsInventoryIssuesBuffer.ToatalCost' table. You can move, or remove it, as needed.
                spSelectAllInventoryIssuesBufferTableAdapter.spDeleteAllInventoryIssuesBuffer(AppConstant.UserID);
                // TODO: This line of code loads data into the 'dsInventoryIssuesBuffer.spGetItems' table. You can move, or remove it, as needed.
                this.spGetItemsTableAdapter.Fill(this.dsInventoryIssuesBuffer.spGetItems,AppConstant.CompCode);
                // TODO: This line of code loads data into the 'dsInventoryIssuesBuffer.InventoryIssuesBuffer' table. You can move, or remove it, as needed.
                this.inventoryIssuesBufferTableAdapter.Fill(this.dsInventoryIssuesBuffer.InventoryIssuesBuffer);

                this.spGetWarehousesTableAdapter.Fill(this.dsInventoryIssuesBuffer.spGetWarehouses, AppConstant.CompCode);
                glWarehouse.EditValue = dsInventoryIssuesBuffer.spGetWarehouses.DataSet.Tables["spGetWarehouses"].Rows[0]["LocationCode"].ToString();
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsInventoryIssuesBuffer.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsInventoryIssuesBuffer.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                this.toatalCostTableAdapter.Fill(this.dsInventoryIssuesBuffer.ToatalCost);
                lblTotalCost.Text = dsInventoryIssuesBuffer.ToatalCost.DataSet.Tables["ToatalCost"].Rows[0][0].ToString();
            }
            catch (Exception)
            {
            }
        }

        public void GridLoad()
        {
            try
            {
                this.spGetItemCodesTableAdapter.Fill(this.dsInventoryIssuesBuffer.spGetItemCodes, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCompCode, AppConstant.CompCode);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCostCenter, glCostCenter.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItem, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUOM, dsInventoryIssuesBuffer.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UOM"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQuantity, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUserName, AppConstant.UserID);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colLocation, glWarehouse.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUnitPrice, dsInventoryIssuesBuffer.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UnitPrice"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSerialNo, "0");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colRemarks, "Inventory issues");

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
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    spSelectAllInventoryIssuesBufferTableAdapter.Insert(
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
                this.toatalCostTableAdapter.Fill(dsInventoryIssuesBuffer.ToatalCost);
                lblTotalCost.Text = dsInventoryIssuesBuffer.ToatalCost.DataSet.Tables["ToatalCost"].Rows[0][0].ToString();

                return true;
            }
            catch (Exception)
            {
                return false;

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

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
                DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));

                this.spSelectAllInventoryIssuesBufferTableAdapter.Delete(selRow["Item"].ToString());
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception)
            {
            }
            finally
            {
                gridView1.RefreshData();
                this.toatalCostTableAdapter.Fill(dsInventoryIssuesBuffer.ToatalCost);
                lblTotalCost.Text = dsInventoryIssuesBuffer.ToatalCost.DataSet.Tables["ToatalCost"].Rows[0][0].ToString();
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                spSelectAllInventoryIssuesBufferTableAdapter.spDeleteAllInventoryIssuesBuffer(AppConstant.UserID);

                lblTotalCost.Text = "0";
                this.inventoryIssuesBufferTableAdapter.Fill(this.dsInventoryIssuesBuffer.InventoryIssuesBuffer);

            }
            catch (Exception)
            {

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("You are about to issue this inventory? Click Yes to continue.", "Confirm!", MessageBoxButtons.YesNoCancel,
                       MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    spSelectAllInventoryIssuesBufferTableAdapter.spsaveInventoryIssues(AppConstant.UserID);
                    spSelectAllInventoryIssuesBufferTableAdapter.spDeleteAllInventoryIssuesBuffer(AppConstant.UserID);

                    lblTotalCost.Text = "0";
                    this.inventoryIssuesBufferTableAdapter.Fill(this.dsInventoryIssuesBuffer.InventoryIssuesBuffer);
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
            catch (Exception)
            {

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
        }
    }
}