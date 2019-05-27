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
    public partial class frmJournalEntry : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        
        string SecurityModule = "Journal Entry";
        public frmJournalEntry()
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
        private void frmJournalEntry_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("View", AppConstant.UserID))
                {
                    spGetCompanyCostCentersTableAdapter.Fill(dsJournalEntry.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                    spgetGlAccountsTableAdapter.Fill(dsJournalEntry.spgetGlAccounts, AppConstant.CompCode);
                    spgetledgersTableAdapter.Fill(dsJournalEntry.spgetledgers, AppConstant.CompCode);
                    LoadGrid();
                    txtAmount.Text = "0";
                    gldate.DateTime = DateTime.Now;
                    txtrefNo.Text = "0";
                    comboEntry.EditValue = "Credit";
                    memoEremarlks.Text = "New Journal transactions";
                    gloffset.EditValue = dsJournalEntry.spgetGlAccounts.DataSet.Tables["spgetGlAccounts"].Rows[0]["AccCode"].ToString();
                    glAcc.EditValue = dsJournalEntry.spgetGlAccounts.DataSet.Tables["spgetGlAccounts"].Rows[0]["AccCode"].ToString();
                    glLedger.EditValue = dsJournalEntry.spgetledgers.DataSet.Tables["spgetledgers"].Rows[0]["LedgerCode"].ToString();
                   gridcostcenter.EditValue = dsJournalEntry.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Journal Entry", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

              //  txtDocType.Enabled = false;
                glLedger.Enabled = false;
                gloffset.Enabled = false;
                glAcc.Enabled = false;
                txtrefNo.Enabled = false;
               // txtDebit.Enabled = false;
                memoEremarlks.Enabled = false;
                txtAmount.Enabled = false;
                gldate.Enabled = false;
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
               // txtDocType.Enabled = true;
                glLedger.Enabled = true;
                gloffset.Enabled = true;
                glAcc.Enabled = true;
                txtrefNo.Enabled = true;
              //  txtDebit.Enabled = true;
                memoEremarlks.Enabled = true;
                txtAmount.Enabled = true;
                gldate.Enabled = true;
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add journal transaction", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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

                this.spselectAllJournalEntriesTableAdapter.Fill(this.dsJournalEntry.spselectAllJournalEntries, AppConstant.CompCode, gridcostcenter.EditValue.ToString());
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void SaveRecord()
        {
            try
            {
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    Decimal credit = 0; Decimal Debit=0;
                    var Entry = comboEntry.Text;
                    if (Entry=="Credit")
                    {
                         credit = Convert.ToDecimal(txtAmount.Text);
                    }
                    else if (Entry == "Debit")
                    {
                         Debit = Convert.ToDecimal(txtAmount.Text);
                    }
                    this.spselectAllJournalEntriesTableAdapter.spSaveGeneralledgerBuffer(
                   AppConstant.CompCode,
                   gridcostcenter.EditValue.ToString(),
                   "0",
                   "JE",
                   gldate.DateTime,
                   glAcc.EditValue.ToString(),
                   gloffset.EditValue.ToString(),
                   glLedger.EditValue.ToString(),
                    Debit,
                     credit,                  
                   txtrefNo.Text,
                  memoEremarlks.Text,
                  AppConstant.UserID,
                    Environment.MachineName
                    
                    );
                    MessageBox.Show("Journal transaction saved successfully");
                    this.spselectAllJournalEntriesTableAdapter.Fill(this.dsJournalEntry.spselectAllJournalEntries, AppConstant.CompCode, gridcostcenter.EditValue.ToString());

                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add journal transaction", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                spselectAllJournalEntriesTableAdapter.spSaveGeneralledger(AppConstant.CompCode);
                MessageBox.Show("Upload Succesfull", "Upload Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.spselectAllJournalEntriesTableAdapter.Fill(this.dsJournalEntry.spselectAllJournalEntries, AppConstant.CompCode, gridcostcenter.EditValue.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}