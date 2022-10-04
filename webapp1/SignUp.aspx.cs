using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustDAL;

namespace webapp1
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            dob.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            string text = fname.Text;
            c.firstName = text;
            c.lastName = lname.Text;
            c.dob = Calendar1.SelectedDate;
            c.city = city.Text;
            c.state = state.Text;
            HttpCookie cookie = new HttpCookie("CustData");
            // cookie.Expires = DateTime.Now.AddMinutes(15);
            // cookie.Values.Add("fName", c.firstName);
            // cookie.Values.Add("lName", c.lastName);
            //cookie.Values.Add("dob1", c.dob.ToLongDateString());
            // cookie.Values.Add("city1", c.city);
            // cookie.Values.Add("state1", c.state);
            cookie.Values.Add("fName", fname.Text);
            cookie.Values.Add("lName", lname.Text);
            cookie.Values.Add("dob1", Calendar1.SelectedDate.ToLongDateString());
            cookie.Values.Add("city1", city.Text);
            cookie.Values.Add("state1", state.Text);
            Response.Cookies.Add(cookie);
            Response.Write("Welcome  " + c.firstName);
            Response.Redirect("~/WelcomeAssign.aspx");
            
                
        }
    }
}