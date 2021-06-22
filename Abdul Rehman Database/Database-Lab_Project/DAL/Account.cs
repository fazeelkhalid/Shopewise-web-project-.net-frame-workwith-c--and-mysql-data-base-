using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Database_Lab_Project.DAL
{
    public class Account
    {
        public int Info_Loader(string email, out string Uname, out string Email, out string City, out string Address, out string Phone_no)
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["shopwise_connection"].ToString());

            sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand("info_retriever", sqlCon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@in_Email", email.Trim());
            SqlParameter
                Access = new SqlParameter(),
                Access1 = new SqlParameter(),
                Access2 = new SqlParameter(),
                Access3 = new SqlParameter(),
                Access4 = new SqlParameter(),
                Access5 = new SqlParameter();
            Access.ParameterName = "@out_result";
            Access1.ParameterName = "@out_Name";
            Access2.ParameterName = "@out_Email";
            Access3.ParameterName = "@out_City";
            Access4.ParameterName = "@out_Address";
            Access5.ParameterName = "@out_Phone_no";
            Access.SqlDbType = SqlDbType.Int;
            Access1.SqlDbType = SqlDbType.VarChar;
            Access1.Size = 32;
            Access2.SqlDbType = SqlDbType.VarChar;
            Access2.Size = 32;
            Access3.SqlDbType = SqlDbType.VarChar;
            Access3.Size = 32;
            Access4.SqlDbType = SqlDbType.VarChar;
            Access4.Size = 80;
            Access5.SqlDbType = SqlDbType.VarChar;
            Access5.Size = 32;
            Access.Direction = ParameterDirection.Output;
            Access1.Direction = ParameterDirection.Output;
            Access2.Direction = ParameterDirection.Output;
            Access3.Direction = ParameterDirection.Output;
            Access4.Direction = ParameterDirection.Output;
            Access5.Direction = ParameterDirection.Output;
            sqlcmd.Parameters.Add(Access);
            sqlcmd.Parameters.Add(Access1);
            sqlcmd.Parameters.Add(Access2);
            sqlcmd.Parameters.Add(Access3);
            sqlcmd.Parameters.Add(Access4);
            sqlcmd.Parameters.Add(Access5);


            sqlcmd.ExecuteNonQuery();
            Uname = Access1.Value.ToString();
            Email = Access2.Value.ToString();
            City = Access3.Value.ToString();
            Address = Access4.Value.ToString();
            Phone_no = Access5.Value.ToString();
            int res = Convert.ToInt32(Access.Value);
            sqlCon.Close();
            return res;
        }

        public int Info_Updator(string email, string Uname, string Phone_no, string City, string Address, string Email, string password, string NPassword)
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["shopwise_connection"].ToString());

            sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand("info_update", sqlCon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@in_old_Email", email.Trim());
            sqlcmd.Parameters.AddWithValue("@in_old_pword", password.Trim());
            sqlcmd.Parameters.AddWithValue("@in_Name", Uname.Trim());
            sqlcmd.Parameters.AddWithValue("@in_Password", NPassword.Trim());
            sqlcmd.Parameters.AddWithValue("@in_City", City.Trim());
            sqlcmd.Parameters.AddWithValue("@in_Address", Address.Trim());
            sqlcmd.Parameters.AddWithValue("@in_New_Email", Email.Trim());
            sqlcmd.Parameters.AddWithValue("@in_Phone_no", Phone_no.Trim());
            SqlParameter Access = new SqlParameter();
            Access.ParameterName = "@out_result";
            Access.SqlDbType = SqlDbType.Int;
            Access.Direction = ParameterDirection.Output;
            sqlcmd.Parameters.Add(Access);

            sqlcmd.ExecuteNonQuery();
            int res = Convert.ToInt32(Access.Value);
            sqlCon.Close();
            return res;

        }

    }
}