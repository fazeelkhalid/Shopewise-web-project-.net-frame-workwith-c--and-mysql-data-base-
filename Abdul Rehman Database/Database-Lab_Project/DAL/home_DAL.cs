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

namespace Database_Lab_Project.DAL
{
    public class home_DAL
    {

        public List<product> itemsList { get; set; }

        public List<product> retriveProductData()
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["shopwise_connection"].ToString());

            sqlCon.Open();
            SqlCommand cm = new SqlCommand("select * from Products where Product_ID between 4 and 15", sqlCon);
            SqlDataReader sdr = cm.ExecuteReader();
            //direct queries run
            itemsList = new List<product>();
            while (sdr.Read())
            {
                product temp = new product();
                temp.product_Id = Convert.ToString(sdr.GetInt32(0));
                temp.product_Name = sdr.GetString(1);
                temp.product_price = Convert.ToString(sdr.GetDouble(2));
                temp.product_description = sdr.GetString(3);
                temp.product_rating = Convert.ToString(sdr.GetDouble(4));
                temp.product_seller_id = Convert.ToString(sdr.GetInt32(5));
                temp.product_shop_location = sdr.GetString(6);
                temp.product_profileImage = sdr.GetString(7);
                temp.product_demoImage = sdr.GetString(8);
                temp.product_no_of_sales = Convert.ToString(sdr.GetInt32(9));
                itemsList.Add(temp);
            }

            sqlCon.Close();

            return itemsList;
        }
    }
}