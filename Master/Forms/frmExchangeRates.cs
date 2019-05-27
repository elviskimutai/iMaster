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
    public partial class frmExchangeRates : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Exchange rates";
        public frmExchangeRates()
        {
            InitializeComponent();
            AppConstant.CompCode = "001";
            AppConstant.UserID = "steve@live.com";
        }

        private void frmExchangeRates_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsExchangeRates.Currencies' table. You can move, or remove it, as needed.
            this.currenciesTableAdapter.Fill(this.dsExchangeRates.Currencies);
            LoadGrid();
        }

        public void LoadGrid()
        {
            try
            {

                this.spSelectAllExchangeRatesTableAdapter.Fill(this.dsExchangeRates.spSelectAllExchangeRates, AppConstant.UserID, Environment.MachineName);
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
        public void SaveRecord()
        {
            try
            {

                this.spSelectAllExchangeRatesTableAdapter.Insert(
                    FromCurrTextEdit.EditValue.ToString(),
                    ToCurrTextEdit.EditValue.ToString(),
                   Convert.ToDouble(MultiplierTextEdit.Text),
                   Convert.ToDouble(DivisorTextEdit.Text),
                   EffectiveDateDateEdit.DateTime,
                    NarrationTextEdit.Text,

                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Exchange rates saved successfully");
                LoadGrid();
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

                FromCurrTextEdit.EditValue = "KES";
                    ToCurrTextEdit.EditValue = "KES";
                MultiplierTextEdit.Text = "1";
                   DivisorTextEdit.Text = "1";
                   EffectiveDateDateEdit.DateTime = DateTime.Now;
                NarrationTextEdit.Text = "Exchange Rates";
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
                
                FromCurrTextEdit.Enabled = false;
                ToCurrTextEdit.Enabled = false;
                MultiplierTextEdit.Enabled = false;
                DivisorTextEdit.Enabled = false;
                EffectiveDateDateEdit.Enabled = false;
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
                FromCurrTextEdit.Enabled = true;
                ToCurrTextEdit.Enabled = true;
                MultiplierTextEdit.Enabled = true;
                DivisorTextEdit.Enabled = true;
                EffectiveDateDateEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
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

                var FromCurr = Convert.ToString(FromCurrTextEdit.EditValue);
                var ToCurr = Convert.ToString(ToCurrTextEdit.EditValue);
                var EffectiveDate = Convert.ToDateTime(EffectiveDateDateEdit.DateTime);

               

                if (MessageBox.Show("Do you want to delete Exchange rate " + FromCurr, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllExchangeRatesTableAdapter.Delete(FromCurr, ToCurr, EffectiveDate, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    LoadGrid();
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

                var FromCurr = Convert.ToString(this.gridView1.GetFocusedRowCellValue("FromCurr"));
                var ToCurr = Convert.ToString(this.gridView1.GetFocusedRowCellValue("ToCurr"));
                var EffectiveDate = Convert.ToDateTime(this.gridView1.GetFocusedRowCellValue("EffectiveDate"));
                this.spSelectExchangeRatesTableAdapter.Fill(this.dsExchangeRates.spSelectExchangeRates, FromCurr, ToCurr, EffectiveDate, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Exchange rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Exchange rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Exchange rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Exchange rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void MultiplierTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DivisorTextEdit.Text = (1 / Convert.ToDecimal(MultiplierTextEdit.Text)).ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}