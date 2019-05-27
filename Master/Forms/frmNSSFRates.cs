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
    public partial class frmNSSFRates : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "NSSF Rates";
        public frmNSSFRates()
        {
            InitializeComponent();
            ////AppConstant.CompCode = "001";
            ////AppConstant.UserID = "info@citimax.co.ke";
        }

        private void frmNSSFRates_Load(object sender, EventArgs e)
        {
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
            LoadNssfRates();
        }
        public void LoadNssfRates()
        {
            try
            {

                this.spSelectAllNSSFRatesTableAdapter.Fill(this.dsNSSFRates.spSelectAllNSSFRates,AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
                ClearFields();
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
        public void SaveNssfRates()
        {
            try
            {
                this.spSelectAllNSSFRatesTableAdapter.Insert(
                   AppConstant.CompCode,
                   Convert.ToDecimal(LowerEarnLimitTextEdit.Text),
                   Convert.ToDecimal(UpperEarnLimitTextEdit.Text),
                   Convert.ToDouble(EmployeeRateTextEdit.Text),
                   Convert.ToDouble(EmployerRateTextEdit.Text),
                   RateTypeTextEdit.Text.ToString(),
                   Convert.ToDateTime(EffectiveDateDateEdit.DateTime),
                   
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Nssf rate saved successfully");
                this.spSelectAllNSSFRatesTableAdapter.Fill(this.dsNSSFRates.spSelectAllNSSFRates, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
                ClearFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void ClearFields()
        {
            try
            {
                LowerEarnLimitTextEdit.Text = "0";
                UpperEarnLimitTextEdit.Text = "0";
                EmployeeRateTextEdit.Text = "0";
                  EmployerRateTextEdit.Text = "0";
                RateTypeTextEdit.Text = "Amount";
                EffectiveDateDateEdit.DateTime = DateTime.Now;
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

                LowerEarnLimitTextEdit.Enabled = false;
                UpperEarnLimitTextEdit.Enabled = false;
                EmployeeRateTextEdit.Enabled = false;
                EmployerRateTextEdit.Enabled = false;
                RateTypeTextEdit.Enabled = false;
                EffectiveDateDateEdit.Enabled = false;
               
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
                LowerEarnLimitTextEdit.Enabled = true;
                UpperEarnLimitTextEdit.Enabled = true;
                EmployeeRateTextEdit.Enabled = true;
                EmployerRateTextEdit.Enabled = true;
                RateTypeTextEdit.Enabled = true;
                EffectiveDateDateEdit.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void DeleteRecord()
        {
            try
            {

                var LowerEarnLimit = Convert.ToDecimal(LowerEarnLimitTextEdit.Text);
                var EffectiveDate = Convert.ToDateTime(EffectiveDateDateEdit.DateTime);

                if (gridView1.SelectedRowsCount<0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete Nssf between " + LowerEarnLimit +" and "+UpperEarnLimitTextEdit.Text, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllNSSFRatesTableAdapter.Delete(AppConstant.CompCode, LowerEarnLimit, EffectiveDate, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllNSSFRatesTableAdapter.Fill(this.dsNSSFRates.spSelectAllNSSFRates, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void SelectNssfRates()
        {
            try
            {

                var LowerEarnLimit = Convert.ToDecimal(this.gridView1.GetFocusedRowCellValue("LowerEarnLimit"));
                var EffectiveDate = Convert.ToDateTime(this.gridView1.GetFocusedRowCellValue("EffectiveDate"));

                this.spSelectNSSFRatesTableAdapter.Fill(this.dsNSSFRates.spSelectNSSFRates, AppConstant.CompCode, LowerEarnLimit, EffectiveDate, AppConstant.UserID, Environment.MachineName);

                disableFields();
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
                    SaveNssfRates();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add NSSF Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Edit", AppConstant.UserID))
                {
                    EnableField();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit NSSF Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
                    DeleteRecord();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete NSSF Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Export", AppConstant.UserID))
                {
                    this.gridView1.ShowPrintPreview();
                }


                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export NSSF Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            SelectNssfRates();
        }
    }
}