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
using shopewise.DAL;
using Database_Lab_Project.DAL;

namespace abdulrehman
{
    public partial class signup : System.Web.UI.Page
    {
        globalFunctions tempGlobalfun = new globalFunctions();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SignUpButton(object sender, EventArgs e)
        {
            Regex contactCheck = new Regex(@"^[0-9]{11}$");
            string messageStr;
            Label1.Text = "";
            if (Text1.Text == "" || Text2.Text == "" || Text4.Text == "" || Text5.Text == "" || Text6.Text == "" || Text7.Text == "")
            {
                Label1.Text = "Required fields are null";
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }
            else if (Text1.Text.Length > 32)
            {
                Label1.Text = "Name should be in 32 characters";
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }
            else if (Text4.Text.Length > 32)
            { // here password constrains
                Label1.Text = "Password should be in 32 characters";
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }
            else if (Text4.Text != Text5.Text)
            {
                Label1.Text = "Those passwords didn’t match. Try again.";
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }
            else if (Text6.Text.Length > 32)
            {
                Label1.Text = "City name is too long";
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }
            else if (Text7.Text.Length > 80)
            {
                Label1.Text = "Address is too long";
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }
            else if (Text3.Text != "")
            {
                if (!contactCheck.IsMatch(Text3.Text))
                {
                    Label1.Text = "Invalid mobile number";
                    Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                    return;
                }
            }
            if (!tempGlobalfun.ValidatePassword(Text4.Text, out messageStr))
            {
                Label1.Text = messageStr;
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
            }
            else if (!tempGlobalfun.EmailIsValid(Text2.Text))
            {
                Label1.Text = "Invalid email :(";
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
            }
            //else if (!Checkbox2.Checked)
            //{
            //    Label1.Text = "Not Agreed to the terms and Conditions";
            //    Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
            //Checkbox2.Attributes['']Checked = True;
            //    return;
            //}
            else
            {
                Login_SignUp_DAL temp = new Login_SignUp_DAL();

                if (temp.signup_varifier(Text1.Text.Trim(), Text2.Text.Trim(), Text3.Text.Trim(), Text4.Text.Trim(), Text6.Text.Trim(), Text7.Text.Trim()) == 1)
                {
                    Response.Redirect("login.aspx");
                }
                else
                {
                    Label1.Text = "Email or Contact No. already in use for an existing account.";
                    Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                }
            }
        }
    }
}