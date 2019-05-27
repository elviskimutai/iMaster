using System;

using System.Windows.Forms;

namespace Master.Forms
{
    public partial class frmKPIEntry : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "KPIs Entry";
        public frmKPIEntry()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmKPIEntry_Load(object sender, EventArgs e)
        {
            try
            {
                spGetKPIsTableAdapter.Fill(dsKPIEntry.spGetKPIs, AppConstant.CompCode);
                KpiTextEdit.EditValue = dsKPIEntry.spGetKPIs.DataSet.Tables["spGetKPIs"].Rows[0]["KpiCode"].ToString();
                spGetEmployeeCodesTableAdapter.Fill(dsKPIEntry.spGetEmployeeCodes, AppConstant.CompCode);
                EmpNoLookUpEdit.EditValue = dsKPIEntry.spGetEmployeeCodes.DataSet.Tables["spGetEmployeeCodes"].Rows[0]["EmpNo"].ToString();
                LoadGrid();
                EmployeeTextEdit.ReadOnly = true;
                WeightTextEdit.ReadOnly = true;
                //TargetTextEdit.ReadOnly = true;
                WeightTextEdit.Text = KpiTextEdit.GetColumnValue("Weight").ToString();
                TargetTextEdit.Text = KpiTextEdit.GetColumnValue("Target").ToString();
            }
            catch (Exception)
            {

            }
        }

        public void LoadGrid()
        {
            try
            {

                this.spSelectAllKpiEntryTableAdapter.Fill(this.dsKPIEntry.spSelectAllKpiEntry, AppConstant.CompCode,AppConstant.UserID, Environment.MachineName);
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
                this.spSelectAllKpiEntryTableAdapter.Insert(
                    KpiTextEdit.EditValue.ToString(),
                    EmpNoLookUpEdit.EditValue.ToString(),
                    EmployeeTextEdit.Text,
                    FromDateDateEdit.DateTime,
                    ToDateDateEdit.DateTime,
                    Convert.ToInt32(WeightTextEdit.Text),
                    TargetTextEdit.Text,
                    ActualTextEdit.Text,
                    ScoreTextEdit.Text,
                    RemarksTextEdit.Text,
                    
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("KPIs Entry saved successfully");
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
                FromDateDateEdit.DateTime = DateTime.Now;
                ToDateDateEdit.DateTime = DateTime.Now.AddMonths(1);
                WeightTextEdit.Text = "0";
                TargetTextEdit.Text = "0";
                ActualTextEdit.Text = "0";
                ScoreTextEdit.Text = "0";
                RemarksTextEdit.Text = "Remarks";

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
                KpiTextEdit.Enabled = false;
                EmpNoLookUpEdit.Enabled = false;
                EmployeeTextEdit.Enabled = false;
                FromDateDateEdit.Enabled = false;
                ToDateDateEdit.Enabled = false;
                WeightTextEdit.Enabled = false;
                TargetTextEdit.Enabled = false;
                ActualTextEdit.Enabled = false;
                ScoreTextEdit.Enabled = false;
                RemarksTextEdit.Enabled = false;


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

                KpiTextEdit.Enabled = true;
                EmpNoLookUpEdit.Enabled = true;
                EmployeeTextEdit.Enabled = true;
                FromDateDateEdit.Enabled = true;
                ToDateDateEdit.Enabled = true;
                WeightTextEdit.Enabled = true;
                TargetTextEdit.Enabled = true;
                ActualTextEdit.Enabled = true;
                ScoreTextEdit.Enabled = true;
                RemarksTextEdit.Enabled = true;
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

                var KPI = Convert.ToString(KpiTextEdit.EditValue);
                var EmpNo = Convert.ToString(EmpNoLookUpEdit.EditValue);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete KPI Entry  " + KPI, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllKpiEntryTableAdapter.Delete(KPI,EmpNo, AppConstant.UserID, Environment.MachineName);
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

                var Kpi = Convert.ToString(this.gridView1.GetFocusedRowCellValue("Kpi"));
                var EmpNo = Convert.ToString(this.gridView1.GetFocusedRowCellValue("EmpNo"));

                this.spSelectKpiEntryTableAdapter.Fill(this.dsKPIEntry.spSelectKpiEntry,Kpi,EmpNo,AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add KPI Entry", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit KPI Entry", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete KPI Entry", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export KPI Entry", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void EmpNoLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                EmployeeTextEdit.Text = EmpNoLookUpEdit.GetColumnValue("EmpNames").ToString();
            }
            catch (Exception)
            {

               
            }
        }

   
        private void KpiTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                WeightTextEdit.Text = KpiTextEdit.GetColumnValue("Weight").ToString();
                TargetTextEdit.Text = KpiTextEdit.GetColumnValue("Target").ToString();
            }
            catch (Exception)
            {

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