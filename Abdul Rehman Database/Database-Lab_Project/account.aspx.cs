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

namespace shopewise
{
    public partial class account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //here you need to get customer name, email, city, address and phone number from database
            //and use following instruction
            //Label.Text= "fazeel";

            Session["Email_session"] = "asadnawaz@yahoo.com"; // default session

            Account temp = new Account();
            string val1, val2, val3, val4, val5;
            if (temp.Info_Loader(Session["Email_session"].ToString(), out val1, out val2, out val3, out val4, out val5) == 1)
            {
                Label1.Text = val1;
                Label2.Text = val2;
                Label3.Text = val3;
                Label4.Text = val4;
                Label5.Text = val5;
            }
        }

        protected void updateButton(object sender, EventArgs e)
        {
            if (Text6.Text.Trim() == "")
            {
                Label6.Text = "Verification required!! Please enter password";
                Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }

            Label6.Text = "";
            Regex contactCheck = new Regex(@"^[0-9]{11}$");
            globalFunctions tempGlobalfun = new globalFunctions();


            if (Text1.Text.Trim() != "" && Text1.Text.Length > 32)
            {
                Label6.Text = "User name is too long";
                Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }
            //update user name
            //                string email = Session["Email_session"].ToString();

            if (Text2.Text.Trim() != "")
            {
                if (contactCheck.IsMatch(Text2.Text) == false)
                {
                    Label6.Text = "Invalid mobile number";
                    Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                    return;
                }
            }

            if (Text3.Text.Trim() != "" && Text3.Text.Length > 32)
            {
                Label6.Text = "City name is too long";
                Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }

            if (Text4.Text.Trim() != "" && Text4.Text.Length > 32)
            {
                Label6.Text = "Address is too long";
                Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }

            if (Text5.Text.Trim() != "" && Text5.Text.Length > 32 && !tempGlobalfun.EmailIsValid(Text5.Text))
            {
                Label6.Text = "Invalid Email";
                Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }

            if (Text7.Text.Trim() != "" && Text8.Text.Trim() != "" && Text7.Text == Text8.Text)
            {
                /*
                 if(check is text5.text is present in our user table it basically a password regarding session["email_session"]){
                 * //if not present then show some error in label6 and then return from the function
                 * 
                 * }
                 */
                string messageStr;
                if (!tempGlobalfun.ValidatePassword(Text7.Text, out messageStr))
                {
                    Label6.Text = messageStr;
                    Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                    return;
                }
            }
            else if (Text7.Text.Trim() != "" || Text8.Text.Trim() != "" && Text7.Text != Text8.Text)
            {
                Label6.Text = "Those passwords didn’t match. Try again.";
                Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                return;
            }

            Account temp = new Account();
            int res = temp.Info_Updator(Session["Email_session"].ToString(), Text1.Text, Text2.Text, Text3.Text, Text4.Text, Text5.Text, Text6.Text, Text7.Text);

            if (res == 1)
            {
                Session["Email_session"] = Text5.Text.Trim();
                Response.Redirect("account.aspx");
            }
            else if (res == 2)
            {
                Label6.Text = "The Account is not found in the database.";
                Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
            }
            else if (res == 3)
            {
                Label6.Text = "The Old Password of the Account is incorrect.";
                Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
            }
            else if (res == 4)
            {
                Label6.Text = "The Given New Email or Phone no is already in use by another Account.";
                Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
            }
        }

        protected void Logout(object sender, EventArgs e)
        {
            Session.Remove("Email_session");
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
            Response.Redirect("login.aspx");
        }
    }
}