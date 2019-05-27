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
    public partial class frmCostCenter : Form
    {
        Security _Security = new Security();
        string SecurityModule = "CostCenters";
        public frmCostCenter()
        {
            InitializeComponent();
        }

        private void frmCostCenter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCostCenter.Companies' table. You can move, or remove it, as needed.
           
            try
            {
                //AppConstant.UserID = "super@live.com";
                //AppConstant.CompCode = "001";
                this.companiesTableAdapter.Fill(this.dsCostCenter.Companies);
                this.spSelectAllCostCenterTableAdapter.Fill(this.dsCostCenter.spSelectAllCostCenter, AppConstant.UserID, Environment.MachineName);
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
                CCCodeTextEdit.Text = "0";
                CCNameTextEdit.Text = "";
                CompCodeTextEdit.EditValue = "001";
                EmailTextEdit.Text = "example@example.com";
                TelephoneTextEdit.Text = "0";
                MobileTextEdit.Text = "0";
                PostalAddressTextEdit.Text = "0";
                PhysicalAddressTextEdit.Text = "0";
                WebUrlTextEdit.Text = "0";
                StatusCheckEdit.Checked = true;
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
                CCCodeTextEdit.Enabled = false;
                CCNameTextEdit.Enabled = false;
                CompCodeTextEdit.Enabled = false;
                EmailTextEdit.Enabled = false;
                TelephoneTextEdit.Enabled = false;
                MobileTextEdit.Enabled = false;
                PostalAddressTextEdit.Enabled = false;
                PhysicalAddressTextEdit.Enabled = false;
                WebUrlTextEdit.Enabled = false;
                StatusCheckEdit.Enabled = false;

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
                CCCodeTextEdit.Enabled = true;
                CCNameTextEdit.Enabled = true;
                CompCodeTextEdit.Enabled = true;
                EmailTextEdit.Enabled = true;
                TelephoneTextEdit.Enabled = true;
                MobileTextEdit.Enabled = true;
                PostalAddressTextEdit.Enabled = true;
                PhysicalAddressTextEdit.Enabled = true;
                WebUrlTextEdit.Enabled = true;
                StatusCheckEdit.Enabled = true;




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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit CostCenters", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
                    
                this.spSelectCostCenterTableAdapter.spSaveCostCenter(
                   CCCodeTextEdit.Text,
                   CCNameTextEdit.Text,
                   CompCodeTextEdit.EditValue.ToString(),
                   EmailTextEdit.Text,
                   TelephoneTextEdit.Text,
                   MobileTextEdit.Text,
                   PostalAddressTextEdit.Text,
                   PhysicalAddressTextEdit.Text,
                   WebUrlTextEdit.Text,
                   StatusCheckEdit.Checked,
                   
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("CostCenter saved successfully");
                this.spSelectAllCostCenterTableAdapter.Fill(this.dsCostCenter.spSelectAllCostCenter, AppConstant.UserID, Environment.MachineName);
                ClearFields();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add CostCenters", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                   
              
                var CCCode = Convert.ToString(CCCodeTextEdit.Text);

                if (this.gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete costcenter " + CCCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectCostCenterTableAdapter.spDeleteCostCenter(CCCode, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllCostCenterTableAdapter.Fill(this.dsCostCenter.spSelectAllCostCenter, AppConstant.UserID, Environment.MachineName);
                }

                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete CostCenters", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export CostCenters", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                string CCCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CCCode"));

                this.spSelectCostCenterTableAdapter.Fill(this.dsCostCenter.spSelectCostCenter, CCCode, AppConstant.UserID, Environment.MachineName);

                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
