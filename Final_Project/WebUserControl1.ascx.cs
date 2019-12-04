using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            search(db);
        }

        void search(Database db)
        {
            string query = "select * from pages where pagestatus like 'Published' order by pageid";
            List<Dictionary<String, String>> rs = db.search(query);

            menu_items.InnerHtml = "<ul class=\"nav navbar-nav\">";
            foreach (Dictionary<String, String> row in rs)
            {
                menu_items.InnerHtml += "<li><a runat=\"server\" href=\"page.aspx?pageid="+row["pageid"]+"\">"+row["pagetitle"]+"</a></li>";


            }
            menu_items.InnerHtml += "</ul>";


        }
    }
}