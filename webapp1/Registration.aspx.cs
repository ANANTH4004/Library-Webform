using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustDAL;

namespace webapp1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Connect c = new Connect();
           bool ans = c.InsertUser(TextBox1.Text, TextBox2.Text);
            if (ans)
            {
                Label4.Text = "User Added Successfully...";
            }
            else
            {
                Console.WriteLine("Some Error Occured....");
            }
        }
    }
}