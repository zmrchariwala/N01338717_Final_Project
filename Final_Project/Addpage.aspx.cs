using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class Addpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    Database db = new Database();
                    pages pg = new pages();
                    pg.Setpagetitle(page_title.Text.ToString());
                    pg.Setpagebody(page_body.Text.ToString());
                    pg.Setpageauthor(page_author.Text.ToString());
                    db.addpage(pg);
                    Response.Redirect("Default.aspx");
                }
            }


        }
    }
}