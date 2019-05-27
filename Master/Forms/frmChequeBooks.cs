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
    public partial class frmChequeBooks : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Cheque Books";
        Security _Security = new Security();
        public frmChequeBooks()
        {
            InitializeComponent();
            AppConstant.CompCode = "001";
            AppConstant.UserID = "info@citimax.co.ke";
        }
        public void disableFields()
        {


            CostCenterGridLookUpEdit.Enabled = false;
            CountryCodeGridLookUpEdit.Enabled = false;
            BankCodeGridLookUpEdit.Enabled = false;
            BranchCodeGridLookUpEdit.Enabled = false;
            AccNumberTextEdit.Enabled = false;
            AccNameTextEdit.Enabled = false;
            ChequeBookNoTextEdit.Enabled = false;
            FirstChequeTextEdit.Enabled = false;
            LastChequeTextEdit.Enabled = false;
            DateIssuedDateEdit.Enabled = false;

        }
        public void clearFields()
        {

           
            BankCodeGridLookUpEdit.EditValue = " " ;
            BranchCodeGridLookUpEdit.Enabled = true;
            AccNumberTextEdit.Text = " ";
            AccNameTextEdit.Text = " ";
            ChequeBookNoTextEdit.Text = " ";
            FirstChequeTextEdit.Text = " ";
            LastChequeTextEdit.Text = " ";
            DateIssuedDateEdit.Text = " ";

        }
        public void enableFields()
        {

            
            CostCenterGridLookUpEdit.Enabled = true;
            CountryCodeGridLookUpEdit.Enabled = true;
            BankCodeGridLookUpEdit.Enabled = true;
            BranchCodeGridLookUpEdit.Enabled = true;
            AccNumberTextEdit.Enabled = true;
            AccNameTextEdit.Enabled = true;
            ChequeBookNoTextEdit.Enabled = true;
            FirstChequeTextEdit.Enabled = true;
            LastChequeTextEdit.Enabled = true;
            DateIssuedDateEdit.Enabled = true;

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
        private void frmChequeBooks_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGrid();
                spgetAllBanksTableAdapter.Fill(dsChequeBooks.spgetAllBanks, AppConstant.UserID, Environment.MachineName);
                spGetCompanyCostCentersTableAdapter.Fill(dsChequeBooks.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                spgetAllCountriesTableAdapter.Fill(dsChequeBooks.spgetAllCountries, AppConstant.UserID, Environment.MachineName);
                CostCenterGridLookUpEdit.EditValue = dsChequeBooks.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                DateIssuedDateEdit.DateTime = DateTime.Now;
                CountryCodeGridLookUpEdit.EditValue=dsChequeBooks.spgetAllCountries.DataSet.Tables["spgetAllCountries"].Rows[0]["CountryCode"].ToString();
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
                spSelectAllChequeBooksTableAdapter.Fill(dsChequeBooks.spSelectAllChequeBooks, AppConstant.CompCode);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("Privilege Violation.You have insufficient right to Export Cheque Book", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try { 
            if (this.ValidateRight("Delete", AppConstant.UserID))
            {
                    string Costcenter = CostCenterGridLookUpEdit.EditValue.ToString();
                
                    string BranchCode = BranchCodeGridLookUpEdit.EditValue.ToString();
                 
                    string chequebookNo = ChequeBookNoTextEdit.Text;
                    if (BranchCode == "")
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to Cheque Book " + chequebookNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                        spSelectAllChequeBooksTableAdapter.Delete(AppConstant.CompCode, Costcenter, BranchCode, chequebookNo);
                    MessageBox.Show("Record deleted successfully");
                        LoadGrid();
                }

            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to delete Cheque Book", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Add", AppConstant.UserID))
            {
                try
                {
                    string Costcenter = CostCenterGridLookUpEdit.EditValue.ToString();
                  string CountryCode= CountryCodeGridLookUpEdit.EditValue.ToString();
                    string BankCode = BankCodeGridLookUpEdit.EditValue.ToString();
                    string BranchCode= BranchCodeGridLookUpEdit.EditValue.ToString();
                    string accountNo = AccNumberTextEdit.Text;
                    string accName = AccNameTextEdit.Text;
                    string chequebookNo = ChequeBookNoTextEdit.Text;
                        int First = Convert.ToInt16(FirstChequeTextEdit.Text);
                    int Last = Convert.ToInt16(LastChequeTextEdit.Text);
                    DateTime dateIsued = DateIssuedDateEdit.DateTime;
                    spSelectAllChequeBooksTableAdapter.Insert(AppConstant.CompCode, CountryCode, Costcenter, BankCode, BranchCode, accountNo, accName, chequebookNo, First, Last, dateIsued, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Cheque Book Saved Succesfully");
                    LoadGrid();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Cheque Book" + " has already been added");
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
                MessageBox.Show("Privilege Violation.You have insufficient right to Add Cheque Book", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void selectrecord()
        {
            try
            {
                var CostCenter = Convert.ToString(this.gridView4.GetFocusedRowCellValue("CostCenter"));
                var BranchCode = Convert.ToString(this.gridView4.GetFocusedRowCellValue("BranchCode"));
                var ChequeBookNo = Convert.ToString(this.gridView4.GetFocusedRowCellValue("ChequeBookNo"));
                spSelectChequeBooksTableAdapter.Fill(dsChequeBooks.spSelectChequeBooks, AppConstant.CompCode, CostCenter, BranchCode, ChequeBookNo);
                disableFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void BankCodeGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string BankCode = BankCodeGridLookUpEdit.EditValue.ToString();
                spgetBankBranchesTableAdapter.Fill(dsChequeBooks.spgetBankBranches, BankCode);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            selectrecord();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            enableFields();
        }
    }
}