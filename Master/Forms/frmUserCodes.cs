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
    public partial class frmUserCodes : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "User Codes";
        public frmUserCodes()
        {
            InitializeComponent();
        }

        private void frmUserCodes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsUserCodes.UserCodeCategories' table. You can move, or remove it, as needed.
            try
            {
                //AppConstant.CompCode = "001";
                //AppConstant.UserID = "steve@live.com";
                if (this.ValidateRight("View", AppConstant.UserID))
                {
                    this.userCodeCategoriesTableAdapter.Fill(this.dsUserCodes.UserCodeCategories);
            LoadGrid();
            }
                else
                {
                MessageBox.Show("Privilege Violation.You have insufficient right to View User Codes", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                this.spSelectAllUserCodesTableAdapter.Fill(dsUserCodes.spSelectAllUserCodes, AppConstant.UserID, Environment.MachineName);
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
                    this.spSelectAllUserCodesTableAdapter.Insert(
                    CodeTextEdit.Text.ToString(),
                    DescriptionTextEdit.Text,
                    CategoryTextEdit.EditValue.ToString(),
                    NarrationTextEdit.Text,

                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("User Codes saved successfully");
                this.spSelectAllUserCodesTableAdapter.Fill(dsUserCodes.spSelectAllUserCodes, AppConstant.UserID, Environment.MachineName);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to add User Codes", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                CodeTextEdit.Text = "0";
                   
                NarrationTextEdit.Text = "User Codes ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void disableFields()
        {
            try { 
             CodeTextEdit.Enabled = false;
            DescriptionTextEdit.Enabled = false;
            CategoryTextEdit.Enabled = false;
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
                CodeTextEdit.Enabled = true;
                DescriptionTextEdit.Enabled = true;
                CategoryTextEdit.Enabled = true;
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

                var Code = Convert.ToString(CodeTextEdit.Text);
                var Category = Convert.ToString(CategoryTextEdit.EditValue);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete User Code  " + Code, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllUserCodesTableAdapter.Delete(Code, Category, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllUserCodesTableAdapter.Fill(dsUserCodes.spSelectAllUserCodes, AppConstant.UserID, Environment.MachineName);
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

                var Code = Convert.ToString(this.gridView1.GetFocusedRowCellValue("Code"));
                var Category = Convert.ToString(this.gridView1.GetFocusedRowCellValue("Category"));
                this.spSelectUserCodesTableAdapter.Fill(this.dsUserCodes.spSelectUserCodes, Code, Category, AppConstant.UserID, Environment.MachineName);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add User Codes", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit User Codes", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete User Codes", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export User Codes", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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