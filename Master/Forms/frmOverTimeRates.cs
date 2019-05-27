using System;

using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Master.Forms
{
    public partial class frmOverTimeRates : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Over Time Rates";
        public frmOverTimeRates()
        {
            InitializeComponent();
        }

        private void frmOverTimeRates_Load(object sender, EventArgs e)
        {
           
           

            try
            {
                //AppConstant.CompCode = "001";
                //AppConstant.UserID = "steve@live.com";
                this.currenciesTableAdapter.Fill(this.dsOverTimeRates.Currencies);
                this.spGetCompCostCenterTableAdapter.Fill(this.dsOverTimeRates.spGetCompCostCenter, AppConstant.CompCode,AppConstant.UserID);
                LoadGrid();
                CurrencyLookUpEdit.EditValue = "KES";
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
        public void LoadGrid()
        {
            try
            {

                this.spSelectAllOverTimeRatesTableAdapter.Fill(this.dsOverTimeRates.spSelectAllOverTimeRates,AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
                this.spSelectAllOverTimeRatesTableAdapter.Insert(
                    AppConstant.CompCode,
                    CostCenterLookUpEdit.EditValue.ToString(),
                   Convert.ToString(RateCodeTextEdit.Text),
                   Convert.ToString(RateNameTextEdit.Text),
                   Convert.ToDecimal(RatePerHourTextEdit.Text),
                   Convert.ToString(CurrencyLookUpEdit.EditValue),
                   txtNarration.Text,

                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("OverTime Rates saved successfully");
                this.spSelectAllOverTimeRatesTableAdapter.Fill(this.dsOverTimeRates.spSelectAllOverTimeRates, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
                  CostCenterLookUpEdit.EditValue = "001";
                  RateCodeTextEdit.Text = "0";
                  RateNameTextEdit.Text = "0";
                  RatePerHourTextEdit.Text = "0";
                  CurrencyLookUpEdit.EditValue = "KE";
                  txtNarration.Text = "OverTime rates";
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
                CostCenterLookUpEdit.Enabled = false;
                RateCodeTextEdit.Enabled = false;
                RateNameTextEdit.Enabled = false;
                RatePerHourTextEdit.Enabled = false;
                CurrencyLookUpEdit.Enabled = false;
                txtNarration.Enabled = false;
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
                CostCenterLookUpEdit.Enabled = true;
                RateCodeTextEdit.Enabled = true;
                RateNameTextEdit.Enabled = true;
                RatePerHourTextEdit.Enabled = true;
                CurrencyLookUpEdit.Enabled = true;
                txtNarration.Enabled = true;
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

                var CostCenter = Convert.ToString(CostCenterLookUpEdit.EditValue);
                var RateCode = Convert.ToString(RateCodeTextEdit.Text);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete RateCode  " + RateCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllOverTimeRatesTableAdapter.Delete(AppConstant.CompCode, CostCenter, RateCode, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllOverTimeRatesTableAdapter.Fill(this.dsOverTimeRates.spSelectAllOverTimeRates, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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

                var CostCenter = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CostCenter"));
                var RateCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("RateCode"));
                this.spSelectOverTimeRatesTableAdapter.Fill(this.dsOverTimeRates.spSelectOverTimeRates, AppConstant.CompCode, CostCenter, RateCode, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Over Time Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Over Time Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Over Time Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Over Time Rates", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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