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
    public partial class frmCommisionRates : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Commission Tax Rates";
        public frmCommisionRates()
        {
            InitializeComponent();
        }

        private void frmCommisionRates_Load(object sender, EventArgs e)
        {
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
            LoadGrid();
        }

        public void LoadGrid()
        {
            try
            {

                this.spSelectAllCommisionRatesTableAdapter.Fill(this.dsCommissionRates.spSelectAllCommisionRates, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
                ClearFields();
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
                this.spSelectAllCommisionRatesTableAdapter.Insert(
                    AppConstant.CompCode,
                   Convert.ToDecimal(FromAmountTextEdit.Text),
                    Convert.ToDecimal(ToAmountTextEdit.Text),
                    RateTypeComboBoxEdit.Text,
                     Convert.ToDouble(RateTextEdit.Text),
                     EffectiveDateDateEdit.DateTime,
                     Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Commission Rates saved successfully");
                this.spSelectAllCommisionRatesTableAdapter.Fill(this.dsCommissionRates.spSelectAllCommisionRates, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
        public void ClearFields()
        {
            try
            {
                FromAmountTextEdit.Text = "0";
                ToAmountTextEdit.Text = "0";
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
                FromAmountTextEdit.Enabled = false;
                ToAmountTextEdit.Enabled = false;
                RateTypeComboBoxEdit.Enabled = false;
                RateTextEdit.Enabled = false;
                EffectiveDateDateEdit.Enabled = false;
                // EffectiveDateDateEdit.Enabled = false;

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
                FromAmountTextEdit.Enabled = true;
                ToAmountTextEdit.Enabled = true;
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

                var FromAmount = Convert.ToDecimal(FromAmountTextEdit.EditValue);
                var ToAmount = Convert.ToDecimal(ToAmountTextEdit.Text);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete commission rate between  " + FromAmount+"to "+ ToAmount, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllCommisionRatesTableAdapter.Delete(AppConstant.CompCode, FromAmount, ToAmount, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllCommisionRatesTableAdapter.Fill(this.dsCommissionRates.spSelectAllCommisionRates, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
                }


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

                var FromAmount = Convert.ToDecimal(this.gridView1.GetFocusedRowCellValue("FromAmount"));
                var ToAmount = Convert.ToDecimal(this.gridView1.GetFocusedRowCellValue("ToAmount"));
                this.spSelectCommisionRatesTableAdapter.Fill(this.dsCommissionRates.spSelectCommisionRates, AppConstant.CompCode, FromAmount, ToAmount, AppConstant.UserID, Environment.MachineName);

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
                    SaveRecord();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Commission Tax Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (this.ValidateRight("Edit", AppConstant.UserID))
                {
                    EnableField();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Commission Tax Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Commission Tax Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
                    this.gridView1.ShowPrintPreview();
                }


                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Commission Tax Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                SelectRecord();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}