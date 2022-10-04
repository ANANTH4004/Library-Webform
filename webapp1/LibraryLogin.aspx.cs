using CustDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webapp1
{
    public partial class LibraryLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Connect c = new Connect();
          bool res =  c.ValidateUser(TextBox1.Text, TextBox2.Text);
            Session["UserId"] = TextBox1.Text;

            if (res)
            {
                Label3.Text = "Valid User";
                Response.Redirect("~/BookRent.aspx");
            }
            else
            {
                Label3.Text = "Account Not Found SignUp First";
            }
        }
    }
}