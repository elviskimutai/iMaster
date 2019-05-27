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
using DevExpress.XtraReports;
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace Master.Forms
{

    public partial class frmCommisionEntry : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Commission Entry";
        public frmCommisionEntry()
        {
            InitializeComponent();
        }

        private void frmCommisionEntry_Load(object sender, EventArgs e)
        {
            try
            {
             // ValidateChildren(ValidationConstraints.Enabled);
                //AppConstant.CompCode = "001";
                //AppConstant.UserID = "steve@live.com";
                this.costCenterTableAdapter.Fill(this.dsCommissionEntry.CostCenter, AppConstant.CompCode,AppConstant.UserID);
                CostCenterLookUpEdit.EditValue = dsCommissionEntry.CostCenter.DataSet.Tables["CostCenter"].Rows[0]["cccode"].ToString();
                LoadGrid();
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

                this.spSelectAllCommissionsEntryTableAdapter.Fill(this.dsCommissionEntry.spSelectAllCommissionsEntry, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
             
                this.spSelectAllCommissionsEntryTableAdapter.Insert(
                    EmpNoLookUpEdit.EditValue.ToString(),
                    EmpNameTextEdit.Text,
                    CommDateDateEdit.DateTime,
                    AppConstant.CompCode,
                    CostCenterLookUpEdit.EditValue.ToString(),
                    Convert.ToDecimal(AmountTextEdit.Text),
                    NarrationTextEdit.Text,

                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Commision Entry saved successfully");
                this.spSelectAllCommissionsEntryTableAdapter.Fill(this.dsCommissionEntry.spSelectAllCommissionsEntry, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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
               
                    CommDateDateEdit.DateTime = DateTime.Now;
                    AmountTextEdit.Text = "0";
                NarrationTextEdit.Text = "Commission Entry";
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
                EmpNoLookUpEdit.Enabled = false;
                EmpNameTextEdit.Enabled = false;
                CommDateDateEdit.Enabled = false;
                CostCenterLookUpEdit.Enabled = false;
                AmountTextEdit.Enabled = false;
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
                EmpNoLookUpEdit.Enabled = true;
                EmpNameTextEdit.Enabled = true;
                CommDateDateEdit.Enabled = true;
                CostCenterLookUpEdit.Enabled = true;
                AmountTextEdit.Enabled = true;
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

                var EmpNo = Convert.ToString(EmpNoLookUpEdit.EditValue);
                var CommDate = Convert.ToDateTime(CommDateDateEdit.Text);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete Commission Entry for Employee  " + EmpNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllCommissionsEntryTableAdapter.Delete(EmpNo, CommDate, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllCommissionsEntryTableAdapter.Fill(this.dsCommissionEntry.spSelectAllCommissionsEntry, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
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

                var EmpNo = Convert.ToString(this.gridView1.GetFocusedRowCellValue("EmpNo"));
                var CommDate = Convert.ToDateTime(this.gridView1.GetFocusedRowCellValue("CommDate"));
                this.spSelectCommissionsEntryTableAdapter.Fill(this.dsCommissionEntry.spSelectCommissionsEntry, EmpNo, CommDate, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Commission Entry", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Commission Entry", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Commission Entry", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Commission Entry", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void EmpNoLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            EmpNameTextEdit.Text = EmpNoLookUpEdit.Text;
        }

        private void dxValidationProvider1_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            try
            {
               MessageBox.Show(e.ErrorText);
            }
            catch (Exception)
            {
             
               
            }
        }

        private void CostCenterLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.employeesMasterTableAdapter.Fill(this.dsCommissionEntry.EmployeesMaster, AppConstant.CompCode, CostCenterLookUpEdit.EditValue.ToString());
                EmpNoLookUpEdit.EditValue = dsCommissionEntry.EmployeesMaster.DataSet.Tables["EmployeesMaster"].Rows[0]["EmpNo"].ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}