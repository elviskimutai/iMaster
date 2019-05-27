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
    public partial class frmDistributionOders : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Approvers";
        public frmDistributionOders()
        {
            InitializeComponent();
        }

        private void frmDistributionOders_Load(object sender, EventArgs e)
        {
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";

            try
            {
                this.spSelectAllDistributionOrdersBufferTableAdapter.Fill(this.dsDistributionOrders.spSelectAllDistributionOrdersBuffer);
                this.spGetItemsTableAdapter.Fill(this.dsDistributionOrders.spGetItems,AppConstant.CompCode);
                this.distributionOrdersBufferTableAdapter.Fill(this.dsDistributionOrders.DistributionOrdersBuffer);
                this.spGetWarehousesTableAdapter.Fill(this.dsDistributionOrders.spGetWarehouses, AppConstant.CompCode);
                glWarehouse.EditValue = dsDistributionOrders.spGetWarehouses.DataSet.Tables["spGetWarehouses"].Rows[0]["LocationCode"].ToString();
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsDistributionOrders.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsDistributionOrders.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();

                txtVehicleNo.Text = "KCB";
                txtDirection.Text = "0";
                txtRoute.Text = "0";
                txtSalesPerson.Text = AppConstant.UserID;
                txtDriver.Text = "0";
                this.totalCostTableAdapter.Fill(this.dsDistributionOrders.TotalCost);
                //this.totalCostTableAdapter.Fill(dsDistributionOrders.TotalCost);
                //lblTotalCost.Text = dsDistributionOrders.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
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
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colNarration,"Distribution Orders");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTerminus, Environment.MachineName);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemCode, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQty, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCostCenter ,glCostCenter.EditValue.ToString());
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

        public bool Saverecord()
        {
            try
            {

                for (int i = 0; i < gridView1.DataRowCount; i++)
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
                        glItemCode.EditValue.ToString(),
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
                //this.totalCostTableAdapter.Fill(dsDistributionOrders.TotalCost);
                //lblTotalCost.Text = dsDistributionOrders.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
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

                spSelectAllDistributionOrdersBufferTableAdapter.Delete(selRow["OrderNo"].ToString(), selRow["CompCode"].ToString(), selRow["Costcenter"].ToString(), Convert.ToString(selRow["Route"]), selRow["ItemCode"].ToString());
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception)
            {
                
            }
            finally
            {
                gridView1.RefreshData();
                //this.totalCostTableAdapter.Fill(dsDistributionOrders.TotalCost);
                //lblTotalCost.Text = dsDistributionOrders.TotalCost.DataSet.Tables["TotalCost"].Rows[0][0].ToString();
            }
        }
    }
}