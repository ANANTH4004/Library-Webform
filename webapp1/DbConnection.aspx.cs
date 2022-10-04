using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webapp1
{
    public partial class DbConnection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProdId_Click(object sender, EventArgs e)
        {
            Northwind nor = new Northwind();
            int id = Int32.Parse(txtProdId.Text);
            Label1.Text = nor.FindProducts(id);
        }
    }
}