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
    public partial class frmCustomerRefund : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomerRefund()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmCustomerRefund_Load(object sender, EventArgs e)
        {
            try
            {
                TransDateDateEdit.DateTime = DateTime.Now;
                RemarksTextEdit.Text = "Customer refunds";
                RefNoTextEdit.Text = "0";
                this.spGetCustomerWithCreditNotesTableAdapter.Fill(dsCustomerRefund.spGetCustomerWithCreditNotes, AppConstant.CompCode);
                this.spgetUDCByCategoryTableAdapter.Fill(dsCustomerRefund.spgetUDCByCategory, "Pay Mode");
                PayModeTextEdit.EditValue = "CSH";
                this.spGetAsset_IncomeTableAdapter.Fill(this.dsCustomerRefund._spGetAsset_Income);
                // CustomerGridLookUpEdit.EditValue = dsCustomerRefund.spGetCustomerWithCreditNotes.DataSet.Tables["spGetCustomerWithCreditNotes"].Rows[0]["CustCode"].ToString();
                CustomerGridLookUpEdit.EditValue = AppConstant.CustCode;
                LoadGrid();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        


        private void CustomerGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetCustCreditNotesTableAdapter.Fill(dsCustomerRefund.spGetCustCreditNotes, AppConstant.CompCode, CustomerGridLookUpEdit.EditValue.ToString());
                CreditNoGridLookUpEdit.EditValue = AppConstant.DocNo;
                int Row = dsCustomerRefund.spGetCustCreditNotes.DataSet.Tables["spGetCustCreditNotes"].Rows.Count - 1;
                AmountTextEdit.Text = dsCustomerRefund.spGetCustCreditNotes.DataSet == null ? "0" : dsCustomerRefund.spGetCustCreditNotes.DataSet.Tables["spGetCustCreditNotes"].Rows[Row]["Amount"].ToString();
            }
            catch (Exception)
            {
              //  MessageBox.Show(ex.Message);
            }
           
           
        }
        public void LoadGrid()
        {
            try
            {
                spSelectAllCustomerRefundsTableAdapter.Fill(dsCustomerRefund.spSelectAllCustomerRefunds, AppConstant.CompCode,AppConstant.UserID,Environment.MachineName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
       
        private void CreditNoGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                AmountTextEdit.Text = Convert.ToString(this.gridView1.GetFocusedRowCellValue("Amount"));
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool SaveCustomerRefunds()
        {
            try
            {
                spSelectAllCustomerRefundsTableAdapter.spSaveCustomerRefunds(AppConstant.CompCode, CreditNoGridLookUpEdit.EditValue.ToString(), CustomerGridLookUpEdit.EditValue.ToString(),  RefNoTextEdit.Text, PayModeTextEdit.EditValue.ToString(), GLAccountGridLookUpEdit.EditValue.ToString(), Convert.ToDecimal(AmountTextEdit.Text), RemarksTextEdit.Text, Environment.MachineName, AppConstant.UserID); ;

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
                string Ref = RefNoTextEdit.Text;
                if (Ref == null || Ref == "")
                {
                    return "Enter RefNo to proceed";
                }
                string Paymode = PayModeTextEdit.EditValue.ToString();
                if (Paymode == null || Paymode == "")
                {
                    return "Enter Paymode to proceed";
                }
                Decimal Amount = Convert.ToDecimal(AmountTextEdit.Text);
                if (Amount<=0)
                {
                    return "Amount should be greater than zero.";
                }
                string Account = GLAccountGridLookUpEdit.EditValue.ToString();
                if (Account == null || Account == "")
                {
                    return "Enter GL Account to proceed";
                }
                if (Amount> Convert.ToDecimal(this.gridView1.GetFocusedRowCellValue("Amount")))
                {
                    return "Amount should not be greater than Credit Note.";
                }
                return "Success";
            }
            catch (Exception)
            {

                return "Validation failed. Confirm figures and try again.";
            }
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to make this refund?", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    if (this.validateForm() == "Success")
                    {
                        if (SaveCustomerRefunds() == true)
                        {
                            LoadGrid();
                            MessageBox.Show("Customer refund made successfully");
                        }
                        else
                        {
                            MessageBox.Show("Customer refund failed.");
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
            
            
        }
    }
}