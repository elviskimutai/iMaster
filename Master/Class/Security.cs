using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// This class handles all iBusinessCloud security operations such as saving errorlogs and validating user rights
/// </summary>
public class Security
{
    DataSet ds;
    SqlDataAdapter SQAdapter=new SqlDataAdapter();
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    #region Properties
    public String ErrorDesscription { get; set; }
    public String ErrorModule { get; set; }
    public DateTime ErrorDate { get; set; }
    public String Terminus { get; set; }
    public string Usergroup { get; set; }
    public string SecurityModule { get; set; }
    public string Right { get; set; }
    #endregion

    public bool ValidatePrivilege()
    {
        try
        {
            bool result = false;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString))
            {
                using (SqlCommand SqlCommand = new SqlCommand("sp_ValidatePrivilege", con))
                {
                    ds = new DataSet("UserRoles");
                    SqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlCommand.Parameters.Clear();
                    SqlCommand.Parameters.AddWithValue("@UserGroup", AppConstant.UserID);
                    SqlCommand.Parameters.AddWithValue("@SecurityModule", this.SecurityModule);
                    SqlCommand.Parameters.AddWithValue("@UserID",  AppConstant.UserID);
                    SqlCommand.Parameters.AddWithValue("@Terminus",Environment.MachineName);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SQAdapter.SelectCommand = SqlCommand;
                    SQAdapter.Fill(ds, "UserRoles");
                }
            }
            if (this.Right.Equals("View"))
            {
                for (int i = 0; i <= ds.Tables["UserRoles"].Rows.Count; i++)
                {
                    if (Convert.ToBoolean(ds.Tables["UserRoles"].Rows[0]["View"]).Equals(true))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }

                }
            }
            if (this.Right.Equals("Add"))
            {
                for (int i = 0; i <= ds.Tables["UserRoles"].Rows.Count; i++)
                {
                    if (Convert.ToBoolean(ds.Tables["UserRoles"].Rows[0]["Add"]).Equals(true))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            if (this.Right.Equals("Edit"))
            {
                for (int i = 0; i <= ds.Tables["UserRoles"].Rows.Count; i++)
                {
                    if (Convert.ToBoolean(ds.Tables["UserRoles"].Rows[0]["Edit"]).Equals(true))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }

            if (this.Right.Equals("Delete"))
            {
                for (int i = 0; i <= ds.Tables["UserRoles"].Rows.Count; i++)
                {
                    if (Convert.ToBoolean(ds.Tables["UserRoles"].Rows[0]["Delete"]).Equals(true))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            if (this.Right.Equals("Export"))
            {
                for (int i = 0; i <= ds.Tables["UserRoles"].Rows.Count; i++)
                {
                    if (Convert.ToBoolean(ds.Tables["UserRoles"].Rows[0]["Export"]).Equals(true))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            if (this.Right.Equals("Import"))
            {
                for (int i = 0; i <= ds.Tables["UserRoles"].Rows.Count; i++)
                {
                    if (Convert.ToBoolean(ds.Tables["UserRoles"].Rows[0]["Print"]).Equals(true))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }

            }
            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DataSet GetMyViewRoles()
    {
        try
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString))
            {
                using (SqlCommand SqlCommand = new SqlCommand("spSelectMyRoles", con))
                {
                    ds = new DataSet("MyRoles");
                    SqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlCommand.Parameters.Clear();
                    SqlCommand.Parameters.AddWithValue("@UserID", AppConstant.UserID);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SQAdapter.SelectCommand = SqlCommand;
                    SQAdapter.Fill(ds, "MyRoles");
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