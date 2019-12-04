using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class Deletepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }
        protected void delete(object sender, EventArgs e)
        {
            string pid = Request.QueryString["pageid"];
            Database db = new Database();
            db.deletepage(pid);
            Response.Redirect("Default.aspx");

        }
        protected void nodelete(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}