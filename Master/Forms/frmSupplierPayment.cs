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
    public partial class frmSupplierPayment : DevExpress.XtraEditors.XtraForm
    {
        public frmSupplierPayment()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void glCostCenter_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetSuppliersWithBalancesTableAdapter.Fill(dsSupplierPayment.spGetSuppliersWithBalances, AppConstant.CompCode, glCostCenter.EditValue.ToString());
            }
            catch (Exception)
            {

               
            }
        }

        private void frmSupplierPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSupplierPayment.spGetBankAccounts' table. You can move, or remove it, as needed.
            try
            {
                this.spGetBankAccountsTableAdapter.Fill(this.dsSupplierPayment.spGetBankAccounts,AppConstant.CompCode);
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsSupplierPayment.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsSupplierPayment.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                spgetUDCByCategoryTableAdapter.Fill(dsSupplierPayment.spgetUDCByCategory, "Pay Mode");
                glPaymode.EditValue = "CSH";
            }
            catch (Exception)
            {

                
            }
        }

        private void glSuppliers_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetSupplierInvoicesTableAdapter.Fill(dsSupplierPayment.spGetSupplierInvoices, glSuppliers.EditValue.ToString(),AppConstant.CompCode,AppConstant.UserID);
                lblTotalAmount.Text = string.Format("{0:n2}", Total());//string.Format("{0:n2}", dsSupplierPayment.spGetSupplierInvoices.DataSet.Tables["spGetSupplierInvoices"].Rows[0]["Total"].ToString());
                spGetSupplierDebtorsNoteTableAdapter.Fill(dsSupplierPayment.spGetSupplierDebtorsNote, AppConstant.CompCode, glSuppliers.EditValue.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        public string validateForm()
        {
            try
            {
                string Ref = txtRefNo.Text;
                if (Ref == null || Ref == "")
                {
                    return "Enter RefNo to proceed";
                }
                string Paymode = glPaymode.EditValue.ToString();
                if (Paymode == null || Paymode == "")
                {
                    return "Enter Paymode to proceed";
                }
                string Account = glAccountNumber.EditValue.ToString();
                if (Account == null || Account == "")
                {
                    return "Enter Account Number to proceed";
                }
                for (int i = 0; i <= ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    Decimal OrderTotal = Convert.ToDecimal(gridView1.GetRowCellValue(i, colTotalInvoiceAmount));
                    Decimal AmountPaid = Convert.ToDecimal(gridView1.GetRowCellValue(i, colAmountPaid));
                    Decimal Amount = Convert.ToDecimal(gridView1.GetRowCellValue(i, colAmount));
                    Decimal Credit = Convert.ToDecimal(gridView1.GetRowCellValue(i, colCredit));
                    if ((Amount + Credit) > (OrderTotal - AmountPaid))
                    {
                        return "Amount should be less than invoice amount";
                    }

                }
                return "Success";
            }
            catch (Exception)
            {

                return "Validation failed. Confirm figures and try again.";
            }
        }
        private void spSave_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to make payment for this invoices?", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    if (this.validateForm() == "Success")
                    {
                        if (SaveSupplierPayments() == true)
                        {
                            if (UpdateCreditNote() == true)
                            {
                                MessageBox.Show("Supplier payment made successfully");
                            }

                        }
                    }
                    else
                    {

                        MessageBox.Show(this.validateForm(), "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dsSupplierPayment.spGetSupplierInvoices.Clear();
            }

        }
        public bool UpdateCreditNote()
        {
            try
            {
                for (int i = 0; i < gridView4.DataRowCount; i++)
                {
                    string Doc = gridView4.GetRowCellValue(i, DocNo).ToString();
                    Decimal AvailableCredit = Convert.ToDecimal(gridView4.GetRowCellValue(i, Amount));
                    spGetSupplierInvoicesTableAdapter.spUpdateDebitNoteBalance(Doc, AvailableCredit);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SaveSupplierPayments()
        {
            try
            {
                for (int i = 0; i < ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    string invoice = gridView1.GetRowCellValue(i, colInvoiceNo).ToString();
                    string DocNo = gridView1.GetRowCellValue(i, colDocNo).ToString();
                    Decimal Amount = Convert.ToDecimal(gridView1.GetRowCellValue(i, colAmount));
                    Decimal Credit = Convert.ToDecimal(gridView1.GetRowCellValue(i, colCredit));
                    spGetSupplierInvoicesTableAdapter.spSaveSupplierPayments(AppConstant.CompCode, glCostCenter.EditValue.ToString(), glSuppliers.EditValue.ToString(), invoice, DocNo, txtRefNo.Text, glPaymode.EditValue.ToString(), glAccountNumber.EditValue.ToString(), i+1, Amount+ Credit, AppConstant.UserID, Environment.MachineName);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public decimal Total()
        {
            try
            {
                Decimal Total = 0;
                for (int i = 0; i <= ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    Total += Convert.ToDecimal(gridView1.GetRowCellValue(i, colOpenAmount));
                }

                return Total;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        private void gridView4_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Decimal CreditAmount = 0;
            Decimal Balance = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("OpenAmount"));
            Decimal ECredit = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Credit"));
            try
            {

                if (gridView4.GetSelectedRows().Count()>0)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to use the selected credit?", "Confirm!", MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        foreach (var rowHandle in gridView4.GetSelectedRows())
                        {
                            CreditAmount += Convert.ToDecimal(gridView4.GetRowCellValue(rowHandle, Amount));
                        }
                        if (Balance >= CreditAmount)
                        {

                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCredit, ECredit + CreditAmount);
                            gridView4.SetRowCellValue(gridView4.FocusedRowHandle, Amount, (Convert.ToDecimal(gridView4.GetFocusedRowCellValue("Amount"))) - CreditAmount);
                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colOpenAmount, Convert.ToDecimal(gridView1.GetFocusedRowCellValue("OpenAmount")) - CreditAmount);
                        }
                        else
                        {
                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCredit, ECredit + Balance);
                            gridView4.SetRowCellValue(gridView4.FocusedRowHandle, Amount, (Convert.ToDecimal(gridView4.GetFocusedRowCellValue("Amount"))) - Balance);
                            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colOpenAmount, 0);
                        }
                    }
                }
               



            }
            catch (Exception)
            {


            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridView4.ClearSelection();
        }
    }
}