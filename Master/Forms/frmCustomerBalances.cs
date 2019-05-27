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
    public partial class frmCustomerBalances : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Customer Balance";
        public frmCustomerBalances()
        {
            InitializeComponent();
            
        }

        private void frmCustomerBalances_Load(object sender, EventArgs e)
        {
            try
            {
                spGetCompanyCostCentersTableAdapter.Fill(dsCustomerBalances.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                spGetCustomersTableAdapter.Fill(dsCustomerBalances.spGetCustomers, AppConstant.CompCode);
                FillGrid();
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
                if (Convert.ToDecimal(BalanceTextEdit.Text) > 0)
                {
                    if (RemarksTextEdit.Text == "" || RemarksTextEdit.Text == null)
                    {
                        MessageBox.Show("Enter Remarks to Continue");
                        return;
                    }
                  
                    this.spSelectAllCustomerBalancesTableAdapter.Insert(AppConstant.CompCode, CostCenterTextEdit.EditValue.ToString(),CustCodeTextEdit.EditValue.ToString(), Convert.ToDecimal(BalanceTextEdit.Text), BalanceDateDateEdit.DateTime, RemarksTextEdit.Text, AppConstant.UserID, Environment.MachineName);

                    MessageBox.Show("Customer Balance saved successfully");
                    FillGrid();


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
        public void FillGrid()
        {
            try
            {
                spSelectAllCustomerBalancesTableAdapter.Fill(dsCustomerBalances.spSelectAllCustomerBalances, AppConstant.CompCode);
                BalanceDateDateEdit.DateTime = DateTime.Now;
               
                BalanceTextEdit.Text = "0";
                RemarksTextEdit.Text = "New Customer Balance";
                CostCenterTextEdit.EditValue = dsCustomerBalances.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["cccode"].ToString();
                CustCodeTextEdit.EditValue = dsCustomerBalances.spGetCustomers.DataSet.Tables["spGetCustomers"].Rows[0]["CustCode"].ToString();
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Customer Balance", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}