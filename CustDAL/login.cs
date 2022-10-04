using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;
using System.Runtime.InteropServices;

namespace CustDAL
{
    public class login
    {
        public string UserId { get; set; }
        public string Password { get; set; }

    }
    public class Connect
    {
        public bool InsertUser(string userid, string password)
        {
           
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginCnStr"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into LoginDetails(UserId,Password) values(@UserID ,@Password)",sql);
            cmd.Parameters.AddWithValue("@UserID", userid);
            cmd.Parameters.AddWithValue("@Password", password);
            sql.Open();
            bool v = false;
            int id = cmd.ExecuteNonQuery();
            if (id > 0)
            {
                v =  true;
            }
           
            sql.Close();
            sql.Dispose();
            return v;

        }
        public bool ValidateUser(string userid , string password)
        {
            bool res;
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginCnStr"].ConnectionString);
            SqlCommand valid = new SqlCommand("[dbo].[sp_Validate]", sql);
            valid.CommandType = System.Data.CommandType.StoredProcedure;
            valid.Parameters.AddWithValue("@p_UserId", userid);
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@p_Password";
            p1.SqlDbType = System.Data.SqlDbType.VarChar;
            p1.Size = 30;
            p1.Direction = System.Data.ParameterDirection.Output;
            valid.Parameters.Add(p1);
            sql.Open();
            valid.ExecuteNonQuery();
            string ans = p1.Value.ToString();
            
            if (ans == password)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
         public bool IssueBook(string UserID , string bookno)
        {
            bool res = false;
            DataSet ds = new DataSet();
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginCnStr"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Issue", sql);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "Issue");
            DataTable dt = ds.Tables["Issue"];
            DataRow dr = dt.NewRow();
            dr["Book_NO"] = Convert.ToInt32( bookno);
            dr["UserId"] = UserID;
            dr["IssueDate"] = DateTime.Now;
            ds.Tables["Issue"].Rows.Add(dr);
            SqlCommandBuilder sb = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["Issue"]);
            if (i > 0)
            {
                res = true;
            }
            return res;
        }
    }
}
