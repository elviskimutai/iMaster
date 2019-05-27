using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master.Forms
{
    public partial class frmCompanyCostCenterAccess : Form
    {
        Security _Security = new Security();
        string SecurityModule = "CostCenter Access";
        public frmCompanyCostCenterAccess()
        {
            InitializeComponent();
        }

        private void frmCompanyCostCenterAccess_Load(object sender, EventArgs e)
        {
          
            try
            {
               
              
                this.companiesTableAdapter.Fill(this.dsCompCCAccess.Companies);
                this.usersTableAdapter.Fill(this.dsCompCCAccess.Users);
                this.spSelectAllCompCCAccessTableAdapter.Fill(this.dsCompCCAccess.spSelectAllCompCCAccess, AppConstant.UserID, Environment.MachineName);
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
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                   
                
                this.spSelectCompCCAccessTableAdapter.spSaveCCCAccess(
                   UserNameTextEdit.EditValue.ToString(),
                   CompCodeTextEdit.EditValue.ToString(),
                   CostCenterTextEdit.EditValue.ToString(),
                   EffectiveDateDateEdit.DateTime,
                   NarrationTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Company costcenter access saved successfully");
                this.spSelectAllCompCCAccessTableAdapter.Fill(this.dsCompCCAccess.spSelectAllCompCCAccess, AppConstant.UserID, Environment.MachineName);
                ClearFields();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add CostCenter Access", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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

                CompCodeTextEdit.EditValue = AppConstant.CompCode;
                CostCenterTextEdit.EditValue = "001";
                EffectiveDateDateEdit.DateTime = DateTime.Now;
                NarrationTextEdit.Text = "Company Costcenter access";
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
                CompCodeTextEdit.Enabled = false;
                UserNameTextEdit.Enabled = false;
                CostCenterTextEdit.Enabled = false;
                NarrationTextEdit.Enabled = false;
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
                CompCodeTextEdit.Enabled = true;
                UserNameTextEdit.Enabled = true;
                CostCenterTextEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
                EffectiveDateDateEdit.Enabled = true;
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit CostCenter Access", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    var UserName = Convert.ToString(UserNameTextEdit.EditValue);
                var CompCode = Convert.ToString(CompCodeTextEdit.EditValue);
                var CostCenter = Convert.ToString(CostCenterTextEdit.EditValue);

                if (this.gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete companyCostcenterAccess " + UserName+" for CompCode "+ CompCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectCompCCAccessTableAdapter.spDeleteCCCAccess(UserName, CompCode, CostCenter, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllCompCCAccessTableAdapter.Fill(this.dsCompCCAccess.spSelectAllCompCCAccess, AppConstant.UserID, Environment.MachineName);
                }

            }
                else
                {
                MessageBox.Show("Privilege Violation.You have insufficient right to delete CostCenter Access", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export CostCenter Access", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                string UserName = Convert.ToString(this.gridView1.GetFocusedRowCellValue("UserName"));

                string CompCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CompCode"));
                string CostCenter = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CostCenter"));
                

                this.spSelectCompCCAccessTableAdapter.Fill(this.dsCompCCAccess.spSelectCompCCAccess, UserName, CompCode, CostCenter, AppConstant.UserID, Environment.MachineName);

                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CompCodeTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.costCenterTableAdapter.Fill(this.dsCompCCAccess.CostCenter, CompCodeTextEdit.EditValue.ToString());
            }
            catch (Exception)
            {
                
            }
        }
    }
}
