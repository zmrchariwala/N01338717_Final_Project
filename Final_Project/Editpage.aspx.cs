﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class Editpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pid = Request.QueryString["pageid"];
            Database db = new Database();
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    string Pagetitle = page_title.Text.ToString();
                    string Pagebody = page_body.Text.ToString();
                    db.updatepage(pid, Pagetitle, Pagebody);
                    Response.Redirect("Default.aspx");
                }
            }
            
            List<Dictionary<String, String>> rs = db.searchpage(pid);
            foreach (Dictionary<String, String> row in rs)
            {
                page_title.Text = row["pagetitle"];
                page_body.Text = row["pagebody"];
            }


           
        }
       
    }
}