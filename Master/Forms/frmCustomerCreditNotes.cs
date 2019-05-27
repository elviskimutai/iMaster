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
    public partial class frmCustomerCreditNotes : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Customer Credit Notes";
        Security _Security = new Security();
        public frmCustomerCreditNotes()
        {
            InitializeComponent();
           
        }

        private void frmCustomerCreditNotes_Load(object sender, EventArgs e)
        {
            try
            {
                AppConstant.CompCode = "001";
                AppConstant.UserID = "info@citimax.co.ke";
              
                this.spGetCompanyCostCentersTableAdapter.Fill(dsCustomerCreditNotes.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                this.spGetCustomersTableAdapter.Fill(dsCustomerCreditNotes.spGetCustomers, AppConstant.CompCode);

              LoadGrid();
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
                this.spselectAllCustomerCrediNotesTableAdapter.Fill(dsCustomerCreditNotes.spselectAllCustomerCrediNotes, AppConstant.CompCode);
                RemarksTextEdit.Text = "New Customer Credit Note";
                
                CostCenterGridLookUpEdit.EditValue = dsCustomerCreditNotes.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                CustCodeGridLookUpEdit.EditValue = dsCustomerCreditNotes.spGetCustomers.DataSet.Tables["spGetCustomers"].Rows[0]["CustCode"].ToString();
               // GLAccountTextEdit.EditValue = dsPayOuts.spgetGlAccounts.DataSet.Tables["spgetGlAccounts"].Rows[0]["AccCode"].ToString();
                DocNoTextEdit.Enabled = false;
                DocNoTextEdit.Text = "0";
               ExtendedCostTextEdit.Text = "0";
                ExtendedCostTextEdit.Enabled = false;
                QtyTextEdit.Text = "0";
                UnitCostTextEdit.Text = "0";
                String customer = CustCodeGridLookUpEdit.EditValue.ToString();
                this.spgetCustomerInvoiceTableAdapter.Fill(dsCustomerCreditNotes.spgetCustomerInvoice, customer);
                Invoicegl.EditValue = dsCustomerCreditNotes.spgetCustomerInvoice.DataSet.Tables["spgetCustomerInvoice"].Rows[0]["InvoiceNo"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CustCodeGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                String customer = CustCodeGridLookUpEdit.EditValue.ToString();
                this.spgetCustomerInvoiceTableAdapter.Fill(dsCustomerCreditNotes.spgetCustomerInvoice, customer);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void Invoicegl_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.spgetCustomerInvoiceItemsTableAdapter.Fill(dsCustomerCreditNotes.spgetCustomerInvoiceItems, Invoicegl.EditValue.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ItemDescriptionGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               var Qty = Convert.ToString(this.gridView2.GetFocusedRowCellValue("Qty"));
                var UnitCost = Convert.ToString(this.gridView2.GetFocusedRowCellValue("UnitCost"));
                UnitCostTextEdit.Text = UnitCost;
             }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }

        private void QtyTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
              Decimal Extended= (Convert.ToDecimal(UnitCostTextEdit.Text) * Convert.ToDecimal(QtyTextEdit.Text));
                ExtendedCostTextEdit.Text = Extended.ToString();
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
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
                    var Qty = Convert.ToString(this.gridView2.GetFocusedRowCellValue("Qty"));
                    var UnitCost = Convert.ToString(this.gridView2.GetFocusedRowCellValue("UnitCost"));
                    
                    if (Convert.ToDecimal(Qty) < Convert.ToDecimal(QtyTextEdit.Text))
                    {
                        MessageBox.Show("Qty can not be more than invoiced  qty of: "+ Qty);
                        return;
                    }
                    if (Convert.ToDecimal(UnitCost) < Convert.ToDecimal(UnitCostTextEdit.Text))
                    {
                        MessageBox.Show("UnitCost can not be more than invoiced  UnitCost of: " + UnitCost);
                        return;
                    }
                    if (RemarksTextEdit.Text == "" || RemarksTextEdit.Text == null)
                    {
                        MessageBox.Show("Enter Remarks to Continue");
                        return;
                    }
                    this.spselectAllCustomerCrediNotesTableAdapter.Insert(AppConstant.CompCode, CostCenterGridLookUpEdit.EditValue.ToString(), DocNoTextEdit.Text, Invoicegl.EditValue.ToString(), ItemDescriptionGridLookUpEdit.EditValue.ToString(), Convert.ToDouble(QtyTextEdit.Text), Convert.ToDecimal(UnitCostTextEdit.Text), RemarksTextEdit.Text, CustCodeGridLookUpEdit.EditValue.ToString(), AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Customer Credit Note Saved Succesfully");
                    LoadGrid();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to add Customer Credit Notes", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Privilege Violation.You have insufficient right to Export Item Matser", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void enableFields()
        {
            try
            {
                CustCodeGridLookUpEdit.Enabled = true;
                Invoicegl.Enabled = true;
                QtyTextEdit.Enabled = true;
                UnitCostTextEdit.Enabled = true;
                CostCenterGridLookUpEdit.Enabled = true;
                ItemDescriptionGridLookUpEdit.Enabled = true;
                RemarksTextEdit.Enabled = true;

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
                CustCodeGridLookUpEdit.Enabled = false;
                Invoicegl.Enabled = false;
                QtyTextEdit.Enabled = false;
                UnitCostTextEdit.Enabled = false;
                CostCenterGridLookUpEdit.Enabled = false;
                ItemDescriptionGridLookUpEdit.Enabled = false;
                RemarksTextEdit.Enabled = false;

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
               
                var DocNo = Convert.ToString(this.gridView4.GetFocusedRowCellValue("DocNo"));
                var CustCode = Convert.ToString(this.gridView4.GetFocusedRowCellValue("CustCode"));
                this.spselectCustomerCrediNotesTableAdapter.Fill(dsCustomerCreditNotes.spselectCustomerCrediNotes, AppConstant.CompCode, DocNo, CustCode);
                disableFields();
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
                    var DocNo = Convert.ToString(DocNoTextEdit.EditValue);
                    var CustCode = Convert.ToString(CustCodeGridLookUpEdit.EditValue);
                 
                    if (gridView4.SelectedRowsCount < 0)
                    {
                        MessageBox.Show("select a record to delete");
                        return;
                    }

                    if (MessageBox.Show("Do you want to delete Credit Note " + DocNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {

                    }
                    else
                    {
                        this.spselectAllCustomerCrediNotesTableAdapter.Delete(AppConstant.CompCode, DocNo, CustCode);
                        MessageBox.Show("Record deleted successfully");
                        LoadGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Approvers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                enableFields();
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