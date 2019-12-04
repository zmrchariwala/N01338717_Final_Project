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
                    string Pagetitle = page_title.Text.ToString();
                    string Pagebody = page_body.Text.ToString();
                    Database db = new Database();
                    db.add(Pagetitle, Pagebody);
                    Response.Redirect("Default.aspx");
                }
            }


        }
    }
}