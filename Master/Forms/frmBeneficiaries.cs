using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Master.Class.DataSet;

namespace Master.Forms
{
    public partial class frmBeneficiaries : DevExpress.XtraEditors.XtraForm
    {
        Security _Security = new Security();
        string SecurityModule = "Beneficiaries";
        public frmBeneficiaries()
        {
            InitializeComponent();
        }

        private void frmBeneficiaries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBeneficiaries1.Banks' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'dsBeneficiaries.Countries' table. You can move, or remove it, as needed.

            try
            {
                //AppConstant.CompCode = "001";
                BenefNoTextEdit.ReadOnly = true;
                this.banksTableAdapter.Fill(this.dsBeneficiaries1.Banks);
                BankLookUpEdit.EditValue = dsBeneficiaries1.Banks.DataSet.Tables["Banks"].Rows[0]["BankCode"].ToString();
                this.employeesMasterTableAdapter.Fill(dsBeneficiaries.EmployeesMaster, AppConstant.CompCode);
                EmpNoLookUpEdit.EditValue = dsBeneficiaries.EmployeesMaster.DataSet.Tables["EmployeesMaster"].Rows[0]["EmpNo"].ToString();
                this.countriesTableAdapter.Fill(this.dsBeneficiaries.Countries);
                CountryLookUpEdit.EditValue= dsBeneficiaries.Countries.DataSet.Tables["Countries"].Rows[0]["CountryCode"].ToString();
                LoadGrid();
                CountryLookUpEdit.EditValue = "KE";
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

                this.spSelectAllBeneficiariesTableAdapter.Fill(this.dsBeneficiaries.spSelectAllBeneficiaries,  AppConstant.UserID, Environment.MachineName);
                ClearFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public void SaveRecord()
        {
            try
            {
                this.spSelectAllBeneficiariesTableAdapter.Insert(
                    EmpNoLookUpEdit.EditValue.ToString(),
                    BenefNoTextEdit.Text,
                    DependNameTextEdit.Text,
                    PostalAddressTextEdit.Text,
                    PhysicalAddressTextEdit.Text,
                    TelephoneTextEdit.Text,
                    EmailTextEdit.Text,
                    IDNoTextEdit.Text,
                    RelationshipTextEdit.Text,
                    (this.PhotoPictureEdit.Image != null) ? imageToByteArray(PhotoPictureEdit.Image) : null,
                    Convert.ToDouble(PortionTextEdit.Text),
                    CountryLookUpEdit.EditValue.ToString(),
                    BankLookUpEdit.EditValue.ToString(),
                    BranchLookUpEdit.EditValue.ToString(),
                    AccNoTextEdit.Text,
                    AccNameTextEdit.Text,
                    NarrationTextEdit.Text,
                   
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Beneficiary saved successfully");
                this.spSelectAllBeneficiariesTableAdapter.Fill(this.dsBeneficiaries.spSelectAllBeneficiaries, AppConstant.UserID, Environment.MachineName);
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
                
                    BenefNoTextEdit.Text = "0";
                DependNameTextEdit.Text = "0";
                PostalAddressTextEdit.Text = "0";
                PhysicalAddressTextEdit.Text = "0";
                TelephoneTextEdit.Text = "999 999 999";
                EmailTextEdit.Text = "+254xxxxxxx";
                IDNoTextEdit.Text = "0";
                RelationshipTextEdit.Text = "son";
                    PortionTextEdit.Text = "0";
                    CountryLookUpEdit.EditValue = "KES";
                    AccNoTextEdit.Text = "0";
                AccNameTextEdit.Text = "0";
                NarrationTextEdit.Text = "Beneficiary";
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
                EmpNoLookUpEdit.Enabled = false;
                BenefNoTextEdit.Enabled = false;
                DependNameTextEdit.Enabled = false;
                PostalAddressTextEdit.Enabled = false;
                PhysicalAddressTextEdit.Enabled = false;
                TelephoneTextEdit.Enabled = false;
                EmailTextEdit.Enabled = false;
                IDNoTextEdit.Enabled = false;
                RelationshipTextEdit.Enabled = false;

                PortionTextEdit.Enabled = false;
                CountryLookUpEdit.Enabled = false;
                BankLookUpEdit.Enabled = false;
                BranchLookUpEdit.Enabled = false;
                AccNoTextEdit.Enabled = false;
                AccNameTextEdit.Enabled = false;
                NarrationTextEdit.Enabled = false;
                // EffectiveDateDateEdit.Enabled = false;

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
                EmpNoLookUpEdit.Enabled = true;
                BenefNoTextEdit.Enabled = true;
                DependNameTextEdit.Enabled = true;
                PostalAddressTextEdit.Enabled = true;
                PhysicalAddressTextEdit.Enabled = true;
                TelephoneTextEdit.Enabled = true;
                EmailTextEdit.Enabled = true;
                IDNoTextEdit.Enabled = true;
                RelationshipTextEdit.Enabled = true;

                PortionTextEdit.Enabled = true;
                CountryLookUpEdit.Enabled = true;
                BankLookUpEdit.Enabled = true;
                BranchLookUpEdit.Enabled = true;
                AccNoTextEdit.Enabled = true;
                AccNameTextEdit.Enabled = true;
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

                var BenefNo = Convert.ToString(BenefNoTextEdit.Text);
              

                if (gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete beneficiary  " + BenefNo, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectAllBeneficiariesTableAdapter.Delete(BenefNo, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllBeneficiariesTableAdapter.Fill(this.dsBeneficiaries.spSelectAllBeneficiaries, AppConstant.UserID, Environment.MachineName);
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

                var BenefNo = Convert.ToString(this.gridView1.GetFocusedRowCellValue("BenefNo"));
                this.spSelectBeneficiariesTableAdapter.Fill(this.dsBeneficiaries.spSelectBeneficiaries, BenefNo, AppConstant.UserID, Environment.MachineName);

                disableFields();
            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Beneficiaries", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Beneficiaries", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Beneficiaries", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Beneficiaries", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void BankLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.bankBranchesTableAdapter.Fill(this.dsBeneficiaries1.BankBranches, BankLookUpEdit.EditValue.ToString());
                BranchLookUpEdit.EditValue = dsBeneficiaries1.BankBranches.DataSet.Tables["BankBranches"].Rows[0]["BranchCode"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}