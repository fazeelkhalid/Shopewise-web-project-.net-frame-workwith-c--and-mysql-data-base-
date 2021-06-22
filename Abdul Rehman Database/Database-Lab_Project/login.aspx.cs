using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Database_Lab_Project.DAL;

namespace abdulrehman
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton(object sender, EventArgs e)
        {
            Label1.Text = " ";

            if (Text1.Text == "" || Text2.Text == "")
            {
                Label1.Text = "Required fields are null";
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }

            Login_SignUp_DAL temp = new Login_SignUp_DAL();
            if (temp.Login_varifier(Text1.Text, Text2.Text) == 1)
            {
                Session["Email_session"] = Text1.Text.Trim();
                Response.Redirect("account.aspx");
            }
            else
            {
                Label1.Text = "Invalid Email or Password.";
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
            }

            //here we will simply call DAL functions I'm not putting any restrictions on login and signup page

        }
    }
}