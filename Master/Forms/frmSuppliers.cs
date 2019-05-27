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
    public partial class Suppliers : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Suppliers";
        Security _Security = new Security();
        public Suppliers()
        {
            InitializeComponent();

        }
        public void disableFields()
        {

            SuppCodeTextEdit.Enabled = false;
            SuppNameTextEdit.Enabled = false;
            ServiceTypeTextEdit.Enabled = false;
            CostCenterLookUpEdit.Enabled = false;
            EmailTextEdit.Enabled = false;
            TelephoneTextEdit.Enabled = false;
            MobileTextEdit.Enabled = false;
            PostalAddressTextEdit.Enabled = false;
            PaymentTermsTextEdit.Enabled = false;
            CountryCodeLookUpEdit.Enabled = false;
            CurrencyLookUpEdit.Enabled = false;
            BankCodeLookUpEdit.Enabled = false;
            BranchCodeLookUpEdit.Enabled = false;
            BankAccNoTextEdit.Enabled = false;
            BusinessNoTextEdit.Enabled = false;

        }
        public void enableFields()
        {


            SuppNameTextEdit.Enabled = true;
            ServiceTypeTextEdit.Enabled = true;
            CostCenterLookUpEdit.Enabled = true;
            EmailTextEdit.Enabled = true;
            TelephoneTextEdit.Enabled = true;
            MobileTextEdit.Enabled = true;
            PostalAddressTextEdit.Enabled = true;
            PaymentTermsTextEdit.Enabled = true;
            CountryCodeLookUpEdit.Enabled = true;
            CurrencyLookUpEdit.Enabled = true;
            BankCodeLookUpEdit.Enabled = true;
            BranchCodeLookUpEdit.Enabled = true;
            BankAccNoTextEdit.Enabled = true;
            BusinessNoTextEdit.Enabled = true;

        }
        public void saveRecord()
        {
            try
            {
                String SuppCode = SuppCodeTextEdit.Text;
                String SuppName = SuppNameTextEdit.Text;
                String ServiceType = ServiceTypeTextEdit.EditValue.ToString();
                String CostCenter = CostCenterLookUpEdit.EditValue.ToString();
                String Email = EmailTextEdit.Text;
                String Telephone = TelephoneTextEdit.Text;
                string Mobile = MobileTextEdit.Text;
                string PostalAddress = PostalAddressTextEdit.Text;
                string PaymentTerms = PaymentTermsTextEdit.Text;
                string CountryCode = CountryCodeLookUpEdit.EditValue.ToString();
                string Currency = CurrencyLookUpEdit.EditValue.ToString();
                string BankCode = BankCodeLookUpEdit.EditValue.ToString();
                string BranchCode = BranchCodeLookUpEdit.EditValue.ToString();
                string BankAccNo = BankAccNoTextEdit.Text;
                string BusinessNo = BusinessNoTextEdit.Text;
                spSelectAllSupplierTableAdapter.Insert(AppConstant.CompCode, SuppCode, SuppName, ServiceType, CostCenter, Email, Telephone, Mobile, PostalAddress, PaymentTerms, CountryCode, Currency, BankCode, BranchCode, BankAccNo, BusinessNo, AppConstant.UserID, Environment.MachineName);
                MessageBox.Show("Supplier saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void ClearFields(){
             try
            {
                spgetUDCByCategoryTableAdapter.Fill(dsSuppliers.spgetUDCByCategory, "Service Types"); 
                spSelectAllSupplierTableAdapter.Fill(dsSuppliers.spSelectAllSupplier, AppConstant.CompCode);
                spGetCompanyCostCentersTableAdapter.Fill(dsSuppliers.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                spgetAllBanksTableAdapter.Fill(dsSuppliers.spgetAllBanks, AppConstant.CompCode, Environment.MachineName);
                spgetAllCountriesTableAdapter.Fill(dsSuppliers.spgetAllCountries, AppConstant.UserID, Environment.MachineName);
                spgetCurrenciesTableAdapter.Fill(dsSuppliers.spgetCurrencies, AppConstant.UserID, Environment.MachineName);
                CostCenterLookUpEdit.EditValue = dsSuppliers.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
        CountryCodeLookUpEdit.EditValue = dsSuppliers.spgetAllCountries.DataSet.Tables["spgetAllCountries"].Rows[0]["CountryCode"].ToString();
        CurrencyLookUpEdit.EditValue = dsSuppliers.spgetCurrencies.DataSet.Tables["spgetCurrencies"].Rows[0]["CurrCode"].ToString();
        MobileTextEdit.Text = "0";
                EmailTextEdit.Text = "0";
                TelephoneTextEdit.Text = "0";
                PaymentTermsTextEdit.Text = "30";
                BusinessNoTextEdit.Text = "0";
                PostalAddressTextEdit.Text = "0";
                SuppCodeTextEdit.Text = "0";
                //ServiceTypeTextEdit.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            }
        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            try
            {
                spgetUDCByCategoryTableAdapter.Fill(dsSuppliers.spgetUDCByCategory, "Service Types"); 
                spSelectAllSupplierTableAdapter.Fill(dsSuppliers.spSelectAllSupplier, AppConstant.CompCode);
                spGetCompanyCostCentersTableAdapter.Fill(dsSuppliers.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                spgetAllBanksTableAdapter.Fill(dsSuppliers.spgetAllBanks, AppConstant.CompCode, Environment.MachineName);
                spgetAllCountriesTableAdapter.Fill(dsSuppliers.spgetAllCountries, AppConstant.UserID, Environment.MachineName);
                spgetCurrenciesTableAdapter.Fill(dsSuppliers.spgetCurrencies, AppConstant.UserID, Environment.MachineName);
                CostCenterLookUpEdit.EditValue = dsSuppliers.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                CountryCodeLookUpEdit.EditValue = dsSuppliers.spgetAllCountries.DataSet.Tables["spgetAllCountries"].Rows[0]["CountryCode"].ToString();
                CurrencyLookUpEdit.EditValue = dsSuppliers.spgetCurrencies.DataSet.Tables["spgetCurrencies"].Rows[0]["CurrCode"].ToString();
                MobileTextEdit.Text = "0";
                EmailTextEdit.Text = "0";
                TelephoneTextEdit.Text = "0";
                PaymentTermsTextEdit.Text = "30";
                BusinessNoTextEdit.Text = "0";
                PostalAddressTextEdit.Text = "0";
                SuppCodeTextEdit.Text = "0";
                //ServiceTypeTextEdit.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BankCodeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spgetBankBranchesTableAdapter.Fill(dsSuppliers.spgetBankBranches, BankCodeLookUpEdit.EditValue.ToString());

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

                // var TableName = Convert.ToString(this.gridView1.GetFocusedRowCellValue("TableName"));
                var ItemCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("SuppCode"));

                spSelectSupplierTableAdapter.Fill(dsSuppliers.spSelectSupplier, AppConstant.CompCode, ItemCode);
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

        private void Submit_Click(object sender, EventArgs e)
        {
            enableFields();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                String supp = SuppCodeTextEdit.Text;
                spSelectAllSupplierTableAdapter.Delete(AppConstant.CompCode, supp);
                MessageBox.Show("Supplier deleted successfully");
                ClearFields();// spSelectAllSupplierTableAdapter.Fill(dsSuppliers.spSelectAllSupplier, AppConstant.CompCode);
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
                saveRecord();
                ClearFields();
                //spSelectAllSupplierTableAdapter.Fill(dsSuppliers.spSelectAllSupplier, AppConstant.CompCode);
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
    }
}