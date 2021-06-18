using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace abdulrehman
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton(object sender, EventArgs e)
        {
            if (Text1.Text == "" || Text2.Text == "")
            {
                Label1.Text = "Required fields are null";
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF324D");
            }
            //here we will simply call DAL functions I'm not putting any restrictions on login and signup page


        }
    }
}