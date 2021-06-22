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


    public class Login_SignUp_DAL
    {
        public int Login_varifier(string email, string password)
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["shopwise_connection"].ToString());

            sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand("check_access", sqlCon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@in_Email", email.Trim());
            sqlcmd.Parameters.AddWithValue("@in_pword", password.Trim());
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

        public int signup_varifier(string name, string email, string phone, string password, string city, string address)
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["shopwise_connection"].ToString());

            sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand("new_person", sqlCon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@in_Name", name.Trim());
            sqlcmd.Parameters.AddWithValue("@in_Password", password.Trim());
            sqlcmd.Parameters.AddWithValue("@in_City", city.Trim());
            sqlcmd.Parameters.AddWithValue("@in_Address", address.Trim());
            sqlcmd.Parameters.AddWithValue("@in_Email", email.Trim());
            sqlcmd.Parameters.AddWithValue("@in_Phone_no", phone.Trim());
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
