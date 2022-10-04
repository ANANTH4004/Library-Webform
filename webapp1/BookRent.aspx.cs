using CustDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webapp1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Connect c = new Connect();
            string userid = (string)Session["UserId"];
            string bookno = DropDownList1.SelectedValue;
            bool ans = c.IssueBook(userid, bookno);
            if (ans)
            {
                Response.Write("Book Issued Successfully...");
            }
            else
            {
                Response.Write("Some Error Occured...");
            }
        }
    }
}