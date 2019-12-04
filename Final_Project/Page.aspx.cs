using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Final_Project
{
    public partial class Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pid = Request.QueryString["pageid"];
            Database db = new Database();
            List<Dictionary<String, String>> rs = db.searchpage(pid);

            foreach (Dictionary<String, String> row in rs)
            {
                viewpage.InnerHtml = "<strong>Page Title:</strong>"+row["pagetitle"]+"<br/>";
                viewpage.InnerHtml += "<strong>Page Body:</strong>"+row["pagebody"];
            }
        }

        protected void publish(object sender, EventArgs e)
        {
            Database db = new Database();
            db.updatestatus(Request.QueryString["pageid"],1);
            
            Server.Transfer("Default.aspx");
        }
        protected void unpublish(object sender, EventArgs e)
        {
            Database db = new Database();
            db.updatestatus(Request.QueryString["pageid"], 2);
            Server.Transfer("Default.aspx");

        }
    }
}