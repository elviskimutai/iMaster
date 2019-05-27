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
    public partial class frmSalesRep : DevExpress.XtraEditors.XtraForm
    {
        string SecurityModule = "Sales Reps";
        Security _Security = new Security();
       

        public frmSalesRep()
        {
            InitializeComponent();
          
        }
        public void disableFields()
        {

            
            RepNoTextEdit.Enabled = false;
            RepNameTextEdit.Enabled = false;
            PhysicalAddressTextEdit.Enabled = false;
            PostalAddressTextEdit.Enabled = false;
            EmailTextEdit.Enabled = false;
            MobileNoTextEdit.Enabled = false;
            TelephoneTextEdit.Enabled = false;
            WebURLTextEdit.Enabled = false;
            StatusComboBoxEdit.Enabled = false;

        }
        public void ClearFields()
        {
            try
            {
                RepNoTextEdit.Text = "0";
                EmailTextEdit.Text = "email@email.com";
                MobileNoTextEdit.Text = "0";
                TelephoneTextEdit.Text = "0";
                PostalAddressTextEdit.Text = "0";
                PhysicalAddressTextEdit.Text = "0";
                StatusComboBoxEdit.SelectedItem = "Active";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }
        public void enableFields()
        {
            
                 RepNoTextEdit.Enabled = true;
             RepNameTextEdit.Enabled = true;
             PhysicalAddressTextEdit.Enabled = true;
             PostalAddressTextEdit.Enabled = true;
             EmailTextEdit.Enabled = true;
             MobileNoTextEdit.Enabled = true;
             TelephoneTextEdit.Enabled = true;
             WebURLTextEdit.Enabled = true;
            StatusComboBoxEdit.Enabled = true;

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
        private void frmSalesRep_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGrid();
                spGetCompanyCostCentersTableAdapter.Fill(dsSalesRep.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                CostCenterGridLookUpEdit.EditValue = dsSalesRep.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();
               

            }
            catch (Exception)
            {

               
            }
        }
        public void LoadGrid()
        {
            try
            {
                spSelectAllSalesRepTableAdapter.Fill(dsSalesRep.spSelectAllSalesRep, AppConstant.UserID, Environment.MachineName);
                ClearFields();
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
                    string Costcenter = CostCenterGridLookUpEdit.EditValue.ToString();
                    string RepNo = RepNoTextEdit.Text;
                    if (RepNo == "" || RepNo == null)
                    {
                        MessageBox.Show("Enter RepNo to Continue");
                        return;
                    }
                    string RepName = RepNameTextEdit.Text;
                    if (RepName == "" || RepName == null)
                    {
                        MessageBox.Show("Enter RepName to Continue");
                        return;
                    }
                    string PhysicalAddress = PhysicalAddressTextEdit.Text;
                    if (PhysicalAddress == "" || PhysicalAddress == null)
                    {
                        MessageBox.Show("Enter PhysicalAddress to Continue");
                        return;
                    }
                    string PostalAddress = PostalAddressTextEdit.Text;
                    if (PostalAddress == "" || PostalAddress == null)
                    {
                        MessageBox.Show("Enter PostalAddress to Continue");
                        return;
                    }
                    string Email = EmailTextEdit.Text;
                    if (Email == "" || Email == null)
                    {
                        MessageBox.Show("Enter Email to Continue");
                        return;
                    }
                    string MobileNo = MobileNoTextEdit.Text;
                    if (MobileNo == "" || MobileNo == null)
                    {
                        MessageBox.Show("Enter MobileNo to Continue");
                        return;
                    }
                    string Telephone = TelephoneTextEdit.Text;
                    if (Telephone == "" || Telephone == null)
                    {
                        MessageBox.Show("Enter Telephone to Continue");
                        return;
                    }
                    string WebURL = WebURLTextEdit.Text;
                    if (WebURL == "" || WebURL == null)
                    {
                        MessageBox.Show("Enter WebURL to Continue");
                        return;
                    }
                    string Status = StatusComboBoxEdit.SelectedItem.ToString();
                    if (Status == "" || Status == null)
                    {
                        MessageBox.Show("Enter Status to Continue");
                        return;
                    }
                    spSelectAllSalesRepTableAdapter.Insert(RepNo, RepName, AppConstant.CompCode, Costcenter, PhysicalAddress, PostalAddress, Email, MobileNo, Telephone, WebURL, Status, Environment.MachineName, AppConstant.UserID);
                    MessageBox.Show("Sales Rep Saved Succesfully");
                    LoadGrid();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Sales Rep " + RepNameTextEdit.Text + " has already been added");
                    }
                    else
                    {

                        MessageBox.Show("Error while saving record");
                        MessageBox.Show(ex.Message);
                    }
                    

                }
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Add Sales Reps", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Privilege Violation.You have insufficient right to  Export Sales reps", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void SelectRecord()
        {
            try
            {

                // var TableName = Convert.ToString(this.gridView1.GetFocusedRowCellValue("TableName"));
                var RepNo = Convert.ToString(this.gridView1.GetFocusedRowCellValue("RepNo"));

                spSelectSalesRepTableAdapter.Fill(dsSalesRep.spSelectSalesRep, RepNo, AppConstant.UserID, Environment.MachineName);
                disableFields();
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
                String RepNo = RepNoTextEdit.Text;
                spSelectAllSalesRepTableAdapter.Delete(RepNo, AppConstant.UserID, Environment.MachineName);
                MessageBox.Show("Sales Rep Deleted Succesfully");
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Privilege Violation.You have insufficient right to Delete  Sales reps", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            SelectRecord();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            enableFields();
        }
    }
}