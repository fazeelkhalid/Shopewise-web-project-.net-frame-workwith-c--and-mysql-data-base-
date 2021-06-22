using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using Database_Lab_Project.DAL;

namespace Database_Lab_Project.DAL
{
    public class Account_info
    {
        public string Account_Id;
        public string Account_Name;
        public string Account_rating;
        public string Account_profileImage;
        public string Account_type;
    }

    public class Seller_info
    {
        public string Seller_Id;
        public string Seller_Name;
        public string Seller_description;
        public string Seller_rating;
        public string Seller_shop_location;
        public string Seller_profileImage;
        public string Seller_no_of_sales;
    }

    public class Seller_Profile_info
    {
        public string Seller_Id;
        public string Seller_Name;
        public string Seller_description;
        public string Seller_contact;
        public string Seller_email;
        public string Seller_city;
        public string Seller_rating;
        public string Seller_no_of_sales;
        public string Seller_profileImage;
    }

    public class Consultant_infos
    {
        public string Consultant_Id;
        public string Consultant_Name;
        public string Consultant_description;
        public string Consultant_rating;
        public string Consultant_profileImage;
        public string Consultant_no_of_Consultations;
    }

    public class logs_infos
    {
        public string logs_Id;
        public string logs_Account_Id;
        public string logs_Account_Name;
        public string logs_Account_email;
        public string logs_Location;
        public string logs_Device;
        public string logs_Time;
    }

    public class Consultant_record_infos
    {
        public string Request_Id;
        public string Consulter_Id;
        public string Consultant_Id;
        public string Product_Id;
        public string Status;
        public string Recommended_Product_Id;
        public string Consultant_rating;
        public string Consulter_rating;
        public string Date;
    }

    public class Best_Seller_Records_DAL
    {
        public List<Seller_Profile_info> bsd_items { get; set; }

        public List<Seller_Profile_info> retrivebestsellerData()
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["shopwise_connection"].ToString());

            sqlCon.Open();
            SqlCommand cm = new SqlCommand("select * from best_seller_data", sqlCon);
            SqlDataReader sdr = cm.ExecuteReader();
            //direct queries run
            bsd_items = new List<Seller_Profile_info>();
            while (sdr.Read())
            {
                Seller_Profile_info temp = new Seller_Profile_info();
                temp.Seller_Id = Convert.ToString(sdr.GetInt32(0));
                temp.Seller_Name = sdr.GetString(1);
                temp.Seller_description = sdr.GetString(2);
                temp.Seller_contact = sdr.GetString(3);
                temp.Seller_email = sdr.GetString(4);
                temp.Seller_city = sdr.GetString(5);
                temp.Seller_rating = Convert.ToString(sdr.GetDouble(6));
                temp.Seller_no_of_sales = Convert.ToString(sdr.GetInt32(7));
                temp.Seller_profileImage = sdr.GetString(8);
                bsd_items.Add(temp);
            }

            sqlCon.Close();

            return bsd_items;
        }
    }
}