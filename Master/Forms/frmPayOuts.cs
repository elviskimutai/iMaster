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
    public partial class frmPayOuts : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Pay Outs";
        Security _Security = new Security();
        public frmPayOuts()
        {
            InitializeComponent();
           
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
        private void frmPayOuts_Load(object sender, EventArgs e)
        {
            try
            {
                this.spgetGlAccountsTableAdapter.Fill(dsPayOuts.spgetGlAccounts, AppConstant.CompCode);
                this.spgetUsersTableAdapter.Fill(dsPayOuts.spgetUsers, AppConstant.CompCode);
                this.spGetCompanyCostCentersTableAdapter.Fill(dsPayOuts.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                LoadGrid();
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
                this.spSelectAllPayOutsTableAdapter.Fill(dsPayOuts.spSelectAllPayOuts, AppConstant.CompCode, AppConstant.UserID);
                RemarksTextEdit.Text = "New Cashier PayOut";
                AmountTextEdit.Text = "0";
                CostCenterTextEdit.EditValue = dsPayOuts.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
                CashierTextEdit.EditValue = dsPayOuts.spgetUsers.DataSet.Tables["spgetUsers"].Rows[0]["UserName"].ToString();
                GLAccountTextEdit.EditValue = dsPayOuts.spgetGlAccounts.DataSet.Tables["spgetGlAccounts"].Rows[0]["AccCode"].ToString();
                DocNoTextEdit.Enabled = false;
                DocNoTextEdit.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void disableFields()
        {

            RemarksTextEdit.Enabled = false;
            CostCenterTextEdit.Enabled = false;
            AmountTextEdit.Enabled = false;
            GLAccountTextEdit.Enabled = false;
            DocNoTextEdit.Enabled = false;
            CashierTextEdit.Enabled = false;

        }
        public void enableFields()
        {

            AmountTextEdit.Enabled = true;
            RemarksTextEdit.Enabled = true;
            CostCenterTextEdit.Enabled = true;
            AmountTextEdit.Enabled = true;
            GLAccountTextEdit.Enabled = true;
            CashierTextEdit.Enabled = true;



        }
        public void DeleteRecord()
        {
            try
            {
               
                var CostCenter = Convert.ToString(CostCenterTextEdit.EditValue); 
                var DocNo = Convert.ToString(DocNoTextEdit.Text);
                var Cashier = Convert.ToString(CashierTextEdit.EditValue);

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete payout  " + DocNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllPayOutsTableAdapter.Delete(AppConstant.CompCode, CostCenter, DocNo, Cashier);
                    MessageBox.Show("Record deleted successfully");
                    LoadGrid();
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

                var CostCenter = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CostCenter"));
                var DocNo = Convert.ToString(this.gridView1.GetFocusedRowCellValue("DocNo"));
                var Cashier = Convert.ToString(this.gridView1.GetFocusedRowCellValue("Cashier"));
                spSelectPayOutsTableAdapter.Fill(dsPayOuts.spSelectPayOuts, AppConstant.CompCode, CostCenter, DocNo, Cashier);


                disableFields();
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
                    this.spSelectAllPayOutsTableAdapter.Insert(AppConstant.CompCode, CostCenterTextEdit.EditValue.ToString(), DocNoTextEdit.Text, CashierTextEdit.EditValue.ToString(), GLAccountTextEdit.EditValue.ToString(), Convert.ToDecimal(AmountTextEdit.Text), RemarksTextEdit.Text, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Cashier Checkin Saved Succesfully");
                    LoadGrid();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("User " + AppConstant.UserID + " has already paid");
                    }
                    else
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
                MessageBox.Show("Privilege Violation.You have insufficient right to Add Pay Outs", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Edit", AppConstant.UserID))
                {
                    enableFields();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Pay Outs", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Pay Outs", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Pay Outs", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
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