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
    public partial class frmUOMConversions : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Uom Conversions";
        Security _Security = new Security();
       
        public frmUOMConversions()
        {
            InitializeComponent();
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "info@citimax.co.ke";
        }

        private void frmUOMConversions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsUOMConversions.spSelectAllUOM' table. You can move, or remove it, as needed.
       
            // TODO: This line of code loads data into the 'dsUOMConversions.spGetItems' table. You can move, or remove it, as needed.

            try
            {
                this.spGetItemsTableAdapter.Fill(this.dsUOMConversions.spGetItems,AppConstant.CompCode);
                this.spSelectAllUOMTableAdapter.Fill(this.dsUOMConversions.spSelectAllUOM);

                loadgrid();
              
                ItemCodeGridLookUpEdit.EditValue = dsUOMConversions.spGetItems.DataSet.Tables["spGetItems"].Rows[1]["ItemCode"].ToString();
               
                FromUOMGridLookUpEdit.EditValue = dsUOMConversions.spSelectAllUOM.DataSet.Tables["spSelectAllUOM"].Rows[0]["Uom"].ToString();
                ToUOMGridLookUpEdit.EditValue = dsUOMConversions.spSelectAllUOM.DataSet.Tables["spSelectAllUOM"].Rows[1]["Uom"].ToString();

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
                spSeleteAllUOMConversionsTableAdapter.Fill(dsUOMConversions.spSeleteAllUOMConversions, AppConstant.CompCode);
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Add", AppConstant.UserID))
            {
                try
            {
                spSeleteAllUOMConversionsTableAdapter.Insert(AppConstant.CompCode, ItemCodeGridLookUpEdit.EditValue.ToString(), FromUOMGridLookUpEdit.EditValue.ToString(), ToUOMGridLookUpEdit.EditValue.ToString(), Convert.ToDouble(MultiplierTextEdit.Text), Convert.ToDouble(DivisorTextEdit.Text), AppConstant.UserID, Environment.MachineName);
                loadgrid();
                MessageBox.Show("Uom Conversions Saved Succesfully");
            }
            catch (Exception ex)
            {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to add Uom Conversions", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void SelectRecord()
        {
            try
            {

                // var TableName = Convert.ToString(this.gridView1.GetFocusedRowCellValue("TableName"));
                var ItemCode = Convert.ToString(this.gridView3.GetFocusedRowCellValue("ItemCode"));
                var FromUOM = Convert.ToString(this.gridView3.GetFocusedRowCellValue("FromUOM"));
                var ToUOM = Convert.ToString(this.gridView3.GetFocusedRowCellValue("ToUOM"));
                spSeleteUOMConversionsTableAdapter.Fill(dsUOMConversions.spSeleteUOMConversions, ItemCode, FromUOM, ToUOM);
                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            SelectRecord();
        }
        public void clearFields()
        {
            try
            {
                ItemCodeGridLookUpEdit.Text = "0";
              //  FromUOMGridLookUpEdit.Text = "";
              //  ToUOMGridLookUpEdit.Text = "";
                MultiplierTextEdit.SelectedText = "1";
                DivisorTextEdit.Text = "1";



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
               

                ItemCodeGridLookUpEdit.Enabled = false;
                FromUOMGridLookUpEdit.Enabled = false;
                ToUOMGridLookUpEdit.Enabled = false;
                MultiplierTextEdit.Enabled = false;
                DivisorTextEdit.Enabled = false;


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
                ItemCodeGridLookUpEdit.Enabled = true;
                FromUOMGridLookUpEdit.Enabled = true;
                ToUOMGridLookUpEdit.Enabled = true;
                MultiplierTextEdit.Enabled = true;
                DivisorTextEdit.Enabled = true;

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
        private void Submit_Click(object sender, EventArgs e)
        {

            if (this.ValidateRight("Edit", AppConstant.UserID))
            {
                EnableField();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Edit Uom Conversions", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Delete", AppConstant.UserID))
            {
                try
                {
                    spSeleteAllUOMConversionsTableAdapter.Delete(ItemCodeGridLookUpEdit.EditValue.ToString(), FromUOMGridLookUpEdit.EditValue.ToString(), ToUOMGridLookUpEdit.EditValue.ToString());
                  
                    MessageBox.Show("Uom Conversions Deleted Succesfully");
                    loadgrid();
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Delete Uom Conversions", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Export", AppConstant.UserID))
                {
                    gridView1.ShowPrintPreview();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Uom Conversions", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}