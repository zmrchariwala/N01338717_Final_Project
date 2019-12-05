using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                }
            }
            Database db = new Database();
            string query = "select * from pages order by pageid";

            List<Dictionary<String, String>> rs = db.search(query);

            table.InnerHtml = "<table class=\"table table-hover\"><thead><tr><th>Page Title</th><th>Action</th><th>Page published date</th><th>Author</th><th>Page publish status</th></tr></thead><tbody>";
            foreach (Dictionary<String, String> row in rs)
            {
                table.InnerHtml += "<a><tr>";
                table.InnerHtml += "<td><a runat=\"server\" href=\"Page?pageid=" + row["pageid"] + "\" >" + row["pagetitle"]+"</a></td>";
                table.InnerHtml += "<td><a runat=\"server\" href=\"Editpage?pageid=" + row["pageid"] + "\" >Edit</a>/<a runat=\"server\" href=\"Deletepage?pageid=" + row["pageid"] + "\" >Delete</a></td></a>";
                DateTime td = new DateTime();
                td = Convert.ToDateTime(row["pagedate"]);
                table.InnerHtml += "<td>"+td.Date.ToString("d")+"</td>";
                table.InnerHtml += "<td>"+row["pageauthor"]+"</td>";
                table.InnerHtml += "<td>"+row["pagestatus"]+"</td></tr>";



            }
            table.InnerHtml += "</tbody></table>";
            //db.add();
        }
        protected void searchpage(object sender, EventArgs e)
        {
            Database db = new Database();
            string keyword = search.Text.ToString();
            string query = "select * from pages where pagetitle like '%"+ keyword+"%' order by pageid";
            List<Dictionary<String, String>> rs = db.search(query);

            table.InnerHtml = "<table class=\"table table-hover\"><thead><tr><th>Page Title</th><th>Action</th><th>Page published date</th><th>Author</th><th>Page publish status</th></tr></thead><tbody>";
            foreach (Dictionary<String, String> row in rs)
            {
                table.InnerHtml += "<a><tr>";
                table.InnerHtml += "<td><a runat=\"server\" href=\"Page?pageid=" + row["pageid"] + "\" >" + row["pagetitle"] + "</a></td>";
                table.InnerHtml += "<td><a runat=\"server\" href=\"Editpage?pageid=" + row["pageid"] + "\" >Edit</a>/<a runat=\"server\" href=\"Deletepage?pageid=" + row["pageid"] + "\" >Delete</a></td></a>";
                DateTime td = new DateTime();
                td = Convert.ToDateTime(row["pagedate"]);
                table.InnerHtml += "<td>" + td.Date.ToString("d") + "</td>";
                table.InnerHtml += "<td>" + row["pageauthor"] + "</td>";
                table.InnerHtml += "<td>" + row["pagestatus"] + "</td></tr>";

            }
            table.InnerHtml += "</tbody></table>";



        }
        protected void lookup(object sender, EventArgs e)
        {
            table.Attributes.Add("style","color:red");
        }
    }
}