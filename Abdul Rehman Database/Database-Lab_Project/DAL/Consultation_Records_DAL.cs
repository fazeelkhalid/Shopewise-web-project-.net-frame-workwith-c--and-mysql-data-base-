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
    public class Consultation_Records_DAL
    {
        public List<Consultant_record_infos> cr_items { get; set; }

        public List<Consultant_record_infos> retriveconsultData()
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["shopwise_connection"].ToString());

            sqlCon.Open();
            SqlCommand cm = new SqlCommand("select * from Consultation_Records", sqlCon);
            SqlDataReader sdr = cm.ExecuteReader();
            //direct queries run
            cr_items = new List<Consultant_record_infos>();
            while (sdr.Read())
            {
                Consultant_record_infos temp = new Consultant_record_infos();
                temp.Request_Id = Convert.ToString(sdr.GetInt32(0));
                temp.Consulter_Id = Convert.ToString(sdr.GetInt32(1));
                temp.Consultant_Id = Convert.ToString(sdr.GetInt32(2));
                temp.Product_Id = Convert.ToString(sdr.GetInt32(3));
                temp.Status = sdr.GetString(4);
                temp.Recommended_Product_Id = Convert.ToString(sdr.GetInt32(5));
                temp.Consultant_rating = Convert.ToString(sdr.GetDouble(6));
                temp.Consulter_rating = Convert.ToString(sdr.GetInt32(7));
                temp.Date = sdr.GetString(8);
                cr_items.Add(temp);
            }

            sqlCon.Close();

            return cr_items;
        }
    }
}