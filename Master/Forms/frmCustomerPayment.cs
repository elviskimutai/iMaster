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
    public partial class frmCustomerPayment : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomerPayment()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmCustomerPayment_Load(object sender, EventArgs e)
        {
            try
            {
              //  glApplyCredit.Text = "Select Credit";
                this.spGetBankAccountsTableAdapter.Fill(this.dsCustomerPayment.spGetBankAccounts, AppConstant.CompCode);
                this.spGetCompanyCostCentersTableAdapter.Fill(this.dsCustomerPayment.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsCustomerPayment.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                spgetUDCByCategoryTableAdapter.Fill(dsCustomerPayment.spgetUDCByCategory, "Pay Mode");
                glPaymode.EditValue = "CSH";
                spGetCustomersWithInvoicesTableAdapter.Fill(dsCustomerPayment.spGetCustomersWithInvoices, AppConstant.CompCode, glCostCenter.EditValue.ToString());
                txtRefNo.Text = "0";
            }
            catch (Exception)
            {

               
            }  
        }

        private void glCostCenter_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetCustomersWithInvoicesTableAdapter.Fill(dsCustomerPayment.spGetCustomersWithInvoices, AppConstant.CompCode, glCostCenter.EditValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void glCustomers_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetCustomerInvoicesTableAdapter.Fill(dsCustomerPayment.spGetCustomerInvoices,glCustomers.EditValue.ToString(), AppConstant.CompCode, AppConstant.UserID);
                lblTotalAmount.Text = string.Format("{0:n2}", Total());
                spGetCustCreditNotesTableAdapter.Fill(dsCustomerPayment.spGetCustCreditNotes, AppConstant.CompCode, glCustomers.EditValue.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public decimal Total()
        {
            try
            {
                Decimal Total = 0;
                for (int i = 0; i <= ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    Total += Convert.ToDecimal(gridView1.GetRowCellValue(i, colBalance));
                }

                return Total;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public bool SaveCustomerPaymment()
        {
            try
            {
                for (int i = 0; i < ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    string invoice = gridView1.GetRowCellValue(i, colInvoiceNo).ToString();
                    Decimal Amount = Convert.ToDecimal(gridView1.GetRowCellValue(i, colAmount));
                    Decimal Credit = Convert.ToDecimal(gridView1.GetRowCellValue(i, colCredit));
                    spGetCustomerInvoicesTableAdapter.spSaveCustomerPayments(AppConstant.CompCode, glCostCenter.EditValue.ToString(), glCustomers.EditValue.ToString(), invoice, Amount+ Credit, Convert.ToDecimal(lblTotalAmount.Text), glPaymode.EditValue.ToString(), glAccountNumber.EditValue.ToString(), txtRefNo.Text, AppConstant.UserID, Environment.MachineName);
                   
                }
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public string validateForm()
        {
            try
            {
                string Ref = txtRefNo.Text;
                if (Ref ==null || Ref=="")
                {
                    return "Enter RefNo to proceed";
                }
                string Paymode = glPaymode.EditValue.ToString();
                if (Paymode == null || Paymode == "")
                {
                    return "Enter Paymode to proceed";
                }
                //string Account = glAccountNumber.EditValue.ToString();
                //if (Account == null || Account == "")
                //{
                //    return "Enter Account Number to proceed";
                //}
                for (int i = 0; i <= ((GridView)gridControl1.MainView).RowCount; i++)
                {
                    Decimal OrderTotal= Convert.ToDecimal(gridView1.GetRowCellValue(i, colOrderAmount));
                    Decimal AmountPaid = Convert.ToDecimal(gridView1.GetRowCellValue(i, colAmountPaid));
                    Decimal Amount = Convert.ToDecimal(gridView1.GetRowCellValue(i, colAmount));
                    Decimal Credit = Convert.ToDecimal(gridView1.GetRowCellValue(i, colCredit));
                    if ((Amount+ Credit) > (OrderTotal- AmountPaid))
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
                        if (SaveCustomerPaymment() == true)
                        {
                            if (UpdateCreditNote() == true)
                            {
                                MessageBox.Show("Customer receipt made successfully");
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
                dsCustomerPayment.spGetCustomerInvoices.Clear();
                lblTotalAmount.Text = "0.00";
            }
        }

        private void gridView4_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Decimal CreditAmount = 0;
            Decimal Balance = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Balance"));
            Decimal ECredit = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Credit"));
            try
            {

               
                    foreach (var rowHandle in gridView4.GetSelectedRows())
                    {
                        CreditAmount += Convert.ToDecimal(gridView4.GetRowCellValue(rowHandle, Amount));
                    }
                    if (Balance >= CreditAmount)
                    {

                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCredit, ECredit + CreditAmount);
                        gridView4.SetRowCellValue(gridView4.FocusedRowHandle, Amount, (Convert.ToDecimal(gridView4.GetFocusedRowCellValue("Amount"))) - CreditAmount);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colBalance, Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Balance")) - CreditAmount);
                    }
                    else
                    {
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colCredit, ECredit + Balance);
                        gridView4.SetRowCellValue(gridView4.FocusedRowHandle, Amount, (Convert.ToDecimal(gridView4.GetFocusedRowCellValue("Amount"))) - Balance);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colBalance, 0);
                    }
               
              

            }
            catch (Exception)
            {


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
                    spGetCustomerInvoicesTableAdapter.spUpdateCreditNoteBalance(Doc, AvailableCredit);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridView4.ClearSelection();

        }
    }
}