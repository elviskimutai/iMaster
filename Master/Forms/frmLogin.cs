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
    public partial class frmLogin : Form
    {
        User _User = new User();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (HasConnection())
                {
                    Login();
                }
           
            else
            {
                MessageBox.Show("Sorry, please check you network connection and try again.");
            }
        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public static bool HasConnection()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Login()
        {
            try
            {
               
                _User.UserName= this.txtUserName.Text.Trim();
                _User.Password = this.txtPassword.Text.Trim();
                if (_User.ValidateUser())
                {
                    AppConstant.UserID = this.txtUserName.Text.Trim();
                   
                        DataSet d = new DataSet();
                        d = _User.SelectCompanies();
                        if(d.Tables["Companies"].Rows[0]["CompCode"].Equals(string.Empty))
                        {
                            MessageBox.Show("You have not registed to any company. Contact Adimin to help out!");
                        }
                        else
                        {
                                try
                                {
                                        if (!(_User.SelectCompanies().Tables["Companies"].Rows[1]["CompCode"].Equals(string.Empty)))
                                        {
                                           layoutControlItem4.ContentVisible = true;
                                           _User.LoadAuthorisedCompanies(this.glCompany);
                                           
                                        }
                             
                                 }
                                catch (Exception)
                                {
                                  AppConstant.CompCode = "001";
                                    this.Hide();
                                    Form1 frm = new Form1();
                                    frm.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Login failed.Please try again.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

           // Form1.ActiveForm.Activate();
           
        }

        private void glCompany_EditValueChanged(object sender, EventArgs e)
        {
            AppConstant.CompCode = glCompany.EditValue.ToString();
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
        

        private void txtPassword_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Login();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

        }
    }
}
