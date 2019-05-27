using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master.Forms
{
    public partial class frmCompanies : Form
    {
        Security _Security = new Security();
        string SecurityModule = "Companies";
        public frmCompanies()
        {
            InitializeComponent();
        }

        private void frmCompanies_Load(object sender, EventArgs e)
        {
            
           
            try
            {
               
                this.currenciesTableAdapter.Fill(this.dsCompanies.Currencies);
                this.countiesTableAdapter.Fill(this.dsCompanies.Counties);
                this.countriesTableAdapter.Fill(this.dsCompanies.Countries);
                this.spSelectAllCompaniesTableAdapter.Fill(this.dsCompanies.spSelectAllCompanies, AppConstant.UserID, Environment.MachineName);
                ClearFields();
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
        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Delete", AppConstant.UserID))
                {
                    var CompCode = Convert.ToString(CompCodeTextEdit.Text);
              //  var UserID = Convert.ToString(UserNameTextEdit.Text);
                if (CompCode=="")
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to company " + CompCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectCompaniesTableAdapter.spDeleteCompanies(CompCode, "super@live.com", Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllCompaniesTableAdapter.Fill(this.dsCompanies.spSelectAllCompanies, AppConstant.UserID, Environment.MachineName);
                }

                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Companies", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                var CompCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CompCode"));

               
                this.spSelectCompaniesTableAdapter.Fill(this.dsCompanies.spSelectCompanies, CompCode, AppConstant.UserID, Environment.MachineName);
                 disableFields();
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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Companies", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    //if (this.LogoPictureEdit.Image != null)
                    //{
                    //    byte[] imgpic = imageToByteArray(LogoPictureEdit.Image);
                    //}
                    
                    this.spSelectCompaniesTableAdapter.spSaveCompanies(
                    CompCodeTextEdit.Text.ToString(),
                    CompNameTextEdit.Text.ToString(),
                    TelephoneTextEdit.Text.ToString(),
                    FaxTextEdit.Text.ToString(),
                    EmailTextEdit.Text.ToString(),
                    WebsiteTextEdit.Text.ToString(),
                    PostalAddressTextEdit.Text,
                    StreetTextEdit.Text,
                    CountryTextEdit.EditValue.ToString(),
                    CountyTextEdit.EditValue.ToString(),
                    PINNoTextEdit.Text.ToString(),
                    NHIFNoTextEdit.Text,
                    NSSFNoTextEdit.Text,
                  (this.LogoPictureEdit.Image != null) ? imageToByteArray(LogoPictureEdit.Image) : null,
                    BaseCurrTextEdit.EditValue.ToString(),

                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Company saved successfully");
                this.spSelectAllCompaniesTableAdapter.Fill(this.dsCompanies.spSelectAllCompanies, AppConstant.UserID, Environment.MachineName);
                ClearFields();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Companies", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                CompCodeTextEdit.Text = "0";
                    TelephoneTextEdit.Text = "+254xxxxxxx";
                FaxTextEdit.Text = "0";
                EmailTextEdit.Text = "email@example.com";
                WebsiteTextEdit.Text = "0";
                PostalAddressTextEdit.Text = "0";
                StreetTextEdit.Text = "0";
                CountryTextEdit.EditValue = "KE";
                CountyTextEdit.EditValue = "001";
                PINNoTextEdit.Text = "0";
                    NHIFNoTextEdit.Text = "0";
                NSSFNoTextEdit.Text = "0";
                BaseCurrTextEdit.EditValue = "KES";
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
                CompCodeTextEdit.Enabled = false;
                    CompNameTextEdit.Enabled = false;
                TelephoneTextEdit.Enabled = false;
                FaxTextEdit.Enabled = false;
                EmailTextEdit.Enabled = false;
                WebsiteTextEdit.Enabled = false;
                PostalAddressTextEdit.Enabled = false;
                StreetTextEdit.Enabled = false;
                CountryTextEdit.Enabled = false;
                CountyTextEdit.Enabled = false;
                PINNoTextEdit.Enabled = false;
                NHIFNoTextEdit.Enabled = false;
                NSSFNoTextEdit.Enabled = false;
                BaseCurrTextEdit.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void EnableFields()
        {
            try
            {
                CompCodeTextEdit.Enabled = true;
                CompNameTextEdit.Enabled = true;
                TelephoneTextEdit.Enabled = true;
                FaxTextEdit.Enabled = true;
                EmailTextEdit.Enabled = true;
                WebsiteTextEdit.Enabled = true;
                PostalAddressTextEdit.Enabled = true;
                StreetTextEdit.Enabled = true;
                CountryTextEdit.Enabled = true;
                CountyTextEdit.Enabled = true;
                PINNoTextEdit.Enabled = true;
                NHIFNoTextEdit.Enabled = true;
                NSSFNoTextEdit.Enabled = true;
                BaseCurrTextEdit.Enabled = true;
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
                    EnableFields();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Companies", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
