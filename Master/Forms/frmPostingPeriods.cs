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
    public partial class frmPostingPeriods : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Posting Periods";
        public frmPostingPeriods()
        {
            InitializeComponent();
        }

        private void frmPostingPeriods_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("View", AppConstant.UserID))
                {
                    //AppConstant.CompCode = "001";
                    //AppConstant.UserID = "steve@live.com";
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to View Posting Periods", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void LoadGrid()
        {
            try
            {

                this.spSelectAllPostingPeriodsTableAdapter.Fill(this.dsPostigPeriods.spSelectAllPostingPeriods, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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

                this.spSelectAllPostingPeriodsTableAdapter.Insert(
                   AppConstant.CompCode,
                   Convert.ToString(PeriodCodeComboBoxEdit.Text),
                    Convert.ToInt32(YearTextEdit.Text),
                    Convert.ToDateTime(StartDateDateEdit.DateTime),
                   Convert.ToDateTime(EndDateDateEdit.DateTime),
                    StatusComboBoxEdit.Text,

                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Posting Period saved successfully");
                this.spSelectAllPostingPeriodsTableAdapter.Fill(this.dsPostigPeriods.spSelectAllPostingPeriods, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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

                PeriodCodeComboBoxEdit.Text = "";
                YearTextEdit.Text = DateTime.Now.Year.ToString();
                StartDateDateEdit.DateTime = DateTime.Now;
                EndDateDateEdit.DateTime = DateTime.Now.AddMonths(1);
                StatusComboBoxEdit.Text = "Open";
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
                PeriodCodeComboBoxEdit.Enabled = false;
                YearTextEdit.Enabled = false;
                StartDateDateEdit.Enabled = false;
                EndDateDateEdit.Enabled = false;
                StatusComboBoxEdit.Enabled = false;

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
                PeriodCodeComboBoxEdit.Enabled = true;
                YearTextEdit.Enabled = true;
                StartDateDateEdit.Enabled = true;
                EndDateDateEdit.Enabled = true;
                StatusComboBoxEdit.Enabled = true;
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

                var PeriodCode = Convert.ToString(PeriodCodeComboBoxEdit.Text);
                var Year = Convert.ToInt32(YearTextEdit.Text);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete Posting period  " + PeriodCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllPostingPeriodsTableAdapter.Delete(AppConstant.CompCode, PeriodCode, Year, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllPostingPeriodsTableAdapter.Fill(this.dsPostigPeriods.spSelectAllPostingPeriods, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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

                var PeriodCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("PeriodCode"));
                var Year = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("Year"));
                this.spSelectPostingPeriodsTableAdapter.Fill(this.dsPostigPeriods.spSelectPostingPeriods, AppConstant.CompCode, PeriodCode, Year, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Posting Periods", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Posting Periods", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Posting Periods", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Posting Periods", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void StartDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                EndDateDateEdit.DateTime = StartDateDateEdit.DateTime.AddMonths(1).AddDays(-1); ;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void PeriodCodeComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var Period = PeriodCodeComboBoxEdit.Text.ToString();
                StartDateDateEdit.DateTime = Convert.ToDateTime(DateTime.Parse("01 " + Period + ", " + DateTime.Now.Year));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}