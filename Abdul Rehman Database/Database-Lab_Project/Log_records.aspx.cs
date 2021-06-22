using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database_Lab_Project.DAL;

namespace shope_wise
{
    public partial class Log_records : System.Web.UI.Page
    {
        public List<logs_infos> log_list { set; get; }
        Logs_DAL temp_log = new Logs_DAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            log_list = temp_log.retrivelogData();
        }
    }
}