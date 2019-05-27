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
    public partial class frmKPIs : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "KPIs";
        public frmKPIs()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
        }

        private void frmKPIs_Load(object sender, EventArgs e)
        {
            userCodesTableAdapter.Fill(dsKPIs.UserCodes, "Departments");
            DepartmentLookUpEdit.EditValue = dsKPIs.UserCodes.DataSet.Tables["UserCodes"].Rows[0]["Code"].ToString();
            LoadGrid();
        }
        public void LoadGrid()
        {
            try
            {

                this.spSelectAllKPIsTableAdapter.Fill(this.dsKPIs.spSelectAllKPIs,AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
                this.spSelectKPIsTableAdapter.Insert(
                    KpiCodeTextEdit.Text,
                    KpiDescriptionTextEdit.Text,
                    AppConstant.CompCode,
                    DepartmentLookUpEdit.EditValue.ToString(),
                   CategoryTextEdit.Text,
                   Convert.ToInt32(WeightTextEdit.Text),
                   TargetTextEdit.Text,
                   RemarksTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Kpi saved successfully");
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
                KpiCodeTextEdit.Text = "0";
                KpiDescriptionTextEdit.Text = "0";
               CategoryTextEdit.Text = "Category";
                WeightTextEdit.Text = "0";
                TargetTextEdit.Text = "0";
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
                KpiCodeTextEdit.Enabled = false;
                KpiDescriptionTextEdit.Enabled = false;
                DepartmentLookUpEdit.Enabled = false;
                CategoryTextEdit.Enabled = false;
               WeightTextEdit.Enabled = false;
                TargetTextEdit.Enabled = false;
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
                KpiCodeTextEdit.Enabled = true;
                KpiDescriptionTextEdit.Enabled = true;
                DepartmentLookUpEdit.Enabled = true;
                CategoryTextEdit.Enabled = true;
                WeightTextEdit.Enabled = true;
                TargetTextEdit.Enabled = true;
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

                var Kpi = Convert.ToString(KpiCodeTextEdit.Text);
               

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete Kpi  " + Kpi, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectKPIsTableAdapter.Delete(Kpi,  AppConstant.UserID, Environment.MachineName);
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

                var KpiCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("KpiCode"));
                
                this.spSelectKPIsTableAdapter.Fill(this.dsKPIs.spSelectKPIs, KpiCode, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add KPIs", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit KPIs", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete KPIs", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export KPIs", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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