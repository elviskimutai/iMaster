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
    public partial class frmDBAs : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Benefits & Deductions";
        public frmDBAs()
        {
            InitializeComponent();
        }

        private void frmDBAs_Load(object sender, EventArgs e)
        {
            try
            {
                //AppConstant.CompCode = "001";
                //AppConstant.UserID = "steve@live.com";
             
                costCenterTableAdapter.Fill(dsDBAs.CostCenter, AppConstant.CompCode,AppConstant.UserID);
                CostCenterTextEdit.EditValue = dsDBAs.CostCenter.DataSet.Tables["CostCenter"].Rows[0]["cccode"].ToString();
                userCodesTableAdapter.Fill(dsDBAs.UserCodes,"Benefits&Deductions");
                LoadGrid();
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

                this.spSelectAllDBAsTableAdapter.Fill(dsDBAs.spSelectAllDBAs,AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
                this.spSelectDBAsTableAdapter.Insert(
                    AppConstant.CompCode,
                    CostCenterTextEdit.EditValue.ToString(),
                    EmpCodeLookUpEdit.EditValue.ToString(),
                    chkAllEmployees.Checked,
                    DBACodeLookUpEdit.EditValue.ToString(),
                    DBADescriptionTextEdit.Text,
                    DBATypeComboBoxEdit.Text,
                    EffectiveDateDateEdit.DateTime,
                    RateTypeComboBoxEdit.Text,
                    Convert.ToDouble(RateTextEdit.Text),
                    NarrationTextEdit.Text,

                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Benefit/Decuction saved successfully");
                this.spSelectAllDBAsTableAdapter.Fill(dsDBAs.spSelectAllDBAs, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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

               
                    DBACodeLookUpEdit.EditValue = "0";
                DBADescriptionTextEdit.Text = "";
                    DBATypeComboBoxEdit.Text = "Deduction";
                    EffectiveDateDateEdit.DateTime = DateTime.Now;
                    RateTypeComboBoxEdit.Text = "Amount";
                    RateTextEdit.Text = "0";
                chkAllEmployees.Checked = false;
                NarrationTextEdit.Text = "Deduction/Benefits entry";
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
                CostCenterTextEdit.Enabled = false;
                EmpCodeLookUpEdit.Enabled = false;
                DBACodeLookUpEdit.Enabled = false;
                DBADescriptionTextEdit.Enabled = false;
                DBATypeComboBoxEdit.Enabled = false;
                EffectiveDateDateEdit.Enabled = false;
                RateTypeComboBoxEdit.Enabled = false;
                RateTextEdit.Enabled = false;
                NarrationTextEdit.Enabled = false;
                chkAllEmployees.Enabled = false;


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
                CostCenterTextEdit.Enabled = true;
                EmpCodeLookUpEdit.Enabled = true;
                DBACodeLookUpEdit.Enabled = true;
                DBADescriptionTextEdit.Enabled = true;
                DBATypeComboBoxEdit.Enabled = true;
                EffectiveDateDateEdit.Enabled = true;
                RateTypeComboBoxEdit.Enabled = true;
                RateTextEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
                chkAllEmployees.Enabled = true;
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

                var EmpCode = Convert.ToString(EmpCodeLookUpEdit.EditValue);
                var DBACode = Convert.ToString(DBACodeLookUpEdit.EditValue);
                var DBAType = Convert.ToString(DBATypeComboBoxEdit.Text);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete this plan type for  " + EmpCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectDBAsTableAdapter.Delete(AppConstant.CompCode, EmpCode, DBACode, DBAType, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllDBAsTableAdapter.Fill(dsDBAs.spSelectAllDBAs, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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

                var EmpCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("EmpCode"));
                var DBACode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("DBACode"));
                var DBAType = Convert.ToString(this.gridView1.GetFocusedRowCellValue("DBAType"));
                this.spSelectDBAsTableAdapter.Fill(this.dsDBAs.spSelectDBAs, AppConstant.CompCode, EmpCode, DBACode, DBAType, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Benefits & Deductions", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Benefits & Deductions", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Benefits & Deductions", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Benefits & Deductions", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void DBACodeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DBADescriptionTextEdit.Text = DBACodeLookUpEdit.Text;
            }
            catch (Exception)
            {

              
            }
        }

        private void CostCenterTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                employeesMasterTableAdapter.Fill(dsDBAs.EmployeesMaster, AppConstant.CompCode, CostCenterTextEdit.EditValue.ToString());

                EmpCodeLookUpEdit.EditValue = dsDBAs.EmployeesMaster.DataSet.Tables["EmployeesMaster"].Rows[0]["EmpNo"].ToString();
            }
            catch (Exception)
            {

                
            }
        }
    }
}