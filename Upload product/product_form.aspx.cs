using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shope_wise
{
    public partial class product_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void addProduct(object sender, EventArgs e)
        {
            // I have checked that is file upload or not now your task is to check that is other info updated or not 
            warningLabel.Text = ""; // you will display any warning in warningLabel box

            if (!productProfile.HasFile) // check is profile image uploded
            {
                warningLabel.ForeColor = System.Drawing.Color.White;
                warningLabel.Text = "Please select an profile image";
                return;
            }
            else if (!DemoFile.HasFile)
            { // check if demo image uploaded

                warningLabel.ForeColor = System.Drawing.Color.White;
                warningLabel.Text = "Please select an demo image";
                return;
            }
            else if (Text1.Text == "" || Text2.Text=="" ||Text3.Text == "" || Text4.Text == "" || Text5.Text == "")
            {

                warningLabel.ForeColor = System.Drawing.Color.White;
                warningLabel.Text = "Required fields are empty";
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(Text2.Text, "[^0-9]")) {

                warningLabel.ForeColor = System.Drawing.Color.White;
                warningLabel.Text = "Price is not valid";
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(Text3.Text, "[^0-9]"))
            {
                warningLabel.ForeColor = System.Drawing.Color.White;
                warningLabel.Text = "Seller id is not valid";
                return;
            }
            else {
                string ProfileImageextension = System.IO.Path.GetExtension(productProfile.FileName);
                //check is user try to enter image for productProfile
                if (ProfileImageextension == ".eps" || ProfileImageextension == ".png" || ProfileImageextension == ".tif" || ProfileImageextension == ".jpeg" || ProfileImageextension == ".jpg" || ProfileImageextension == ".bmp" || ProfileImageextension == ".tiff")
                {
                    ProfileImageextension = System.IO.Path.GetExtension(DemoFile.FileName);
                    //check is user try to enter image for DemoFile
                    if (ProfileImageextension == ".eps" || ProfileImageextension == ".png" || ProfileImageextension == ".tif" || ProfileImageextension == ".jpeg" || ProfileImageextension == ".jpg" || ProfileImageextension == ".bmp" || ProfileImageextension == ".tiff")
                    {
                        string path = Server.MapPath("assets\\img\\");
                        string productProfiletemppath = "assets/img/" + productProfile.FileName; //you need to put this path in db
                        string DemoFilepath = "assets/img/" + DemoFile.FileName; //you need to put this path in db

                        //here you need to make DAL file and right function
                        //that enter your product data into database in DAL firstly check is seller id exist if yes then return some number from DAL function'

                    }
                }
            }



        }
    }
}