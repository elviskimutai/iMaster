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
using System.Data.SqlClient;

namespace Master.Forms
{
    public partial class frmCashierCheckin : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Cashier Checkin";
        Security _Security = new Security();
        public frmCashierCheckin()
        {
            InitializeComponent();

            
        }
        public void LoadGrid()
        {
            try
            {
                spSelectAllCashierCheckinTableAdapter.Fill(dsCashierCheckin.spSelectAllCashierCheckin, AppConstant.CompCode, AppConstant.UserID, Environment.MachineName);
    
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void disableFields()
        {

            RemarksTextEdit.Enabled = false;
            CostCenterGridLookUpEdit.Enabled = false;
            AmountTextEdit.Enabled = false;
           

        }
        public void enableFields()
        {

            AmountTextEdit.Enabled = true;
            CostCenterGridLookUpEdit.Enabled = true;
            AmountTextEdit.Enabled = true;
           

        }
        private void frmCashierCheckin_Load(object sender, EventArgs e)
        {
            try
            {

                spGetCompanyCostCentersTableAdapter.Fill(dsCashierCheckin.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                LoadGrid();
                CostCenterGridLookUpEdit.EditValue = dsCashierCheckin.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                RemarksTextEdit.Text = "New Cashier checkin";
            }
            catch (Exception)
            {

              
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                //var ItemCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CostCenter"));
                //var Date = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CostCenter"));
                //spSelectCashierCheckinTableAdapter.Fill(dsCashierCheckin.spSelectCashierCheckin, AppConstant.CompCode, ItemCode, AppConstant.UserID, AppConstant.UserID, Environment.MachineName);
            }catch(Exception ex)
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
                try
                {
                    string Costcenter = CostCenterGridLookUpEdit.EditValue.ToString();
                    decimal Amount = Convert.ToDecimal(AmountTextEdit.Text);
                    string Remarks = RemarksTextEdit.Text;
                    this.spSelectAllCashierCheckinTableAdapter.Insert(AppConstant.CompCode, Costcenter, AppConstant.UserID, Amount, Remarks, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Cashier Checkin Saved Succesfully");
                    LoadGrid();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("User " + AppConstant.UserID + " has already checkedin");
                    }else
                    {

                        MessageBox.Show("Error while saving record");
                        MessageBox.Show(ex.Message);
                    }
                    //if (ex.Number == 2627) // <-- but this will
                    //{
                    //    //Violation of primary key. Handle Exception
                    //    MessageBox.Show("User " + AppConstant.UserID + " has already checkedin");
                    //}
                    //else
                    //{

                    //    MessageBox.Show("Error while saving record");

                    //}

                }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Add Cashier Checkin", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Privilege Violation.You have insufficient right to Add Export Checkin", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }
    }
}