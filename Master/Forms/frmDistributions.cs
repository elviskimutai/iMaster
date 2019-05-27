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
    public partial class frmDistributions : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Approvers";
        public frmDistributions()
        {
            InitializeComponent();
            AppConstant.CompCode = "001";
            AppConstant.UserID = "steve@live.com";
        }

        private void frmDistributions_Load(object sender, EventArgs e)
        {
          
            try
            {
                spSelectAllDistributionOrdersBufferTableAdapter.spDeleteAllDistributionBuffer(AppConstant.UserID);
                // TODO: This line of code loads data into the 'dsDistributionOrders.spSelectAllDistributionOrdersBuffer' table. You can move, or remove it, as needed.
                this.spSelectAllDistributionOrdersBufferTableAdapter.Fill(this.dsDistributionOrders.spSelectAllDistributionOrdersBuffer);
                // TODO: This line of code loads data into the 'dsDistributionOrders.DistributionOrdersBuffer' table. You can move, or remove it, as needed.
                this.distributionOrdersBufferTableAdapter.Fill(this.dsDistributionOrders.DistributionOrdersBuffer);
                // TODO: This line of code loads data into the 'dsDistributionOrders.spGetItems' table. You can move, or remove it, as needed.
                this.spGetItemsTableAdapter.Fill(this.dsDistributionOrders.spGetItems,AppConstant.CompCode);
                this.spGetWarehousesTableAdapter.Fill(this.dsDistributionOrders.spGetWarehouses, AppConstant.CompCode);
                glWarehouse.EditValue = dsDistributionOrders.spGetWarehouses.DataSet.Tables["spGetWarehouses"].Rows[0]["LocationCode"].ToString();
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsDistributionOrders.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsDistributionOrders.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
         
                this.totalCostTableAdapter.Fill(this.dsDistributionOrders.TotalCost);
                lblTotalCost.Text = dsDistributionOrders.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
                txtVehicleNo.Text = "KCB";
                txtDirection.Text = "0";
                txtRoute.Text = "0";
                txtSalesPerson.Text = AppConstant.UserID;
                txtDriver.Text = "0";
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
                this.spGetItemCodesTableAdapter.Fill(this.dsDistributionOrders.spGetItemCodes, glItemCode.EditValue.ToString());

                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colOrderNo, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDirection, txtDirection.Text);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCompCode, AppConstant.CompCode);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colVehicleNo, txtVehicleNo.Text);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colRoute, txtRoute.Text);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colSalesPerson, txtSalesPerson.Text);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDriverDetails, txtDriver.Text);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colOrderStatus, "Active");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUserName, AppConstant.UserID);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colNarration, "Distribution Orders");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTerminus, Environment.MachineName);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemCode, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQty, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCostCenter, glCostCenter.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colWareHouse, glWarehouse.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUOM, dsDistributionOrders.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UOM"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDamages, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUnitCost, dsDistributionOrders.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UnitCost"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemDescription, dsDistributionOrders.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["ItemDescription"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colExtendedCost, 0);

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

        private void glItemCode_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridView1.AddNewRow();
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemCode, glItemCode.EditValue.ToString());
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

        public bool Saverecord()
        {
            try
            {

                for (int i = 0; i < gridView1.DataRowCount+1; i++)
                {
                    spSelectAllDistributionOrdersBufferTableAdapter.Insert(
                        "0",
                        txtDirection.Text,
                        AppConstant.CompCode,
                        glCostCenter.EditValue.ToString(),
                        txtVehicleNo.Text,
                        txtRoute.Text,
                        txtSalesPerson.Text,
                        txtDriver.Text,
                        Convert.ToString(gridView1.GetRowCellValue(i, colItemCode)),
                       Convert.ToDouble(gridView1.GetRowCellValue(i, colQty)),
                       Convert.ToDouble(gridView1.GetRowCellValue(i, colDamages)),
                         gridView1.GetRowCellValue(i, colUOM).ToString(),
                          Convert.ToDecimal(gridView1.GetRowCellValue(i, colUnitCost)),
                          Convert.ToDecimal(gridView1.GetRowCellValue(i, "Cost")),
                          glWarehouse.EditValue.ToString(),
                          "Active",
                          AppConstant.UserID,
                          "Distribution orders buffer",

                          Environment.MachineName

                         );
                }
              
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
            finally
            {
                this.totalCostTableAdapter.Fill(this.dsDistributionOrders.TotalCost);
                lblTotalCost.Text = dsDistributionOrders.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
                DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));

                spSelectAllDistributionOrdersBufferTableAdapter.Delete(selRow["OrderNo"].ToString(), selRow["CompCode"].ToString(), selRow["Costcenter"].ToString(), Convert.ToString(selRow["Route"]), selRow["ItemCode"].ToString());
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception)
            {

            }
            finally
            {
                gridView1.RefreshData();
                this.totalCostTableAdapter.Fill(this.dsDistributionOrders.TotalCost);
                lblTotalCost.Text = dsDistributionOrders.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to distribute this inventory?", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    spSelectAllDistributionOrdersBufferTableAdapter.spSaveDistributionOrders(AppConstant.UserID,AppConstant.CompCode);
                    spSelectAllDistributionOrdersBufferTableAdapter.spDeleteAllDistributionBuffer(AppConstant.UserID);

                    lblTotalCost.Text = "0"; //dsInventoryReceipt.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
                    this.distributionOrdersBufferTableAdapter.Fill(this.dsDistributionOrders.DistributionOrdersBuffer);

                }
            }
            catch (Exception)
            {

            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                spSelectAllDistributionOrdersBufferTableAdapter.spDeleteAllDistributionBuffer(AppConstant.UserID);
                lblTotalCost.Text = "0";
                this.distributionOrdersBufferTableAdapter.Fill(this.dsDistributionOrders.DistributionOrdersBuffer);

            }
            catch (Exception)
            {

            }
        }
    }
}