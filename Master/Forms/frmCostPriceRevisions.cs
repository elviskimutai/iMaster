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

namespace Master.Forms
{
    public partial class frmCostPriceRevisions : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Cost Price Revision";
        Security _Security = new Security();
        public frmCostPriceRevisions()
        {
            InitializeComponent();
           
        }

        private void frmCostPriceRevisions_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dsCostPriceRevisions.spSelectAllUOM' table. You can move, or remove it, as needed.
                this.spSelectAllUOMTableAdapter.Fill(this.dsCostPriceRevisions.spSelectAllUOM);
                // TODO: This line of code loads data into the 'dsCostPriceRevisions.spGetItems' table. You can move, or remove it, as needed.
                this.spGetItemsTableAdapter.Fill(this.dsCostPriceRevisions.spGetItems,AppConstant.CompCode);
                this.spGetCompanyCostCentersTableAdapter.Fill(dsCostPriceRevisions.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                this.spGetPriceBandsTableAdapter.Fill(dsCostPriceRevisions.spGetPriceBands, AppConstant.CompCode);
                loadGrid();
                FromDateDateEdit.DateTime = DateTime.Now;
                ToDateDateEdit.DateTime = DateTime.Now.AddMonths(12);
                
                VATRateTextEdit.Text = "16";
                UnitCostTextEdit.Text = "0";
                UnitPriceTextEdit.Text = "0";
                DiscountTextEdit.Text = "0";
                PriceBandGridLookUpEdit.EditValue = dsCostPriceRevisions.spGetPriceBands.DataSet.Tables["spGetPriceBands"].Rows[0]["PriceBand"].ToString();
                CostCenterGridLookUpEdit.EditValue = dsCostPriceRevisions.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                UOMGridLookUpEdit.EditValue = dsCostPriceRevisions.spSelectAllUOM.DataSet.Tables["spSelectAllUOM"].Rows[0]["Uom"].ToString();
                ItemCodeGridLookUpEdit.EditValue = dsCostPriceRevisions.spGetItems.DataSet.Tables["spGetItems"].Rows[0]["ItemCode"].ToString();
            }
            catch (Exception)
            {

                
            }
        }
        public void EnableFields()
        {
            CostCenterGridLookUpEdit.Enabled = true;
             ItemCodeGridLookUpEdit.Enabled = true;
             UOMGridLookUpEdit.Enabled = true;
             FromDateDateEdit.Enabled = true;
            ToDateDateEdit.Enabled = true;
            VATRateTextEdit.Enabled = true; UnitPriceTextEdit.Enabled = true;
           PriceBandGridLookUpEdit.Enabled = true;
           DiscountTextEdit.Enabled = true;
            UnitPriceTextEdit.Enabled = true;
        }
        public void ClearFields()
        {
            FromDateDateEdit.DateTime = DateTime.Now;
            ToDateDateEdit.DateTime = DateTime.Now.AddMonths(12);

            VATRateTextEdit.Text = "16";
            UnitCostTextEdit.Text = "0";
            UnitPriceTextEdit.Text = "0";
            DiscountTextEdit.Text = "0";
            PriceBandGridLookUpEdit.EditValue = dsCostPriceRevisions.spGetPriceBands.DataSet.Tables["spGetPriceBands"].Rows[0]["PriceBand"].ToString();
            CostCenterGridLookUpEdit.EditValue = dsCostPriceRevisions.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
            UOMGridLookUpEdit.EditValue = dsCostPriceRevisions.spSelectAllUOM.DataSet.Tables["spSelectAllUOM"].Rows[0]["Uom"].ToString();
            ItemCodeGridLookUpEdit.EditValue = dsCostPriceRevisions.spGetItems.DataSet.Tables["spGetItems"].Rows[0]["ItemCode"].ToString();

        }
        public void DisableFields()
        {
            CostCenterGridLookUpEdit.Enabled = false;
            ItemCodeGridLookUpEdit.Enabled = false;
            UOMGridLookUpEdit.Enabled = false;
            FromDateDateEdit.Enabled = false;
            ToDateDateEdit.Enabled = false;
            VATRateTextEdit.Enabled = false; UnitPriceTextEdit.Enabled = false;
            PriceBandGridLookUpEdit.Enabled = false;
            DiscountTextEdit.Enabled = false;
            UnitPriceTextEdit.Enabled = false;
        }
        public void SelectRecord()
        {
            try
            {

                // var TableName = Convert.ToString(this.gridView1.GetFocusedRowCellValue("TableName"));
                var ItemCode = Convert.ToString(this.gridView4.GetFocusedRowCellValue("ItemCode"));
                var FromDate = Convert.ToDateTime(this.gridView4.GetFocusedRowCellValue("FromDate"));
                var ToDate = Convert.ToDateTime(this.gridView4.GetFocusedRowCellValue("ToDate"));
                var CostCenter = Convert.ToString(this.gridView4.GetFocusedRowCellValue("CostCenter"));
                spSelectCostPriceRevisionsTableAdapter.Fill(dsCostPriceRevisions.spSelectCostPriceRevisions, AppConstant.CompCode, CostCenter, ItemCode, FromDate, ToDate);

                DisableFields();
                    }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void deleterecord()
        {
            try
            {
                this.spSelectAllCostPriceRevisionsTableAdapter.Delete(AppConstant.CompCode, CostCenterGridLookUpEdit.EditValue.ToString(), ItemCodeGridLookUpEdit.EditValue.ToString(), FromDateDateEdit.DateTime, ToDateDateEdit.DateTime);
                MessageBox.Show("Record Deleted Successfully");
                loadGrid();
                ClearFields();

           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Saverecord()
        {
            try
            {
                this.spSelectAllCostPriceRevisionsTableAdapter.Insert(AppConstant.CompCode, CostCenterGridLookUpEdit.EditValue.ToString(), ItemCodeGridLookUpEdit.EditValue.ToString(),UOMGridLookUpEdit.EditValue.ToString(), FromDateDateEdit.DateTime, ToDateDateEdit.DateTime,Convert.ToDouble(VATRateTextEdit.Text), Convert.ToDecimal(UnitPriceTextEdit.Text),PriceBandGridLookUpEdit.EditValue.ToString(), Convert.ToDouble(DiscountTextEdit.Text), Convert.ToDecimal(UnitCostTextEdit.Text),AppConstant.UserID,Environment.MachineName);
                MessageBox.Show("Record Saved Successfully");
                loadGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadGrid()
        {
            try
            {
                spSelectAllCostPriceRevisionsTableAdapter.Fill(dsCostPriceRevisions.spSelectAllCostPriceRevisions, AppConstant.CompCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            if (this.ValidateRight("Add", AppConstant.UserID))
            {
                Saverecord();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Add Cost Price Revision", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public bool ValidateRight(string Right, string UserGroup)
        {
            try
            {
                _Security.SecurityModule = this.SecurityModule;
                _Security.Right = Right;
                _Security.Usergroup = UserGroup;
                return _Security.ValidatePrivilege();
            }
            catch (Exception)
            {


                return false;
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Delete", AppConstant.UserID))
            {
                try
                {


                    if (gridView4.SelectedRowsCount < 0)
                    {
                        MessageBox.Show("select a record to delete");
                        return;
                    }

                    if (MessageBox.Show("Do you want to delete this record  " , "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {

                    }
                    else
                    {
                        deleterecord();
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to delete Cost Price Revision", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Export", AppConstant.UserID))
            {
                gridView4.ShowPrintPreview();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Export Cost Price Revision", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Edit", AppConstant.UserID))
            {
                EnableFields();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Edit Cost Price Revision", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            SelectRecord();
        }

        private void ItemCodeGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spSelectItemUnitCostTableAdapter.Fill(dsCostPriceRevisions.spSelectItemUnitCost, ItemCodeGridLookUpEdit.EditValue.ToString());
               
                UnitCostTextEdit.Text = dsCostPriceRevisions.spSelectItemUnitCost.DataSet.Tables["spSelectItemUnitCost"].Rows[0]["UnitCost"].ToString();
                UnitPriceTextEdit.Text = dsCostPriceRevisions.spSelectItemUnitCost.DataSet.Tables["spSelectItemUnitCost"].Rows[0]["UnitPrice"].ToString();
                VATRateTextEdit.Text = dsCostPriceRevisions.spSelectItemUnitCost.DataSet.Tables["spSelectItemUnitCost"].Rows[0]["VAT"].ToString();
                UOMGridLookUpEdit.EditValue = dsCostPriceRevisions.spSelectItemUnitCost.DataSet.Tables["spSelectItemUnitCost"].Rows[0]["UOM"].ToString();


            }
            catch (Exception)
            {

                
            }
           
        }
    }
}