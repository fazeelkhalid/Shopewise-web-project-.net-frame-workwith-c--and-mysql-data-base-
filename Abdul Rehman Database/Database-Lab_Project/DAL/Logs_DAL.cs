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
    public class Logs_DAL
    {

        public List<logs_infos> log_items { get; set; }

        public List<logs_infos> retrivelogData()
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["shopwise_connection"].ToString());

            sqlCon.Open();
            SqlCommand cm = new SqlCommand("select * from logs_data", sqlCon);
            SqlDataReader sdr = cm.ExecuteReader();
            //direct queries run
            log_items = new List<logs_infos>();
            while (sdr.Read())
            {
                logs_infos temp = new logs_infos();
                temp.logs_Id = Convert.ToString(sdr.GetInt32(0));
                temp.logs_Account_Id = Convert.ToString(sdr.GetInt32(1));
                temp.logs_Account_Name = sdr.GetString(2);
                temp.logs_Account_email = sdr.GetString(3);
                temp.logs_Location = sdr.GetString(4);
                temp.logs_Device = sdr.GetString(5);
                temp.logs_Time = sdr.GetString(6);
                log_items.Add(temp);
            }

            sqlCon.Close();

            return log_items;
        }
    }
}