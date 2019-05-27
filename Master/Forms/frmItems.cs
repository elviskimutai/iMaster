using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Master.Forms
{
    public partial class frmItems : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Item Master";
        Security _Security = new Security();
        public frmItems()
        {
            InitializeComponent();          
            ItemCodeTextEdit.Text = "0";
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            try
            {
                ItemCodeTextEdit.Enabled = false;
                NarrationTextEdit.Text = "New Item";
                // TODO: This line of code loads data into the 'dsItemMaster.spSelectAllItemCategories' table. You can move, or remove it, as needed.
                this.spSelectAllItemCategoriesTableAdapter.Fill(this.dsItemMaster.spSelectAllItemCategories);
                // TODO: This line of code loads data into the 'dsItemMaster.spSelectAllUOM' table. You can move, or remove it, as needed.
                this.spSelectAllUOMTableAdapter.Fill(this.dsItemMaster.spSelectAllUOM);
                LoadGrid();
                spGetSuppliersTableAdapter.Fill(dsItemMaster.spGetSuppliers, AppConstant.CompCode);
                txVATRate.Text = "16";
                ReorderLevelTextEdit.Text = "2";
                SafetyStockTextEdit.Text = "2";
                UnitPriceTextEdit.Text = "0";
                UnitCostTextEdit.Text = "0";
                BarCodeTextEdit.Text = "0";
                comboBoxEditStockType.EditValue = "Stock Item";
                UOMLookUpEdit.EditValue = dsItemMaster.spSelectAllUOM.DataSet.Tables["spSelectAllUOM"].Rows[0]["Uom"].ToString();
                ItemCategoryLookUpEdit.EditValue=dsItemMaster.spSelectAllItemCategories.DataSet.Tables["spSelectAllItemCategories"].Rows[0]["Category"].ToString();
                PrimarySupplierLookUpEdit.EditValue=dsItemMaster.spGetSuppliers.DataSet.Tables["spGetSuppliers"].Rows[0]["Supplier Code"].ToString();
               // glcostcenter.EditValue = dsLedger.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
            }
            catch (Exception)
            {

               
            }
        }
        public void LoadGrid()
        {
            try
            {
                spSelectAllItemMasterTableAdapter.Fill(dsItemMaster.spSelectAllItemMaster, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void clearFields()
        {
            try
            {
                ItemCodeTextEdit.Text = "0";
                BarCodeTextEdit.Text = "0";
                ItemDescriptionTextEdit.Text = "";

                txVATRate.Text = "16";
                ReorderLevelTextEdit.Text = "2";
                SafetyStockTextEdit.Text = "2";
                UnitPriceTextEdit.Text = "0";
                UnitCostTextEdit.Text = "0";
                BarCodeTextEdit.Text = "0";
                comboBoxEditStockType.EditValue = "Stock Item";
                UOMLookUpEdit.EditValue = dsItemMaster.spSelectAllUOM.DataSet.Tables["spSelectAllUOM"].Rows[0]["Uom"].ToString();
                ItemCategoryLookUpEdit.EditValue = dsItemMaster.spSelectAllItemCategories.DataSet.Tables["spSelectAllItemCategories"].Rows[0]["Category"].ToString();
                PrimarySupplierLookUpEdit.EditValue = dsItemMaster.spGetSuppliers.DataSet.Tables["spGetSuppliers"].Rows[0]["Supplier Code"].ToString();


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
                ItemCodeTextEdit.Enabled = false;
                BarCodeTextEdit.Enabled = false;
                ItemDescriptionTextEdit.Enabled = false;
                UOMLookUpEdit.Enabled = false;
                txVATRate.Enabled = false;
               
                UnitPriceTextEdit.Enabled = false;
                UnitCostTextEdit.Enabled = false;
                PrimarySupplierLookUpEdit.Enabled = false;
                comboBoxEditStockType.Enabled = false;
                ReorderLevelTextEdit.Enabled = false;
                AllowBackOrdersCheckEdit.Enabled = false;
                NarrationTextEdit.Enabled = false;
                ItemCategoryLookUpEdit.Enabled = false;
                isTaxableCheckEdit.Enabled = false;
                isActiveCheckEdit.Enabled = false;
                SafetyStockTextEdit.Enabled = false;


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
                BarCodeTextEdit.Enabled = true;
                ItemDescriptionTextEdit.Enabled = true;
                UOMLookUpEdit.Enabled = true;
                txVATRate.Enabled = true;
                comboBoxEditStockType.Enabled = true;
                UnitPriceTextEdit.Enabled = true;
                UnitCostTextEdit.Enabled = true;
                PrimarySupplierLookUpEdit.Enabled = true;
                ReorderLevelTextEdit.Enabled = true;
                AllowBackOrdersCheckEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
                ItemCategoryLookUpEdit.Enabled = true;
                isTaxableCheckEdit.Enabled = true;
                isActiveCheckEdit.Enabled = true;
                SafetyStockTextEdit.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            if (this.ValidateRight("Add", AppConstant.UserID))
            {

                try
            {
                    String PriceBand = ItemDescriptionTextEdit.Text;
                    if (PriceBand == "" || PriceBand == null)
                    {
                        MessageBox.Show("Enter ItemDescription to Continue");
                        return;
                    }
                    String BarCodet = BarCodeTextEdit.Text;
                    if (BarCodet == "" || BarCodet == null)
                    {
                        MessageBox.Show("Enter BarCode to Continue");
                        return;
                    }
                    String ItemCode = ItemCodeTextEdit.Text;
                    if (ItemCode == "" || ItemCode == null)
                    {
                        MessageBox.Show("Enter ItemCode to Continue");
                        return;
                    }
                    String ItemDescription = ItemDescriptionTextEdit.Text;
                    if (ItemDescription == "" || ItemDescription == null)
                    {
                        MessageBox.Show("Enter ItemDescription to Continue");
                        return;
                    }
                    String VATRate = txVATRate.Text;
                    if (VATRate == "" || VATRate == null)
                    {
                        MessageBox.Show("Enter VATRate to Continue");
                        return;
                    }
                    String ReorderLevel = ReorderLevelTextEdit.Text;
                    if (ReorderLevel == "" || ReorderLevel == null)
                    {
                        MessageBox.Show("Enter ReorderLevel to Continue");
                        return;
                    }
                    String UnitCost = UnitCostTextEdit.Text;
                    if (UnitCost == "" || UnitCost == null)
                    {
                        MessageBox.Show("Enter UnitCost to Continue");
                        return;
                    }
                    String UnitPrice = UnitPriceTextEdit.Text;
                    if (UnitPrice == "" || UnitPrice == null)
                    {
                        MessageBox.Show("Enter UnitPrice to Continue");
                        return;
                    }
                    spSelectAllItemMasterTableAdapter.spSaveItemMaster(AppConstant.CompCode, ItemCodeTextEdit.Text, BarCodeTextEdit.Text, ItemDescriptionTextEdit.Text, 
                    UOMLookUpEdit.EditValue.ToString(), Convert.ToDouble(txVATRate.Text), Convert.ToDecimal(UnitPriceTextEdit.Text), Convert.ToDecimal(UnitCostTextEdit.Text),
                    PrimarySupplierLookUpEdit.EditValue.ToString(), Convert.ToDouble(ReorderLevelTextEdit.Text), AllowBackOrdersCheckEdit.Checked, NarrationTextEdit.Text,
                    ItemCategoryLookUpEdit.EditValue.ToString(), isTaxableCheckEdit.Checked, isActiveCheckEdit.Checked, Convert.ToDouble(SafetyStockTextEdit.Text), 
                    Environment.MachineName, AppConstant.UserID, comboBoxEditStockType.EditValue.ToString());
                MessageBox.Show("Item Saved Succesfully");
                LoadGrid();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to add Item Matser", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            if (this.ValidateRight("Edit", AppConstant.UserID))
            {
                EnableField();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Edit Item Matser", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void SelectRecord()
        {
            try
            {
                 var ItemCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("ItemCode"));

                spSelectItemMasterTableAdapter.Fill(dsItemMaster.spSelectItemMaster, ItemCode, AppConstant.UserID, Environment.MachineName);
                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            SelectRecord();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Delete", AppConstant.UserID))
            {
                try
            {
                spSelectAllItemMasterTableAdapter.spDeleteItemMaster( ItemCodeTextEdit.Text, AppConstant.UserID, Environment.MachineName);
                MessageBox.Show("Item Deleted Succesfully");
                LoadGrid();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Delete Item Matser", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Export", AppConstant.UserID))
            {
                gridView1.ShowPrintPreview();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Export Item Matser", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}