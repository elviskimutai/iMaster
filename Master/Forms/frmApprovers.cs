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
    public partial class frmApprovers : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Approvers";
        public frmApprovers()
        {
            InitializeComponent();
           
        }

        private void frmApprovers_Load(object sender, EventArgs e)
        {
          
     
            try
            {
                if (this.ValidateRight("View", AppConstant.UserID))
                {
                    this.usersTableAdapter.Fill(this.dsApprovers.Users);
                    this.costCenterTableAdapter.Fill(this.dsApprovers.CostCenter, AppConstant.CompCode);
                    this.spgetUDCByCategoryTableAdapter.Fill(dsApprovers.spgetUDCByCategory, "Approvals");
                    LoadGrid();

                    CostCenterTextEdit.EditValue = dsApprovers.CostCenter.DataSet.Tables["CostCenter"].Rows[0]["cccode"].ToString();
                    ModuleTextEdit.EditValue = dsApprovers.spgetUDCByCategory.DataSet.Tables["spgetUDCByCategory"].Rows[0]["Code"].ToString();
                }
                else
                {
                        MessageBox.Show("Privilege Violation.You have insufficient right to View Approvers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                this.spSelectAllApproversTableAdapter.Fill(this.dsApprovers.spSelectAllApprovers, AppConstant.UserID, Environment.MachineName);
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
                String PriceBand = textEditApproverTitile.Text;
                if (PriceBand == "" || PriceBand == null)
                {
                    MessageBox.Show("Enter  Approver Titile to Continue");
                    return;
                }
                String Narration = NarrationTextEdit.Text;
                if (Narration == "" || Narration == null)
                {
                    MessageBox.Show("Enter  Narration to Continue");
                    return;
                }
              
                this.spSelectAllApproversTableAdapter.Insert(
                    AppConstant.CompCode,
                    textEditApproverTitile.Text,
                    ModuleTextEdit.EditValue.ToString(),
                    ApproverTextEdit.EditValue.ToString(),
                    Convert.ToInt32(ApprovalLevelTextEdit.Text),
                    CostCenterTextEdit.EditValue.ToString(),
                    NarrationTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Approver saved successfully");
                this.spSelectAllApproversTableAdapter.Fill(this.dsApprovers.spSelectAllApprovers, AppConstant.UserID, Environment.MachineName);
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
               // ModuleTextEdit.EditValue = "0";
                    ApproverTextEdit.EditValue =AppConstant.UserID;
                ApprovalLevelTextEdit.Text = "1";
                NarrationTextEdit.Text = "New Approver";
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
                textEditApproverTitile.Enabled = false;
                ModuleTextEdit.Enabled = false;
                ApproverTextEdit.Enabled = false;
                ApprovalLevelTextEdit.Enabled = false;
                CostCenterTextEdit.Enabled = false;
                NarrationTextEdit.Enabled = false;
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
                ModuleTextEdit.Enabled = true;
                ApproverTextEdit.Enabled = true;
                ApprovalLevelTextEdit.Enabled = true;
                CostCenterTextEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
                textEditApproverTitile.Enabled = true;
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

                var Module = Convert.ToString(ModuleTextEdit.EditValue);
                var Approver = Convert.ToString(ApproverTextEdit.EditValue);
                var ApprovalLevel = Convert.ToInt32(ApprovalLevelTextEdit.Text);
                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete Approver " + Approver, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllApproversTableAdapter.Delete(Module, Approver, ApprovalLevel, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllApproversTableAdapter.Fill(this.dsApprovers.spSelectAllApprovers, AppConstant.UserID, Environment.MachineName);
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

                var Module = Convert.ToString(this.gridView1.GetFocusedRowCellValue("Module"));
                var Approver = Convert.ToString(this.gridView1.GetFocusedRowCellValue("Approver"));
                var ApprovalLevel = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ApprovalLevel"));
                this.spSelectApproversTableAdapter.Fill(this.dsApprovers.spSelectApprovers, Module, Approver, ApprovalLevel, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add approvers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Approvers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Approvers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        MessageBox.Show("Privilege Violation.You have insufficient right to Export Approvers", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}