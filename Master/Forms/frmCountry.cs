using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master.Forms
{
    public partial class frmCountry : Form
    {
        Security _Security = new Security();
        string SecurityModule = "Countries";
        public frmCountry()
        {
            InitializeComponent();
        }

        private void frmCountry_Load(object sender, EventArgs e)
        {
            try
            {
               
                this.spSelectAllCountriesTableAdapter.Fill(this.dsCountry.spSelectAllCountries, AppConstant.UserID, Environment.MachineName);
                ClearFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateRight("Add", AppConstant.UserID))
                {
                    this.spSelectCountriesTableAdapter.spSaveCountries(
                  CountryCodeTextEdit.Text,
                   CountryNameTextEdit.Text,
                  
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Country saved successfully");
                this.spSelectAllCountriesTableAdapter.Fill(this.dsCountry.spSelectAllCountries, AppConstant.UserID, Environment.MachineName);
                ClearFields();
            }
                else
                {
                MessageBox.Show("Privilege Violation.You have insufficient right to add Countries", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
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
        public void ClearFields()
        {
            try
            {
                CountryCodeTextEdit.Text = "0";
                CountryNameTextEdit.Text = "0";
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
                CountryCodeTextEdit.Enabled = false;
                CountryNameTextEdit.Enabled = false;

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
                CountryCodeTextEdit.Enabled = true;
                CountryNameTextEdit.Enabled = true;




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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Countries", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    var CountryCode = Convert.ToString(CountryCodeTextEdit.Text);

                if (this.gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete country " + CountryCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectCountriesTableAdapter.spDeleteCountries(CountryCode, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllCountriesTableAdapter.Fill(this.dsCountry.spSelectAllCountries, AppConstant.UserID, Environment.MachineName);
                }

                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Countries", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Export Countries", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                string CountryCode = Convert.ToString(this.gridView1.GetFocusedRowCellValue("CountryCode"));

                this.spSelectCountriesTableAdapter.Fill(this.dsCountry.spSelectCountries, CountryCode, AppConstant.UserID, Environment.MachineName);

                disableFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
