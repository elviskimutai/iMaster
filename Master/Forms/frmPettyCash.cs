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
    public partial class frmPettyCash : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Petty Cash";
        Security _Security = new Security();
        public frmPettyCash()
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
        public void disableFields()
        {
            try
            {
                CostCenterGridLookUpEdit.Enabled = false;
                DocNoTextEdit.Enabled = false;
                DateDateEdit.Enabled = false;
                BankAccountGridLookUpEdit.Enabled = false;
                GLAccountGridLookUpEdit.Enabled = false;
                SubLedgerGridLookUpEdit.Enabled = false;
                AmountTextEdit.Enabled = false;
                ReferenceNoTextEdit.Enabled = false;
                NarrationTextEdit.Enabled = false;



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
                DocNoTextEdit.Enabled = true;
                DateDateEdit.Enabled = true;
                BankAccountGridLookUpEdit.Enabled = true;
                GLAccountGridLookUpEdit.Enabled = true;
                SubLedgerGridLookUpEdit.Enabled = true;
               AmountTextEdit.Enabled = true;
                ReferenceNoTextEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void frmPettyCash_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPettyCash.spGetAssetAccounts' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'dsPettyCash.spGetExpenseAccounts' table. You can move, or remove it, as needed.

            try
            {
                loadGrid();
                spgetledgersTableAdapter.Fill(dsPettyCash.spgetledgers, AppConstant.CompCode);
                this.spGetExpenseAccountsTableAdapter.Fill(this.dsPettyCash.spGetExpenseAccounts);
                spGetExpenseAccountsTableAdapter.Fill(dsPettyCash.spGetExpenseAccounts);
                spGetCompanyCostCentersTableAdapter.Fill(dsPettyCash.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                this.spGetAssetAccountsTableAdapter.Fill(this.dsPettyCash.spGetAssetAccounts);
                DateDateEdit.DateTime = DateTime.Now;
                DocNoTextEdit.Text = "0";
                CostCenterGridLookUpEdit.EditValue = dsPettyCash.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                NarrationTextEdit.Text = "New Petty Cash";
                AmountTextEdit.Text = "0";
                ReferenceNoTextEdit.Text = "0";
                GLAccountGridLookUpEdit.EditValue = dsPettyCash.spGetExpenseAccounts.DataSet.Tables["spGetExpenseAccounts"].Rows[0]["AccCode"].ToString();
                SubLedgerGridLookUpEdit.EditValue = dsPettyCash.spgetledgers.DataSet.Tables["spgetledgers"].Rows[0]["LedgerCode"].ToString();



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadGrid()
        {
            try
            {
                spSelectAllPettyCashTableAdapter.Fill(dsPettyCash.spSelectAllPettyCash, AppConstant.CompCode);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ClearFields()
        {
            try
            {
                CostCenterGridLookUpEdit.EditValue = "";
                 DocNoTextEdit.Text="0";
                DateDateEdit.DateTime = DateTime.Now;
                AmountTextEdit.Text = "0";
                ReferenceNoTextEdit.Text="0";
                
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
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    spSelectAllPettyCashTableAdapter.Insert(AppConstant.CompCode, CostCenterGridLookUpEdit.EditValue.ToString(), DocNoTextEdit.Text, DateDateEdit.DateTime, BankAccountGridLookUpEdit.EditValue.ToString(), GLAccountGridLookUpEdit.EditValue.ToString(), SubLedgerGridLookUpEdit.EditValue.ToString(), Convert.ToDecimal(AmountTextEdit.Text), ReferenceNoTextEdit.Text, NarrationTextEdit.Text, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Petty cash saved successfully");
                    loadGrid();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Petty Cash", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Delete", AppConstant.UserID))
                {
                    var CompCode = Convert.ToString(DocNoTextEdit.Text);
                    //  var UserID = Convert.ToString(UserNameTextEdit.Text);
                    if (CompCode == "")
                    {
                        MessageBox.Show("select a record to delete");
                        return;
                    }

                    if (MessageBox.Show("Do you want to petty cash with Doc No " + CompCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {

                    }
                    else
                    {
                        spSelectAllPettyCashTableAdapter.Delete(AppConstant.CompCode, CostCenterGridLookUpEdit.EditValue.ToString(), DocNoTextEdit.Text);
                        MessageBox.Show("Record deleted successfully");
                        loadGrid();
                    }

                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Petty Cash", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
                disableFields();
            var CostCenter = Convert.ToString(this.gridView4.GetFocusedRowCellValue("CostCenter"));

            var DocNo = Convert.ToString(this.gridView4.GetFocusedRowCellValue("DocNo"));
            spSelectPettyCashTableAdapter.Fill(dsPettyCash.spSelectPettyCash, AppConstant.CompCode, CostCenter, DocNo);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Edit", AppConstant.UserID))
            {
                EnableField();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Edit Petty Cash", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Export", AppConstant.UserID))
            {
                gridView4.ShowPrintPreview();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Export Petty Cash", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}