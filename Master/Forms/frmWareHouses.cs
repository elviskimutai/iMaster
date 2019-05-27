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
    public partial class frmWareHouses : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "WareHouses";
        public frmWareHouses()
        {
            InitializeComponent();
        }

        private void frmWareHouses_Load(object sender, EventArgs e)
        {
            //AppConstant.CompCode = "001";
            //AppConstant.UserID = "steve@live.com";
           
          this.spGetCompanyCostCentersTableAdapter.Fill(this.dsWarehouses.spGetCompanyCostCenters,AppConstant.CompCode,AppConstant.UserID);
            LoadGrid();
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

                this.spSelectAllWareHousesTableAdapter.Fill(this.dsWarehouses.spSelectAllWareHouses);
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

                this.spSelectAllWareHousesTableAdapter.Insert(
                    AppConstant.CompCode,
                    LocationCodeTextEdit.Text,
                    LocationNameTextEdit.Text,
                    CostCenterLookUpEdit.EditValue.ToString(),
                   DimensionsTextEdit.Text,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Warehouse saved successfully");
                this.spSelectAllWareHousesTableAdapter.Fill(this.dsWarehouses.spSelectAllWareHouses);
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
                LocationCodeTextEdit.Text = "0";
                LocationNameTextEdit.Text = "0";
                CostCenterLookUpEdit.EditValue = "001";
                DimensionsTextEdit.Text = "0";
               
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
                LocationCodeTextEdit.Enabled = false;
                LocationNameTextEdit.Enabled = false;
                CostCenterLookUpEdit.Enabled = false;
                DimensionsTextEdit.Enabled = false;

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
                LocationCodeTextEdit.Enabled = true;
                LocationNameTextEdit.Enabled = true;
                CostCenterLookUpEdit.Enabled = true;
                DimensionsTextEdit.Enabled = true;
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

                var LocationCode = Convert.ToString(LocationCodeTextEdit.Text);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete warehouse  " + LocationCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllWareHousesTableAdapter.Delete(LocationCode,  AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllWareHousesTableAdapter.Fill(this.dsWarehouses.spSelectAllWareHouses);
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

                var LocationCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("LocationCode"));
                this.spSelectWareHousesTableAdapter.Fill(this.dsWarehouses.spSelectWareHouses, LocationCode,  AppConstant.UserID, Environment.MachineName);

                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

     
        public string ValidateControls()
        {
            try
            {
                if ((this.LocationCodeTextEdit.Text.Equals(string.Empty))|| (this.LocationCodeTextEdit.Text.Equals("")))
                {
                    return "Enter the LocationCode to proceed";
                }
                if (this.LocationNameTextEdit.Text.Equals(""))
                {
                    return "Enter the LocationName to proceed";
                }
                //if ((this.CostCenterLookUpEdit.EditValue.Equals(null))|| (this.CostCenterLookUpEdit.EditValue.Equals(string.Empty)))
                //{
                //    return "Enter CostCenter to proceed";
                //}

                if (this.DimensionsTextEdit.Text.Equals(""))
                {
                    return "Enter Dimensions to proceed";
                }

               
                return "Success";
            }
            catch (Exception)
            {

                return null;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateControls().Equals("Success"))
            {
                this.SaveRecord();
            }
            else
            {
                MessageBox.Show(this.ValidateControls(), "warehouses Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                EnableField();
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
                DeleteRecord();
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
                gridView1.ShowPrintPreview();

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