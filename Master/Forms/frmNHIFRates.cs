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
    public partial class frmNHIFRates : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "NHIF Rates";
        public frmNHIFRates()
        {
            InitializeComponent();
        }

        private void frmNHIFRates_Load(object sender, EventArgs e)
        {
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
            LoadNssfRates();
        }
        public void LoadNssfRates()
        {
            try
            {

                this.spSelectAllNHIFRatesTableAdapter.Fill(this.dsNHIFRates.spSelectAllNHIFRates, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
        public void SaveNhifRates()
        {
            try
            {
                this.spSelectAllNHIFRatesTableAdapter.Insert(
                   AppConstant.CompCode,
                   Convert.ToDecimal(FromSalaryTextEdit.Text),
                   Convert.ToDecimal(ToSalaryTextEdit.Text),
                   Convert.ToString(RateTypeComboBoxEdit.Text),
                   Convert.ToDouble(RateTextEdit.Text),
                   EffectiveDateDateEdit.DateTime,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Nhif Rates saved successfully");
                this.spSelectAllNHIFRatesTableAdapter.Fill(this.dsNHIFRates.spSelectAllNHIFRates, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
                FromSalaryTextEdit.Text = "0";
                ToSalaryTextEdit.Text = "0";
                RateTypeComboBoxEdit.Text = "Amount";
                RateTextEdit.Text = "0";
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

                FromSalaryTextEdit.Enabled = false;
                ToSalaryTextEdit.Enabled = false;
                RateTypeComboBoxEdit.Enabled = false;
                RateTextEdit.Enabled = false;
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
                FromSalaryTextEdit.Enabled = true;
                ToSalaryTextEdit.Enabled = true;
                RateTypeComboBoxEdit.Enabled = true;
                RateTextEdit.Enabled = true;
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

                var FromSalary = Convert.ToDecimal(FromSalaryTextEdit.Text);
                var EffectiveDate = Convert.ToDateTime(EffectiveDateDateEdit.DateTime);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete NHIF from " + FromSalary + " and " + EffectiveDate, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllNHIFRatesTableAdapter.Delete(AppConstant.CompCode, FromSalary, EffectiveDate, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                     this.spSelectAllNHIFRatesTableAdapter.Fill(this.dsNHIFRates.spSelectAllNHIFRates, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void SelectNhiffRates()
        {
            try
            {

                var FromSalary = Convert.ToDecimal(this.gridView1.GetFocusedRowCellValue("FromSalary"));
                var EffectiveDate = Convert.ToDateTime(this.gridView1.GetFocusedRowCellValue("EffectiveDate"));

                this.spSelectNHIFRatesTableAdapter.Fill(this.dsNHIFRates.spSelectNHIFRates, AppConstant.CompCode, FromSalary, EffectiveDate, AppConstant.UserID, Environment.MachineName);

                disableFields();
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
                    SaveNhifRates();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add NHIF Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit NHIF Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Delete", AppConstant.UserID))
            {
                DeleteRecord();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to delete NHIF Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export NHIF Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                SelectNhiffRates();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}