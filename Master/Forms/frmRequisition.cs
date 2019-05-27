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
    public partial class frmRequisition : DevExpress.XtraEditors.XtraForm
    {
        public frmRequisition()
        {
            InitializeComponent();
            
        }

        private void frmRequisition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRequisition.spRequisitionBuffer' table. You can move, or remove it, as needed.
          
            try
            {
              
                this.spRequisitionBufferTableAdapter.Fill(this.dsRequisition.spRequisitionBuffer);
                this.spGetItemsTableAdapter.Fill(this.dsRequisition.spGetItems, AppConstant.CompCode);
               // this.spGetSuppliersTableAdapter.Fill(this.dsRequisition.spGetSuppliers, AppConstant.CompCode);
               
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsRequisition.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsRequisition.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                //this.spGetWarehousesTableAdapter.Fill(this.dsRequisition.spGetWarehouses, AppConstant.CompCode);
                //glWarehouse.EditValue = dsRequisition.spGetWarehouses.DataSet.Tables["spGetWarehouses"].Rows[0]["LocationCode"].ToString();
                spgetAllowedDepartmentsTableAdapter.Fill(dsRequisition.spgetAllowedDepartments, AppConstant.UserID);
                //txtDeliveryPeriod.Text = "7";
                glDepartment.EditValue = this.dsRequisition.spgetAllowedDepartments.DataSet.Tables["spgetAllowedDepartments"].Rows[0]["Code"].ToString();

            }
            catch (Exception)
            {

                
            }
        }
        public void GridLoad()
        {
            try
            {
                this.spGetItemCodesTableAdapter.Fill(this.dsRequisition.spGetItemCodes, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCompCode, AppConstant.CompCode);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCostCenter, glCostCenter.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemCode, glItemCode.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colDepartment, glDepartment.EditValue.ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colItemDescription, dsRequisition.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["ItemDescription"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colQuantity, 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUnitCost, dsRequisition.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UnitCost"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCurrency, dsRequisition.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["Currency"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colUOM, dsRequisition.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UOM"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colExtendedCost, dsRequisition.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UnitCost"].ToString());
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colTaxRate, dsRequisition.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["VATRate"].ToString());
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

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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

        private void gridView1_ColumnUnboundExpressionChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            lblNetCost.Text = String.Format("{0:n2}", TotalSales());
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
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
        public bool SaveRequisition()
        {
            try
            {
                string ReqNo = spRequisitionBufferTableAdapter.spGenerateReqNos(AppConstant.CompCode).ToString();

                for (int i = 0; i < ((GridView)gridControl1.MainView).RowCount; i++)
                {
                   
                    string itemCode = gridView1.GetRowCellValue(i, colItemCode).ToString();
                   
                    spRequisitionBufferTableAdapter.spSaveRequisition(ReqNo, AppConstant.CompCode, glCostCenter.EditValue.ToString(), glDepartment.EditValue.ToString(), i+1, itemCode, gridView1.GetRowCellValue(i, colItemDescription).ToString(), Convert.ToDouble(gridView1.GetRowCellValue(i, colQuantity)), gridView1.GetRowCellValue(i, colUOM).ToString(), Convert.ToDecimal(gridView1.GetRowCellValue(i, colUnitCost).ToString()), Convert.ToDecimal(gridView1.GetRowCellValue(i, colExtendedCost).ToString()), Convert.ToDouble(gridView1.GetRowCellValue(i, colTaxRate).ToString()), Convert.ToDecimal(gridView1.GetRowCellValue(i, colTaxAmount).ToString()), Convert.ToDecimal(gridView1.GetRowCellValue(i, colNetAmount)), mmoRemarks.Text, Environment.MachineName, AppConstant.UserID);
                 

                }
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to request this item(s)?", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                   
                    if (SaveRequisition())
                    {
                        dsRequisition.spRequisitionBuffer.Clear();
                        lblNetCost.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}