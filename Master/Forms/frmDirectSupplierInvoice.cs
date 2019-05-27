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
    public partial class frmDirectSupplierInvoice : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Direct Supplier Invoice";
        Security _Security = new Security();
        public frmDirectSupplierInvoice()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmDirectSupplierInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSupplierInvoices.spSelectAllUOM' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'dsSupplierInvoices.spGetItems' table. You can move, or remove it, as needed.
            try
            {
                LoadGrid();
                this.spGetItemsTableAdapter.Fill(this.dsSupplierInvoices.spGetItems,AppConstant.CompCode);
                this.spgetCurrenciesTableAdapter.Fill(this.dsSupplierInvoices.spgetCurrencies,AppConstant.UserID,Environment.MachineName);
                this.spGetSuppliersTableAdapter.Fill(this.dsSupplierInvoices.spGetSuppliers, AppConstant.CompCode);
                this.spSelectAllUOMTableAdapter.Fill(this.dsSupplierInvoices.spSelectAllUOM);
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsSupplierInvoices.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                spgetCompanyCurrencyTableAdapter.Fill(dsSupplierInvoices.spgetCompanyCurrency, AppConstant.CompCode);
                String CompCurr = dsSupplierInvoices.spgetCompanyCurrency.DataSet.Tables["spgetCompanyCurrency"].Rows[0]["basecurr"].ToString();
                UOMGridLookUpEdit.EditValue = dsSupplierInvoices.spSelectAllUOM.DataSet.Tables["spSelectAllUOM"].Rows[0]["UOM"].ToString();
                InvoiceDateDateEdit.DateTime = DateTime.Now;
                DueDateDateEdit.DateTime = DateTime.Now.AddDays(30);
                DiscountRateTextEdit.Text = "0";
                QtyTextEdit.Text = "1";
                RemarksTextEdit.Text = "New Supplier Invoice";
                DocCurrencyGridLookUpEdit.EditValue = CompCurr;
              //  CurrencyGridLookUpEdit.EditValue = CompCurr;
                CostCenterGridLookUpEdit.EditValue = dsSupplierInvoices.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0][0].ToString();
                SupplierGridLookUpEdit.EditValue= dsSupplierInvoices.spGetSuppliers.DataSet.Tables["spGetSuppliers"].Rows[0][0].ToString();
                ItemCodeGridLookUpEdit.EditValue = dsSupplierInvoices.spGetItems.DataSet.Tables["spGetItems"].Rows[0][0].ToString();
                //LineNumberTextEdit.Text = "1";
                //LineNumberTextEdit.ReadOnly = true;
                textEdidUnitPrice.Enabled = false;
                textEdidUnitPrice.Text = "0";
                textEditExtended.Text = "0";
                textEditExtended.Enabled = false;
                textEditDiscountamnt.Text = "0";
                textEditDiscountamnt.Enabled = false;

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
        public void LoadGrid()
        {
            try
            {
                spSelectAllSupplierInvoicesBufferTableAdapter.Fill(dsSupplierInvoices.spSelectAllSupplierInvoicesBuffer, AppConstant.UserID, AppConstant.CompCode);
            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
            }
        }
        public void ClearFields()
        {
            try
            {
                InvoiceDateDateEdit.DateTime = DateTime.Now;
                DueDateDateEdit.DateTime = DateTime.Now.AddDays(30);
                DiscountRateTextEdit.Text = "0";
                QtyTextEdit.Text = "1";
                String CompCurr = dsSupplierInvoices.spgetCompanyCurrency.DataSet.Tables["spgetCompanyCurrency"].Rows[0]["basecurr"].ToString();
                // String CompCurr = spgetCompanyCurrencyTableAdapter.GetData(AppConstant.CompCode).ToString();
                DocCurrencyGridLookUpEdit.EditValue = CompCurr;
                //CurrencyGridLookUpEdit.EditValue = CompCurr;
                SupplierGridLookUpEdit.EditValue = dsSupplierInvoices.spGetSuppliers.DataSet.Tables["spGetSuppliers"].Rows[0][0].ToString();
                ItemCodeGridLookUpEdit.EditValue = dsSupplierInvoices.spGetItems.DataSet.Tables["spGetItems"].Rows[0][0].ToString();
                CostCenterGridLookUpEdit.EditValue = dsSupplierInvoices.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0][0].ToString();
                //float last = Convert.ToUInt32(LineNumberTextEdit.Text);
                // LineNumberTextEdit.Text =(last+1).ToString();
                ////String UOM = Convert.ToString(this.gridView4.GetFocusedRowCellValue("UOM"));
                //LineNumberTextEdit.ReadOnly = true;
                UOMGridLookUpEdit.EditValue = dsSupplierInvoices.spSelectAllUOM.DataSet.Tables["spSelectAllUOM"].Rows[0]["UOM"].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void ItemCodeGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                String UOM = Convert.ToString(this.gridView4.GetFocusedRowCellValue("UOM"));
                UOMGridLookUpEdit.EditValue = UOM;
                var Kpi = Convert.ToString(this.gridView4.GetFocusedRowCellValue("UnitCost"));
                textEdidUnitPrice.Text = Kpi;
                Double UnitCost = Convert.ToDouble(textEdidUnitPrice.Text);
                Double qty = Convert.ToDouble(QtyTextEdit.Text);
                Double extended = UnitCost * qty;
                textEditExtended.Text = Convert.ToString(extended);
            }
            catch (Exception ex)
            {
               //MessageBox.Show(ex.Message);
            }
           
        }
        public void SaveRecord()
        {
            try
            {
                String item2 = Convert.ToString(this.gridView4.GetFocusedRowCellValue("ItemDescription"));

                for (int i = 0; i < ((GridView)gridControl1.MainView).RowCount; i++)
                        {
                            String item1 = Convert.ToString(gridView6.GetRowCellValue(i, colItemDescription));
                         
                           // String item2 = ItemCodeGridLookUpEdit.EditValue.ToString();
                             if (item2 == item1)
                            {

                             MessageBox.Show("ERROR,Item " + item2 + " Is Already Added!");
                             return;
                            }
                        }
                    //

                    String Remarks = RemarksTextEdit.Text;
                if (Remarks == "" || Remarks == null)
                {
                    MessageBox.Show("Enter Remarks to Continue");
                    return;
                }

                String InvoiceNo = InvoiceNoTextEdit.Text;
                if (InvoiceNo == "" || InvoiceNo == null)
                {
                    MessageBox.Show("Enter InvoiceNo to Continue");
                    return;
                }
                String Qty = QtyTextEdit.Text;
                if (Qty == "" || Qty == null)
                {
                    MessageBox.Show("Enter Qty to Continue");
                    return;
                }
                String Discount = DiscountRateTextEdit.Text;
                if (Discount == "" || Discount == null)
                {
                    MessageBox.Show("Enter Discount Rate to Continue");
                    return;
                }
                this.spSelectAllSupplierInvoicesBufferTableAdapter.Insert(AppConstant.CompCode, CostCenterGridLookUpEdit.EditValue.ToString(),
                  1,// Convert.ToInt32(LineNumberTextEdit.Text),
                    SupplierGridLookUpEdit.EditValue.ToString(),
                    InvoiceNoTextEdit.Text,
                    InvoiceDateDateEdit.DateTime,
                    DueDateDateEdit.DateTime,
                    "Currency",
                  //  CurrencyGridLookUpEdit.EditValue.ToString(),
                    ItemCodeGridLookUpEdit.EditValue.ToString(),
                    "0",
                    Convert.ToDouble(QtyTextEdit.Text),
                    Convert.ToDouble(DiscountRateTextEdit.Text),
                    RemarksTextEdit.Text,
                    AppConstant.UserID,
                    Environment.MachineName
                 );
                MessageBox.Show("Item Added successfully");
                LoadGrid();
                ClearFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    SaveRecord();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Direct Supplier Invoice", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
                if (this.ValidateRight("Export", AppConstant.UserID))
                {
                    this.gridView6.ShowPrintPreview();
                }


                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Direct Supplier Invoice", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    spSelectSupplierInvoicesBufferTableAdapter.spUploadDirectSupplierInvoice( AppConstant.CompCode,AppConstant.UserID);
                    MessageBox.Show("Upload successfully");
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Direct Supplier Invoice", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void QtyTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
            Double UnitCost = Convert.ToDouble(textEdidUnitPrice.Text);
            Double qty = Convert.ToDouble(QtyTextEdit.Text);
            Double extended = UnitCost * qty;
            textEditExtended.Text = Convert.ToString(extended);
            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
            }
}

        private void DiscountRateTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Double extended = Convert.ToDouble(textEditExtended.Text);
                Double rate = Convert.ToDouble(DiscountRateTextEdit.Text);
                Double amnt = (rate * extended) / 100;
                textEditDiscountamnt.Text = Convert.ToString(amnt);
            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {

                var ItemCode = Convert.ToString(this.gridView6.GetFocusedRowCellValue("ItemCode"));
              //  var EmpNo = Convert.ToString(this.gridView1.GetFocusedRowCellValue("EmpNo"));

                this.spSelectSupplierInvoicesBufferTableAdapter.Fill(this.dsSupplierInvoices.spSelectSupplierInvoicesBuffer, AppConstant.UserID, ItemCode, AppConstant.CompCode);

               // disableFields();
            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
            }
        }

        private void textEdidUnitPrice_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Delete", AppConstant.UserID))
                {
                    spSelectAllSupplierInvoicesBufferTableAdapter.Delete(AppConstant.UserID, ItemCodeGridLookUpEdit.EditValue.ToString(), AppConstant.CompCode);
                    MessageBox.Show("Deleted successfully");
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Direct Supplier Invoice", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}