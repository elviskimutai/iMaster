using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 

    public  class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        DataSet ds = new DataSet();
        SqlDataAdapter SQAdapter = new SqlDataAdapter();
        public bool ValidateUser()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString))
                {
                    using (SqlCommand SqlCommand = new SqlCommand("spValidateUser", con))
                    {
                        ds = new DataSet("Users");
                        SqlCommand.CommandType = CommandType.StoredProcedure;
                        SqlCommand.Parameters.Clear();
                        SqlCommand.Parameters.AddWithValue("@UserName", UserName);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        SQAdapter.SelectCommand = SqlCommand;
                        SQAdapter.Fill(ds, "Users");
                        if (ds.Tables["Users"].Rows.Count > 0)
                        {
                            String CipherString = (ds.Tables["Users"].Rows[0]["Password"]).ToString();
                            if (SkypensionCryptoEngine.Decrypt(CipherString, true).Equals(Password))
                            {
                               
                                return true;
                            }
                        }
                        return false;


                    }
                }
            }
            catch (Exception )
            {
              
                return false;
            }
        }

    public DataSet SelectCompanies()
    {
        try
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString))
            {
                using (SqlCommand SqlCommand = new SqlCommand("spGetCompanies", con))
                {
                    ds = new DataSet("Companies");
                    SqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlCommand.Parameters.Clear();
                    SqlCommand.Parameters.AddWithValue("@UserName", UserName);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SQAdapter.SelectCommand = SqlCommand;
                    SQAdapter.Fill(ds, "Companies");

                    return ds;

                }
            }
        }
        catch (Exception)
        {

            return null;
        }
    }


      public void LoadAuthorisedCompanies(DevExpress.XtraEditors.GridLookUpEdit GridLookUpEdit)
    {
        try
        {
            ds = this.GetAuthorisedCompanies();
            GridLookUpEdit.Properties.ValueMember = "CompCode";
            GridLookUpEdit.Properties.DisplayMember = "CompName";
            GridLookUpEdit.Properties.DataSource = ds.Tables["AuthorisedCompanies"];
            
        }
        catch (Exception)
        {

        }
    }

    public DataSet GetAuthorisedCompanies()
    {
        try
        {
            ds = new DataSet("AuthorisedCompanies");
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand("spSelectAuthorisedCompanies", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@UserName", AppConstant.UserID);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SQAdapter.SelectCommand = cmd;
                    SQAdapter.Fill(ds, "AuthorisedCompanies");
                    return ds;
                }
            }
        }
        catch (Exception)
        {
           
            return null;
        }

    }
}
