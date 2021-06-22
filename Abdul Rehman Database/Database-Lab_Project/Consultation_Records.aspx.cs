using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database_Lab_Project.DAL;

namespace shope_wise
{
    public partial class Consultation_Records : System.Web.UI.Page
    {
        public List<Consultant_record_infos> rec_list { set; get; }
        Consultation_Records_DAL temp_log = new Consultation_Records_DAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            rec_list = temp_log.retriveconsultData();
        }
    }
}