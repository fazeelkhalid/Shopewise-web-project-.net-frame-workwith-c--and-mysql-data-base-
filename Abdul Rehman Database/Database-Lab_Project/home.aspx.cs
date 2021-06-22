using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database_Lab_Project.DAL;

namespace shope_wise
{
    public partial class home : System.Web.UI.Page
    {
        public List<product> Product_list { set; get; }
        public List<Seller_Profile_info> best_seller_list { set; get; }
        home_DAL temp_Home = new home_DAL();
        Best_Seller_Records_DAL temp_Home_best_sellers = new Best_Seller_Records_DAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Product_list = temp_Home.retriveProductData();
            best_seller_list = temp_Home_best_sellers.retrivebestsellerData();
        }
    }
}