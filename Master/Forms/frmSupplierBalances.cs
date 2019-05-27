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
    public partial class frmSupplierBalances : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Supplier Balance";
        public frmSupplierBalances()
        {
            InitializeComponent();
            //AppConstant.UserID = "info@citimax.co.ke";
            //AppConstant.CompCode = "001";
        }

        private void frmSupplierBalances_Load(object sender, EventArgs e)
        {
            try
            {
                spGetCompanyCostCentersTableAdapter.Fill(dsSupplierBalances.spGetCompanyCostCenters,AppConstant.CompCode, AppConstant.UserID);
                spgetCurrenciesTableAdapter.Fill(dsSupplierBalances.spgetCurrencies, AppConstant.UserID, Environment.MachineName);
                spGetSuppliersTableAdapter.Fill(dsSupplierBalances.spGetSuppliers, AppConstant.CompCode);
                BalanceDateDateEdit.DateTime = DateTime.Now;
                BalanceTextEdit.Text = "0";
                RemarksTextEdit.Text = "New Supplier Balance";
                CurrencyGridLookUpEdit.EditValue = "KES";
                CostCenterGridLookUpEdit.EditValue = dsSupplierBalances.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                SuppCodeGridLookUpEdit.EditValue = dsSupplierBalances.spGetSuppliers.DataSet.Tables["spGetSuppliers"].Rows[0]["Supplier Code"].ToString();
                LoadGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void clearfields()
        {
            try
            {
                BalanceDateDateEdit.DateTime = DateTime.Now;
                BalanceTextEdit.Text = "0";
                RemarksTextEdit.Text = "New Supplier Balance";
                CurrencyGridLookUpEdit.EditValue = "KES";
                CostCenterGridLookUpEdit.EditValue = dsSupplierBalances.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                SuppCodeGridLookUpEdit.EditValue = dsSupplierBalances.spGetSuppliers.DataSet.Tables["spGetSuppliers"].Rows[0]["Supplier Code"].ToString();
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
                spSelectAllSupplierBalanceTableAdapter.Fill(dsSupplierBalances.spSelectAllSupplierBalance, AppConstant.CompCode);
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
                    this.gridView3.ShowPrintPreview();
                }


                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Supplier Balance", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
        public void SaveRecord()
        {
            try
            {
                if(Convert.ToDecimal(BalanceTextEdit.Text)>0)
                {
                    if (ReferenceTextEdit.Text == "" || ReferenceTextEdit.Text == null)
                    {
                        MessageBox.Show("Enter Reference to Continue");
                        return;
                    }
                    if (RemarksTextEdit.Text == "" || RemarksTextEdit.Text == null)
                    {
                        MessageBox.Show("Enter Remarks to Continue");
                        return;
                    }
                    if (CurrencyGridLookUpEdit.EditValue.ToString() == "" || CurrencyGridLookUpEdit.EditValue.ToString() == null)
                    {
                        MessageBox.Show("Select Currency to Continue");
                        return;
                    }
                    if (SuppCodeGridLookUpEdit.EditValue.ToString() == "" || SuppCodeGridLookUpEdit.EditValue.ToString() == null)
                    {
                        MessageBox.Show("Select Supplier to Continue");
                        return;
                    }
                    this.spSelectAllSupplierBalanceTableAdapter.Insert(
                   AppConstant.CompCode,
                   CostCenterGridLookUpEdit.EditValue.ToString(),
                   SuppCodeGridLookUpEdit.EditValue.ToString(),
                   Convert.ToDecimal(BalanceTextEdit.Text),
                   CurrencyGridLookUpEdit.EditValue.ToString(),
                   BalanceDateDateEdit.DateTime,
                   ReferenceTextEdit.Text,
                   RemarksTextEdit.Text,
                   AppConstant.UserID,
                   Environment.MachineName);
                    MessageBox.Show("Supplier Balance saved successfully");
                    LoadGrid();
                    clearfields();
                }
                else
                {
                    MessageBox.Show(" Balance should be more than Zero(0) with a unique refference");
                }
               
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Supplier Balance", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}