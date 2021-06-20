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
namespace shopewise.DAL;

namespace shopewise
{
    public partial class account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //here you need to get customer name, email, city, address and phone number from database
            //and use following instruction
            //Label.Text= "fazeel";

        }
        protected void updateButton(object sender, EventArgs e)
        {
            Label6.Text = "";
            Regex contactCheck = new Regex(@"^[0-9]{11}$");
            globalFunctions tempGlobalfun = new globalFunctions(); 
            if (Text1.Text != "") { 
                if (Text1.Text.Length > 35) {
                    Label6.Text = "User name is too long";
                    Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                    return;
                }
                //update user name
            }
            if (Text2.Text != "")
            { 
                if (!contactCheck.IsMatch(Text2.Text))
                {
                    Label1.Text = "Invalid mobile number";
                    Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                    return;
                }
                //update phone number

            }
            if (Text3.Text != "")
            {
                if (Text3.Text.Length > 35 )
                {
                    Label6.Text = "City name is too long";
                    Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                    return;
                }
                //update city

            }
            if (Text4.Text != "")
            { 
                if (Text3.Text.Length > 35)
                {
                    Label6.Text = "Address is too long";
                    Label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
                    return;
                }
                //update address

            }
            if (Text5.Text != "" && Text6.Text != "" && Text7.Text != "") { 
                /*
                 if(check is text5.text is present in our user table it basically a password regarding session["email_session"]){
                 * //if not present then show some error in label6 and then return from the function
                 * 
                 * }
                 */

                if (!tempGlobalfun.ValidatePassword(Text4.Text, out messageStr)) {
                    Label1.Text = messageStr;
                    Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D"); 
                }
                else if (Text6.Text == Text7.Text) { 
                    //here update password
                }
            }
        }

    }
}