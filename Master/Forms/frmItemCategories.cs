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
    public partial class frmItemCategories : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Item Categories";
        Security _Security = new Security();
        public frmItemCategories()
        {
            InitializeComponent();
           
        
        }

        private void frmItemCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsItemCategories.spSelectAllItemCategories' table. You can move, or remove it, as needed.
            loadgrid();
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

        public void loadgrid()
        {
            this.spSelectAllItemCategoriesTableAdapter.Fill(this.dsItemCategories.spSelectAllItemCategories);

        }
        public void selectdata()
        {
            var cat = Convert.ToString(this.gridView1.GetFocusedRowCellValue("Category"));

           // string cat = CategoryTextEdit.Text;
            spSelectItemCategoriesTableAdapter.Fill(dsItemCategories.spSelectItemCategories, cat);
        }
        public void disablefields()
        {
            CategoryTextEdit.Enabled = false;
            DescriptionTextEdit.Enabled = false;
        }
        public void enabledfields()
        {
            CategoryTextEdit.Enabled = true;
            DescriptionTextEdit.Enabled = true;
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            selectdata();
            disablefields();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (this.ValidateRight("Edit", AppConstant.UserID))
                {
                    enabledfields();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Item Categories", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Delete", AppConstant.UserID))
            {
                string cat = CategoryTextEdit.Text;
            spSelectAllItemCategoriesTableAdapter.Delete(cat);
            MessageBox.Show("Item category Deleted Succesffully");
            loadgrid();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Delete Item Categories", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Add", AppConstant.UserID))
            {
                string cat = CategoryTextEdit.Text;
                string desc = CategoryTextEdit.Text;
                spSelectAllItemCategoriesTableAdapter.Insert(cat, desc, AppConstant.UserID, Environment.MachineName);
                MessageBox.Show("Item category Saved Succesffully");
                loadgrid();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to add Item Categories", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Export", AppConstant.UserID))
            {
                gridView1.ShowPrintPreview();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Export Item Categories", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}