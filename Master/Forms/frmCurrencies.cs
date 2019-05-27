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
    public partial class frmCurrencies : Form
    {
        Security _Security = new Security();
        string SecurityModule = "Currencies";
        public frmCurrencies()
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
        private void frmCurrencies_Load(object sender, EventArgs e)
        {
            try
            {
               
                this.spSelectAllCurrenciesTableAdapter.Fill(this.dsCurrencies.spSelectAllCurrencies, AppConstant.UserID, Environment.MachineName);
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
                    
               
                this.spSelectCurrenciesTableAdapter.spSaveCurrencies(
                   CurrCodeTextEdit.Text,
                   CurrDescTextEdit.Text,
                   2,
                    Environment.MachineName,
                    AppConstant.UserID
                    );
                MessageBox.Show("Currency saved successfully");
                this.spSelectAllCurrenciesTableAdapter.Fill(this.dsCurrencies.spSelectAllCurrencies, AppConstant.UserID, Environment.MachineName);
                ClearFields();
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to add Currencies", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                CurrCodeTextEdit.Text = "0";
                CurrDescTextEdit.Text = "0";
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

                CurrDescTextEdit.BringToFront();
                ItemForCurrCode.Enabled = false;
                ItemForCurrDesc.Enabled = false;



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
                CurrCodeTextEdit.Enabled = true;
                CurrDescTextEdit.Enabled = true;
               
                


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
                    MessageBox.Show("Privilege Violation.You have insufficient right to Edit Currencies", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    var CurrCode = Convert.ToString(CurrCodeTextEdit.Text);
               
                if (this.gridView1.SelectedRowsCount < 0)
                {
                    MessageBox.Show("select a record to delete");
                    return;
                }

                if (MessageBox.Show("Do you want to delete currency " + CurrCode, "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {

                }
                else
                {
                    this.spSelectCurrenciesTableAdapter.spDeleteCurrencies(CurrCode, AppConstant.UserID, Environment.MachineName);
                    MessageBox.Show("Record deleted successfully");
                    this.spSelectAllCurrenciesTableAdapter.Fill(this.dsCurrencies.spSelectAllCurrencies, AppConstant.UserID, Environment.MachineName);
                }
                }
                else
                {
                    MessageBox.Show("Privilege Violation.You have insufficient right to delete Currencies", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        MessageBox.Show("Privilege Violation.You have insufficient right to Export Currencies", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
           
        }
    
    }
}
