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
    public partial class frmUOM : DevExpress.XtraEditors.XtraForm
    {

        string SecurityModule = "UOM";
        Security _Security = new Security();
        public frmUOM()
        {
            InitializeComponent();
           
        }

        private void frmUOM_Load(object sender, EventArgs e)
        {
            try
            {
                loadgrid();
                DescriptionTextEdit.Text = "New UOM";
            }
            catch (Exception)
            {

               
            }

        }
        public void disableFields()
        {
            try
            {
                UomTextEdit.Enabled = false;
                DescriptionTextEdit.Enabled = false;
               


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

                UomTextEdit.Enabled = true;
                DescriptionTextEdit.Enabled = true;
               

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

                // var TableName = Convert.ToString(this.gridView1.GetFocusedRowCellValue("TableName"));
                var uom = Convert.ToString(this.gridView1.GetFocusedRowCellValue("Uom"));
                spSelectUOMTableAdapter.Fill(dsUom.spSelectUOM, uom);
                 disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void loadgrid()
        {
            try
            {
                this.spSelectAllUOMTableAdapter.Fill(this.dsUom.spSelectAllUOM);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Delete", AppConstant.UserID))
            {
                try
            {
                string uom = UomTextEdit.Text;
                this.spSelectAllUOMTableAdapter.Delete(uom);
                MessageBox.Show("Uom Deleted Succesfully");
                loadgrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Delete UOM", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Add", AppConstant.UserID))
            {
                try
            {
                string uom = UomTextEdit.Text;
                string desc = DescriptionTextEdit.Text;
                this.spSelectAllUOMTableAdapter.Insert(uom,desc,AppConstant.UserID,Environment.MachineName);
                MessageBox.Show("Uom Saved Succesfully");
                    loadgrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Add UOM", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Edit", AppConstant.UserID))
                {
                    EnableField();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit UOM", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            SelectRecord();
            disableFields();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Export", AppConstant.UserID))
            {
                gridView1.ShowPrintPreview();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Export UOM", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}