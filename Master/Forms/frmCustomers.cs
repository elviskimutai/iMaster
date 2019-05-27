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
    public partial class frmCustomers : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Customers";
        Security _Security = new Security();
        public frmCustomers()
        {
            InitializeComponent();
           
        }
        public void LoadGrid()
        {
            try
            {
                spSelectAllCustomersTableAdapter.Fill(dsCustomers.spSelectAllCustomers, AppConstant.UserID, Environment.MachineName);
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

                CostCenterGridLookUpEdit.Enabled = false;
                CountryGridLookUpEdit.Enabled = false;
                CustCodeTextEdit.Enabled = false;
                CustNameTextEdit.Enabled = false;
                PhysicalAddressTextEdit.Enabled = false;
                PostalAddressTextEdit.Enabled = false;
                EmailTextEdit.Enabled = false;
                PaymentTermsTextEdit.Enabled = false;
                TelephoneTextEdit.Enabled = false;
                WebURLTextEdit.Enabled = false;
                MobileTextEdit.Enabled = false;
                FaxTextEdit.Enabled = false;
                PINNOTextEdit.Enabled = false;
                FaxTextEdit.Enabled = false;
                CustomerSinceDateEdit.Enabled = false;
                CustStatusComboBoxEdit.Enabled = false;

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
                 CostCenterGridLookUpEdit.Enabled = true;
                CountryGridLookUpEdit.Enabled = true;
                CustCodeTextEdit.Enabled = true;
                CustNameTextEdit.Enabled = true;
                PhysicalAddressTextEdit.Enabled = true;
                PostalAddressTextEdit.Enabled = true;
                EmailTextEdit.Enabled = true;
                PaymentTermsTextEdit.Enabled = true;
                TelephoneTextEdit.Enabled = true;
                WebURLTextEdit.Enabled = true;
                MobileTextEdit.Enabled = true;
                FaxTextEdit.Enabled = true;
                PINNOTextEdit.Enabled = true;
                FaxTextEdit.Enabled = true;
                CustomerSinceDateEdit.Enabled = true;
                CustStatusComboBoxEdit.Enabled = true;

                //SafetyStockTextEdit.Enabled = true;

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

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGrid();
                spgetAllCountriesTableAdapter.Fill(dsCustomers.spgetAllCountries, AppConstant.UserID, Environment.MachineName);
                spGetCompanyCostCentersTableAdapter.Fill(dsCustomers.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                CostCenterGridLookUpEdit.EditValue = dsCustomers.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                CountryGridLookUpEdit.EditValue = dsCustomers.spgetAllCountries.DataSet.Tables["spgetAllCountries"].Rows[0]["CountryCode"].ToString();
                CustCodeTextEdit.Text = "0";
                CustCodeTextEdit.Enabled = false;
                CustomerSinceDateEdit.DateTime = DateTime.Now;
                CustCodeTextEdit.Text = "0";
                EmailTextEdit.Text = "email@email.com";
                MobileTextEdit.Text = "0";
                TelephoneTextEdit.Text = "0";
                PostalAddressTextEdit.Text = "0";
                PhysicalAddressTextEdit.Text = "0";
                IDNOTextEdit.Text = "0";
                CustStatusComboBoxEdit.SelectedItem = "Active";
            }
            catch (Exception)
            {

               
            }
        }
        public void clearfields()
        {
            try
            {
                LoadGrid();
                spgetAllCountriesTableAdapter.Fill(dsCustomers.spgetAllCountries, AppConstant.UserID, Environment.MachineName);
                spGetCompanyCostCentersTableAdapter.Fill(dsCustomers.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                CostCenterGridLookUpEdit.EditValue = dsCustomers.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                CountryGridLookUpEdit.EditValue = dsCustomers.spgetAllCountries.DataSet.Tables["spgetAllCountries"].Rows[0]["CountryCode"].ToString();
                CustCodeTextEdit.Text = "0";
                CustCodeTextEdit.Enabled = false;
                CustomerSinceDateEdit.DateTime = DateTime.Now;
                CustCodeTextEdit.Text = "0";
                EmailTextEdit.Text = "email@email.com";
                MobileTextEdit.Text = "0";
                TelephoneTextEdit.Text = "0";
                PostalAddressTextEdit.Text = "0";
                PhysicalAddressTextEdit.Text = "0";
                IDNOTextEdit.Text = "0";
                CustStatusComboBoxEdit.SelectedItem = "Active";
            }
            catch (Exception)
            {


            }
        }
        public void SelectRecord()
        {
            try
            {

                // var TableName = Convert.ToString(this.gridView1.GetFocusedRowCellValue("TableName"));
                var ItemCode = Convert.ToString(this.gridView2.GetFocusedRowCellValue("CustCode"));

                spSelectCustomersTableAdapter.Fill(dsCustomers.spSelectCustomers, ItemCode, AppConstant.UserID, Environment.MachineName);
                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
                MessageBox.Show("Privilege Violation.You have insufficient right to Edit Customers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Delete", AppConstant.UserID))
            {
                String RepNo = CustCodeTextEdit.Text;
                spSelectAllCustomersTableAdapter.Delete(RepNo, AppConstant.UserID, Environment.MachineName);
                MessageBox.Show("Sales Rep Deleted Succesfully");
                LoadGrid();
                clearfields();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Delete Customer", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Export", AppConstant.UserID))
            {

                gridView2.ShowPrintPreview();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to  Export Customers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            SelectRecord();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Add", AppConstant.UserID))
            {
                try
                {
                    string CostCenter = CostCenterGridLookUpEdit.EditValue.ToString();
                    if (CostCenter == "" || CostCenter == null)
                    {
                        MessageBox.Show("Select CostCenter to Continue");
                        return;
                    }
                    string Country = CountryGridLookUpEdit.EditValue.ToString();
                    if (Country == "" || Country == null)
                    {
                        MessageBox.Show("Select Country to Continue");
                        return;
                    }
                    string CustCode = CustCodeTextEdit.Text;
                    if (CustCode == "" || CustCode == null)
                    {
                        MessageBox.Show("Enter CustCode to Continue");
                        return;
                    }
                    string CustName = CustNameTextEdit.Text;
                    if (CustName == "" || CustName == null)
                    {
                        MessageBox.Show("Enter CustName to Continue");
                        return;
                    }
                    string PhysicalAddress = PhysicalAddressTextEdit.Text;
                    if (PhysicalAddress == "" || PhysicalAddress == null)
                    {
                        MessageBox.Show("Enter PhysicalAddress to Continue");
                        return;
                    }
                    string PostalAddress = PostalAddressTextEdit.Text;
                    if (PostalAddress == "" || PostalAddress == null)
                    {
                        MessageBox.Show("Enter PostalAddress to Continue");
                        return;
                    }
                    string Email = EmailTextEdit.Text;
                    if (Email == "" || Email == null)
                    {
                        MessageBox.Show("Enter Email to Continue");
                        return;
                    }
                    string PaymentTerms = PaymentTermsTextEdit.Text;
                    if (PaymentTerms == "" || PaymentTerms == null)
                    {
                        MessageBox.Show("Enter PaymentTerms to Continue");
                        return;
                    }
                    string Telephone = TelephoneTextEdit.Text;
                    if (Telephone == "" || Telephone == null)
                    {
                        MessageBox.Show("Enter Telephone to Continue");
                        return;
                    }
                    string WebURL = WebURLTextEdit.Text;
                    if (WebURL == "" || WebURL == null)
                    {
                        MessageBox.Show("Enter WebURL to Continue");
                        return;
                    }
                    string Mobile = MobileTextEdit.Text;
                    if (Mobile == "" || Mobile == null)
                    {
                        MessageBox.Show("Enter Mobile to Continue");
                        return;
                    }
                    string Fax = FaxTextEdit.Text;
                    if (Fax == "" || Fax == null)
                    {
                        MessageBox.Show("Enter Fax to Continue");
                        return;
                    }
                    string PINNO = PINNOTextEdit.Text;
                    if (PINNO == "" || PINNO == null)
                    {
                        MessageBox.Show("Enter PINNO to Continue");
                        return;
                    }
                    string IDNO = FaxTextEdit.Text;
                    if (IDNO == "" || IDNO == null)
                    {
                        MessageBox.Show("Enter IDNO to Continue");
                        return;
                    }
                    DateTime CustomerSince = CustomerSinceDateEdit.DateTime;
                    if (CustomerSince == null)
                    {
                        MessageBox.Show("Enter CustomerSince to Continue");
                        return;
                    }
                    string CustStatus = CustStatusComboBoxEdit.SelectedItem.ToString();
                    if (CustStatus == "" || CustStatus == null)
                    {
                        MessageBox.Show("Enter Status to Continue");
                        return;
                    }
                    spSelectAllCustomersTableAdapter.Insert(CustCode, CustName, PaymentTerms, Email, Mobile, Telephone, WebURL, Fax, PhysicalAddress, PostalAddress, AppConstant.CompCode, CostCenter, PINNO, CustStatus, Country, CustomerSince, IDNO, CustomerSince, Environment.MachineName, AppConstant.UserID);
                    MessageBox.Show("Customer Saved Succesfully");
                    LoadGrid();
                    clearfields();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Customer " + CustNameTextEdit.Text + " has already been added");
                    }
                    else
                    {

                        MessageBox.Show("Error while saving record");
                        MessageBox.Show(ex.Message);
                    }


                }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Add Sales Reps", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}