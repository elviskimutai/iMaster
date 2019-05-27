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
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace Master.Forms
{
    public partial class frmSupplierQuotations : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Supplier Quotations";
        public frmSupplierQuotations()
        {
            InitializeComponent();
         

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
        private void ReqNoGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spSelectItemsperRequisitionTableAdapter.Fill(dsSupplierQuotations.spSelectItemsperRequisition, ReqNoGridLookUpEdit.EditValue.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmSupplierQuotations_Load(object sender, EventArgs e)
        {
            try
            {
                QuantityTextEdit.Text = "0";
                ExtendedCostTextEdit.Text = "0";
              //  UnitCostTextEdit.EditValue = "0";
                DiscountAmountTextEdit.Text = "0";
                DiscountRateTextEdit.Text = "0";
                TaxRateTextEdit.Text = "16";
                TaxAmountTextEdit.Text = "0";
               
                NarrationTextEdit.Text = "New Supplier Quotation";
                spgetCurrenciesTableAdapter.Fill(dsSupplierQuotations.spgetCurrencies, AppConstant.UserID, Environment.MachineName);
                spGetSuppliersTableAdapter.Fill(dsSupplierQuotations.spGetSuppliers, AppConstant.CompCode);
                spgetApprovedRequsitionNoTableAdapter.Fill(dsSupplierQuotations.spgetApprovedRequsitionNo, AppConstant.CompCode);
                spSelectAllSupplierQUotationsTableAdapter.Fill(dsSupplierQuotations.spSelectAllSupplierQUotations, AppConstant.CompCode);
                currencygridLookUpEdit.EditValue = "KES";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void UnitCostTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ExtendedCostTextEdit.Text = ((Convert.ToDouble(QuantityTextEdit.Text)* Convert.ToDouble(QuantityTextEdit.Text)).ToString());
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
                    String QuotationNo = QuotationNoGridLookUpEdit.Text;
                    if (QuotationNo == "" || QuotationNo == null)
                    {
                        MessageBox.Show("Enter QuotationNo to Continue");
                        return;
                    }
                    spSelectAllSupplierQUotationsTableAdapter.Insert(ReqNoGridLookUpEdit.EditValue.ToString(), QuotationNoGridLookUpEdit.Text, AppConstant.CompCode, SupplierGridLookUpEdit.EditValue.ToString(), 1, ItemCodeGridLookUpEdit.EditValue.ToString(), Convert.ToDouble(QuantityTextEdit.Text), Convert.ToDecimal(UnitCostTextEdit.Text), NarrationTextEdit.Text, AppConstant.UserID, Environment.MachineName, Convert.ToDouble(DiscountRateTextEdit.Text), Convert.ToDecimal(DiscountAmountTextEdit.Text),Convert.ToDouble(TaxRateTextEdit.Text), currencygridLookUpEdit.EditValue.ToString());
                    MessageBox.Show("Saved Succesffuly");
                    spSelectAllSupplierQUotationsTableAdapter.Fill(dsSupplierQuotations.spSelectAllSupplierQUotations, AppConstant.CompCode);
                    spSelectItemsperRequisitionTableAdapter.Fill(dsSupplierQuotations.spSelectItemsperRequisition, ReqNoGridLookUpEdit.EditValue.ToString());
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Bank Branches", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    this.gridView4.ShowPrintPreview();
                }


                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Supplier Quotations", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
                if (this.ValidateRight("Delete", AppConstant.UserID))
                {
                    spSelectAllSupplierQUotationsTableAdapter.Delete(ReqNoGridLookUpEdit.EditValue.ToString(), QuotationNoGridLookUpEdit.Text, AppConstant.CompCode, SupplierGridLookUpEdit.EditValue.ToString(), ItemCodeGridLookUpEdit.EditValue.ToString());
                    MessageBox.Show("Deleted Succesfully");
                    spSelectAllSupplierQUotationsTableAdapter.Fill(dsSupplierQuotations.spSelectAllSupplierQUotations, AppConstant.CompCode);
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Supplier Quotations", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void selectrecord()
        {
            try
            {

                var ReqNo = Convert.ToString(this.gridView3.GetFocusedRowCellValue("ReqNo"));
                var Supplier = Convert.ToString(this.gridView3.GetFocusedRowCellValue("Supplier"));
                var ItemCode = Convert.ToString(this.gridView3.GetFocusedRowCellValue("ItemCode"));
                var QuotationNo = Convert.ToString(this.gridView3.GetFocusedRowCellValue("QuotationNo"));
                var Compcode = Convert.ToString(this.gridView3.GetFocusedRowCellValue("CompCode"));
                spSelectSupplierQUotationsTableAdapter.Fill(dsSupplierQuotations.spSelectSupplierQUotations, ReqNo, QuotationNo, Compcode, Supplier, ItemCode);
                disablefields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
      
        public  void disablefields()
        {
            try
            {
                ReqNoGridLookUpEdit.Enabled = false;
                SupplierGridLookUpEdit.Enabled = false;
                ItemCodeGridLookUpEdit.Enabled = false;
                QuantityTextEdit.Enabled = false;
                QuotationNoGridLookUpEdit.Enabled = false;
                NarrationTextEdit.Enabled = false;
                ExtendedCostTextEdit.Enabled = false;
                UnitCostTextEdit.Enabled = false;
                DiscountRateTextEdit.Enabled = false;
                DiscountAmountTextEdit.Enabled = false;
                TaxRateTextEdit.Enabled = false;
                currencygridLookUpEdit.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Edit", AppConstant.UserID))
                {
                    SupplierGridLookUpEdit.Enabled = true;
                ItemCodeGridLookUpEdit.Enabled = true;
                QuantityTextEdit.Enabled = true;
                    QuotationNoGridLookUpEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
                //ExtendedCostTextEdit.Enabled = true;
                UnitCostTextEdit.Enabled = true;
                    ReqNoGridLookUpEdit.Enabled = true;
                    DiscountRateTextEdit.Enabled = true;
                    DiscountAmountTextEdit.Enabled = true;
                    TaxRateTextEdit.Enabled = true;
                    currencygridLookUpEdit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Supplier Quotations", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            try
            {

                var ReqNo = Convert.ToString(this.gridView4.GetFocusedRowCellValue("ReqNo"));
                var Supplier = Convert.ToString(this.gridView4.GetFocusedRowCellValue("Supplier"));
                var ItemCode = Convert.ToString(this.gridView4.GetFocusedRowCellValue("ItemCode"));
                var QuotationNo = Convert.ToString(this.gridView4.GetFocusedRowCellValue("QuotationNo"));
                var Compcode = AppConstant.CompCode;
                spSelectSupplierQUotationsTableAdapter.Fill(dsSupplierQuotations.spSelectSupplierQUotations, ReqNo, QuotationNo, Compcode, Supplier, ItemCode);
                disablefields();
            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
            }
        }

        private void ReqNoGridLookUpEdit_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                spSelectItemsperRequisitionTableAdapter.Fill(dsSupplierQuotations.spSelectItemsperRequisition, ReqNoGridLookUpEdit.EditValue.ToString());
                QuotationNoGridLookUpEdit.EditValue = "";
            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
            }
        }

        private void UnitCostTextEdit_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                ExtendedCostTextEdit.Text = ((Convert.ToDouble(UnitCostTextEdit.Text) * Convert.ToDouble(QuantityTextEdit.Text) - (Convert.ToDouble(DiscountAmountTextEdit.Text))).ToString());
                Double Ext = Convert.ToDouble(UnitCostTextEdit.Text) * Convert.ToDouble(QuantityTextEdit.Text);
                Double TaxRate = Convert.ToDouble(TaxRateTextEdit.Text);
                TaxAmountTextEdit.Text = (((TaxRate / (TaxRate + 100)) * Ext).ToString());
                //Double Ext = Convert.ToDouble(UnitCostTextEdit.Text) * Convert.ToDouble(QuantityTextEdit.Text);
                Double DiscountRate = Convert.ToDouble(DiscountRateTextEdit.Text);
                DiscountAmountTextEdit.Text = (((DiscountRate / 100) * Ext).ToString());
            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
            }
        }

        private void DiscountAmountTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ExtendedCostTextEdit.Text = ((Convert.ToDouble(UnitCostTextEdit.Text) * Convert.ToDouble(QuantityTextEdit.Text) - (Convert.ToDouble(DiscountAmountTextEdit.Text))).ToString());

                Double Ext = Convert.ToDouble(UnitCostTextEdit.Text) * Convert.ToDouble(QuantityTextEdit.Text);
                Double Discount = Convert.ToDouble(DiscountAmountTextEdit.Text);
                DiscountRateTextEdit.Text = (((Discount / Ext) * 100).ToString());
            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
            }
        }

        private void TaxRateTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Double Ext = Convert.ToDouble(UnitCostTextEdit.Text) * Convert.ToDouble(QuantityTextEdit.Text);
                Double TaxRate = Convert.ToDouble(TaxRateTextEdit.Text);
                TaxAmountTextEdit.Text = (((TaxRate/(TaxRate + 100))* Ext).ToString());
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }

        private void QuantityTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ExtendedCostTextEdit.Text = ((Convert.ToDouble(UnitCostTextEdit.Text) * Convert.ToDouble(QuantityTextEdit.Text) - (Convert.ToDouble(DiscountAmountTextEdit.Text))).ToString());
                Double Ext = Convert.ToDouble(UnitCostTextEdit.Text) * Convert.ToDouble(QuantityTextEdit.Text);
                Double TaxRate = Convert.ToDouble(TaxRateTextEdit.Text);
               TaxAmountTextEdit.Text = (((TaxRate / (TaxRate + 100)) * Ext).ToString());
               // Double Ext = Convert.ToDouble(UnitCostTextEdit.Text) * Convert.ToDouble(QuantityTextEdit.Text);
                Double DiscountRate = Convert.ToDouble(DiscountRateTextEdit.Text);
                DiscountAmountTextEdit.Text = (((DiscountRate / 100) * Ext).ToString());
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
               // ExtendedCostTextEdit.Text = ((Convert.ToDouble(UnitCostTextEdit.Text) * Convert.ToDouble(QuantityTextEdit.Text) - (Convert.ToDouble(DiscountAmountTextEdit.Text))).ToString());
                Double Ext = Convert.ToDouble(UnitCostTextEdit.Text) * Convert.ToDouble(QuantityTextEdit.Text);
                Double DiscountRate = Convert.ToDouble(DiscountRateTextEdit.Text);
                DiscountAmountTextEdit.Text = (((DiscountRate / 100) * Ext).ToString());
            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }
        }

        private void SupplierGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            QuotationNoGridLookUpEdit.EditValue = "" ;
        }

        private void ItemCodeGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            QuantityTextEdit.Text = Convert.ToString(this.gridView3.GetFocusedRowCellValue("Quantity")); ;
        }
        public static void databaseFilePut(string varFilePath,String QuotationNo)
        {
            try
            {
                byte[] file;
                using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }
                using (SqlConnection varConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
                using (var sqlWrite = new SqlCommand("INSERT INTO SupplierQuotationsAttachments(Attachment,QuotationNo,CreatedUser) Values(@File,@QuotationNo,@CreatedUser)", varConnection))
                {
                    sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
                    sqlWrite.Parameters.Add("@QuotationNo", SqlDbType.NVarChar, 50).Value=QuotationNo;
                    sqlWrite.Parameters.Add("@CreatedUser", SqlDbType.NVarChar, 50).Value = AppConstant.UserID;
                    if (varConnection.State == ConnectionState.Closed)
                    {
                        varConnection.Open();
                    }
                    sqlWrite.ExecuteNonQuery();
                }
                // using (var varConnection = Locale.sqlConnectOneTime(Locale.sqlDataConnectionDetails))
                //using (var sqlWrite = new SqlCommand("spsaveSupplierQuotationsAttachments", varConnection))
                //{
                //     sqlWrite.Parameters.Add("@Attachment", SqlDbType.VarBinary, file.Length).Value = file;
                //  //  sqlWrite.Parameters.AddWithValue("@Attachment", file);
                //    sqlWrite.Parameters.AddWithValue("@QuotationNo", QuotationNo);
                //    sqlWrite.Parameters.AddWithValue("@CreatedUser", AppConstant.UserID);
                //    if (varConnection.State == ConnectionState.Closed)
                //    {
                //        varConnection.Open();
                //    }
                //    sqlWrite.ExecuteNonQuery();
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public static void databaseFileRead(string varID, string varPathToNewLocation)
        {
            using (SqlConnection varConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            using (var sqlQuery = new SqlCommand(@"SELECT Attachment FROM SupplierQuotationsAttachments WHERE QuotationNo = @varID", varConnection))
            {
                sqlQuery.Parameters.AddWithValue("@varID", varID);
                if (varConnection.State == ConnectionState.Closed)
                {
                    varConnection.Open();
                }
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                    if (sqlQueryResult != null)
                    {
                        sqlQueryResult.Read();
                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        using (var fs = new FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write))
                            fs.Write(blob, 0, blob.Length);
                    }


            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                String QuotationNo = QuotationNoGridLookUpEdit.Text;
                if (QuotationNo == "" || QuotationNo == null)
                {
                    MessageBox.Show("Enter QuotationNo to Continue");
                    return;
                }

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Text files | *.pdf"; // file types, that will be allowed to upload
                dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
                if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
                {
                    String path = dialog.FileName; // get name of file
                  
                   
                    databaseFilePut(path, QuotationNo);
                    MessageBox.Show("Upload successfull");
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                var QuotationNo = Convert.ToString(this.gridView4.GetFocusedRowCellValue("QuotationNo"));
                string download = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                string path = download +"\\Quotation"+ QuotationNo  +".pdf";
                databaseFileRead(QuotationNo, path);
                MessageBox.Show("Download Complete,please check your downloads directory");
            }
            catch (Exception ex)
            {

                
                if (ex.Message.ToLowerInvariant().Contains(" attempt to read when no data is present"))
                {
                    MessageBox.Show("ERROR!! No Quotation document was uploaded for this quotataion");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
             }
        }
    }
}