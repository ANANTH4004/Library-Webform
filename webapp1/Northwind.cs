using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.DynamicData;

namespace webapp1
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
    public class Northwind
    {
        SqlConnection sql = null;
        SqlDataAdapter da = null;
        DataSet ds = null;

        public Northwind()
        {
             sql = new SqlConnection("Data Source=DESKTOP-SF8TDPM\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            // SqlCommand cmd = new SqlCommand("select * from Products", sql);
            // da = new SqlDataAdapter("Select * from Products", sql);
            ds = new DataSet();
        }
        public  DataTable ConnectToProducts()
        {
            da = new SqlDataAdapter("select * from Products", sql);
            da.Fill(ds, "Products");
            DataTable dt = ds.Tables["Products"];
            return dt;
        } 

        public string FindProducts(int ProductID)
        {
            DataTable Product = ConnectToProducts();
            DataColumn[] keyColumns = new DataColumn[1]; ;
            keyColumns[0] = Product.Columns["ProductId"];
            Product.PrimaryKey = keyColumns;
            DataRow dr = Product.Rows.Find(ProductID);
            string ans;
            if (dr != null)
            {
                ans = dr[0].ToString() + " " + dr[1].ToString() + " " + dr[3].ToString();
            }
            else
            {
                ans = "Product Not Found....";
            }
            return ans;
        }
    }
}