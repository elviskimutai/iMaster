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
    public partial class frmPriceBands : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Price Bands";
        Security _Security = new Security();
        public frmPriceBands()
        {
           
            InitializeComponent();
          //  clearFields();
        }

        private void frmPriceBands_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dsPriceBands.spGetItems' table. You can move, or remove it, as needed.
               // CostCenterGridLookUpEdit.EditValue = dsPriceBands.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                this.spGetItemsTableAdapter.Fill(this.dsPriceBands.spGetItems,AppConstant.CompCode);
                spGetCompanyCostCentersTableAdapter.Fill(dsPriceBands.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                LoadGrid();
                clearFields();
                NarrationTextEdit.Text = "New Price Band";
                ItemCodeGridLookUpEdit.EditValue = dsPriceBands.spGetItems.DataSet.Tables["spGetItems"].Rows[1]["ItemCode"].ToString();
                MaximumTextEdit.Text = "0";
                MinimumTextEdit.Text = "0";
                RecomendedTextEdit.Text = "0";
                CostCenterGridLookUpEdit.EditValue = dsPriceBands.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();

            }
            catch (Exception  ex)
            {

                String err = ex.Message;
                MessageBox.Show(err);
            }
        }
        public void SaveRecord()
        {
            try
            {
                String PriceBand = PriceBandTextEdit.Text;
                if (PriceBand == "" || PriceBand == null)
                {
                    MessageBox.Show("Enter PriceBand to Continue");
                    return;
                }
                String CostCenter = CostCenterGridLookUpEdit.EditValue.ToString();
                if (CostCenter == "" || CostCenter == null)
                {
                    MessageBox.Show("Select CostCenter to Continue");
                    return;
                }
                String ItemCode = ItemCodeGridLookUpEdit.EditValue.ToString();
                if (ItemCode == "" || ItemCode == null)
                {
                    MessageBox.Show("Select Item to Continue");
                    return;
                }
                Decimal Minimum = Convert.ToDecimal(MinimumTextEdit.Text);
                
                Decimal Maximum = Convert.ToDecimal(MaximumTextEdit.Text);
                Decimal Recomended = Convert.ToDecimal(RecomendedTextEdit.Text);
                String Narration = NarrationTextEdit.Text;
                if (Narration == "" || Narration == null)
                {
                    MessageBox.Show("Enter Narration to Continue");
                    return;
                }
                spSelectAllPriceBandsTableAdapter.Insert(PriceBand, AppConstant.CompCode, CostCenter, ItemCode, Minimum, Maximum, Recomended, Narration, AppConstant.UserID, Environment.MachineName);
                MessageBox.Show("Record Saved Successfully");
                LoadGrid();
                clearFields();

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
                spSelectAllPriceBandsTableAdapter.Fill(dsPriceBands.spSelectAllPriceBands, AppConstant.CompCode);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void clearFields()
        {
            try
            {
                PriceBandTextEdit.Text = "0";
                MinimumTextEdit.Text = "0";
                MaximumTextEdit.Text = "0";
                RecomendedTextEdit.SelectedText = "0";
                NarrationTextEdit.Text = "";



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
                PriceBandTextEdit.Enabled = false;
                MaximumTextEdit.Enabled = false;
                MinimumTextEdit.Enabled = false;
                RecomendedTextEdit.Enabled = false;
                CostCenterGridLookUpEdit.Enabled = false;
                NarrationTextEdit.Enabled = false;
                ItemCodeGridLookUpEdit.Enabled = false;


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
                PriceBandTextEdit.Enabled = true;
                MinimumTextEdit.Enabled = true;
                MaximumTextEdit.Enabled = true;
                RecomendedTextEdit.Enabled = true;
                NarrationTextEdit.Enabled = true;
                CostCenterGridLookUpEdit.Enabled = true;
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
           
            if (this.ValidateRight("Add", AppConstant.UserID))
            {
                SaveRecord();

            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Add Price Bands", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Privilege Violation.You have insufficient right to Edit Price Bands", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Delete", AppConstant.UserID))
            {
                try
                {
                    String PriceBand = PriceBandTextEdit.Text;
                    String CostCenter = CostCenterGridLookUpEdit.EditValue.ToString();
                    String ItemCode = ItemCodeGridLookUpEdit.EditValue.ToString();

                    spSelectAllPriceBandsTableAdapter.Delete(PriceBand, AppConstant.CompCode, CostCenter, ItemCode);
                    MessageBox.Show("Record deleted Successfully");
                   
                    clearFields(); 
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Delete Price Bands", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateRight("Export", AppConstant.UserID))
            {
                gridView2.ShowPrintPreview();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Edit Price Bands", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                disableFields();
                var PriceBand = Convert.ToString(this.gridView2.GetFocusedRowCellValue("PriceBand"));
                var CostCenter = Convert.ToString(this.gridView2.GetFocusedRowCellValue("CostCenter"));
                var ItemCode = Convert.ToString(this.gridView2.GetFocusedRowCellValue("ItemCode"));
                spSelectPriceBandsTableAdapter.Fill(dsPriceBands.spSelectPriceBands, PriceBand, AppConstant.CompCode,CostCenter,ItemCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }