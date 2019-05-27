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
    public partial class frmOpeningStock : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Approvers";
        public frmOpeningStock()
        {
            InitializeComponent();
        }

        private void frmOpeningStock_Load(object sender, EventArgs e)
        {
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
            try
            {
                UOMTextEdit.ReadOnly = true;
                LoadGrid();
                this.spGetWarehousesTableAdapter.Fill(this.dsOpeningStock.spGetWarehouses, AppConstant.CompCode);
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsOpeningStock.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                this.itemMasterTableAdapter.Fill(this.dsOpeningStock.ItemMaster, AppConstant.CompCode);
                this.spGetItemCodesTableAdapter.Fill(this.dsOpeningStock.spGetItemCodes, ItemCodeTextEdit.EditValue.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void LoadGrid()
        {
            try
            {

                this.spSelectAllOpeningStockTableAdapter.Fill(this.dsOpeningStock.spSelectAllOpeningStock,AppConstant.CompCode,AppConstant.UserID,Environment.MachineName);
                ClearFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void SaveRecord()
        {
            try
            {

                this.spSelectAllOpeningStockTableAdapter.Insert(
                    AppConstant.CompCode,
                    CostCenterTextEdit.EditValue.ToString(),
                    ItemCodeTextEdit.EditValue.ToString(),
                    StockDateDateEdit.DateTime,
                    UOMTextEdit.Text,
                    QuantityTextEdit.Text,
                    WareHouseTextEdit.EditValue.ToString(),
                    RemarksTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Opening stock saved successfully");
                LoadGrid();
                ClearFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void ClearFields()
        {
            try
            {

                CostCenterTextEdit.EditValue = "001";
                ItemCodeTextEdit.EditValue = "001";
                StockDateDateEdit.DateTime = DateTime.Now;
               // UOMTextEdit.Text = "";
                   // QuantityTextEdit.Text
                    WareHouseTextEdit.EditValue = "001";
                    RemarksTextEdit.Text = "Stock take";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void disableFields()
        {
            try
            {
                CostCenterTextEdit.Enabled = false;
                ItemCodeTextEdit.Enabled = false;
                StockDateDateEdit.Enabled = false;
                UOMTextEdit.Enabled = false;
                QuantityTextEdit.Enabled = false;
                WareHouseTextEdit.Enabled = false;
                RemarksTextEdit.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EnableField()
        {
            try
            {
                CostCenterTextEdit.Enabled = true;
                ItemCodeTextEdit.Enabled = true;
                StockDateDateEdit.Enabled = true;
                UOMTextEdit.Enabled = true;
                QuantityTextEdit.Enabled = true;
                WareHouseTextEdit.Enabled = true;
                RemarksTextEdit.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void DeleteRecord()
        {
            try
            {

                var CostCenter = CostCenterTextEdit.EditValue.ToString();
                var ItemCode = ItemCodeTextEdit.EditValue.ToString();

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete opening stock for item  " + ItemCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllOpeningStockTableAdapter.Delete(AppConstant.CompCode, CostCenter, ItemCode, AppConstant.UserID,Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    LoadGrid();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void SelectRecord()
        {
            try
            {

                var CostCenter = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CostCenter"));
                var ItemCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("ItemCode"));
                this.spSelectOpeningStockTableAdapter.Fill(this.dsOpeningStock.spSelectOpeningStock, AppConstant.CompCode, CostCenter, ItemCode, AppConstant.UserID, Environment.MachineName);

                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public string ValidateControls()
        {
            try
            {
                if (this.CostCenterTextEdit.EditValue.Equals(string.Empty))
                {
                    return "Enter the CostCenter to proceed";
                }
                if (this.ItemCodeTextEdit.EditValue.ToString().Equals(string.Empty))
                {
                    return "Enter the ItemCode to proceed";
                }
                if ((this.StockDateDateEdit.DateTime.Equals(null)) || (this.StockDateDateEdit.DateTime.Equals(string.Empty)))
                {
                    return "Enter StockDate to proceed";
                }

                if (this.UOMTextEdit.Text.Equals(""))
                {
                    return "Enter UOM to proceed";
                }
                if (this.QuantityTextEdit.Text.Equals(""))
                {
                    return "Enter Quantity to proceed";
                }
                if (this.WareHouseTextEdit.EditValue.ToString().Equals(""))
                {
                    return "Enter WareHouse to proceed";
                }
                if (this.RemarksTextEdit.ToString().Equals(""))
                {
                    return "Enter Remarks to proceed";
                }
                return "Success";
            }
            catch (Exception)
            {

                return null;
            }
        }

        private void ItemCodeTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.spGetItemCodesTableAdapter.Fill(this.dsOpeningStock.spGetItemCodes, ItemCodeTextEdit.EditValue.ToString());
                UOMTextEdit.Text = dsOpeningStock.spGetItemCodes.DataSet.Tables["spGetItemCodes"].Rows[0]["UOM"].ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateControls().Equals("Success"))
                {
                    this.SaveRecord();
                }
                else
                {
                    MessageBox.Show(this.ValidateControls(), "warehouses Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                EnableField();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteRecord();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                gridView1.ShowPrintPreview();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                SelectRecord();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}