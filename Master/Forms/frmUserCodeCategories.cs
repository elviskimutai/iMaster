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
    public partial class frmUserCodeCategories : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "User Code Categories";
        public frmUserCodeCategories()
        {
            InitializeComponent();
        }

        private void frmUserCodeCategories_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("View", AppConstant.UserID))
                {
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to View User Code Categories", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                this.spSelectAllUserCodeCategoriesTableAdapter.Fill(this.dsUDCategories.spSelectAllUserCodeCategories, AppConstant.UserID, Environment.MachineName);
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
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    this.spSelectUserCodeCategoriesTableAdapter.Insert(
                    CatCodeTextEdit.Text.ToString(),
                    CatNameTextEdit.Text,
                   
                    NarrationTextEdit.Text,

                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("User Code Categories saved successfully");
                this.spSelectAllUserCodeCategoriesTableAdapter.Fill(this.dsUDCategories.spSelectAllUserCodeCategories, AppConstant.UserID, Environment.MachineName);
                ClearFields();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add User Code Categories", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                CatCodeTextEdit.Text = "0";
                CatNameTextEdit.Text = "";
                
                NarrationTextEdit.Text = "New Category";
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
                CatCodeTextEdit.Enabled = false;
                CatNameTextEdit.Enabled = false;
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
                CatCodeTextEdit.Enabled = true;
                CatNameTextEdit.Enabled = true;
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

                var CatCode = Convert.ToString(CatCodeTextEdit.Text);
                

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete User Code Category  " + CatCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectUserCodeCategoriesTableAdapter.Delete(CatCode, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllUserCodeCategoriesTableAdapter.Fill(this.dsUDCategories.spSelectAllUserCodeCategories, AppConstant.UserID, Environment.MachineName);
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

                var CatCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CatCode"));
                this.spSelectUserCodeCategoriesTableAdapter.Fill(this.dsUDCategories.spSelectUserCodeCategories, CatCode, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add User Code Categories", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit User Code Categories", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete User Code Categories", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export User Code Categories", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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