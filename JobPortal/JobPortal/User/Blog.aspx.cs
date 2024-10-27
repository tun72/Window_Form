using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace JobPortal.User
{
    public partial class Blog : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DataTable dt;

        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {

            con = new SqlConnection(str);
            string query = @"SELECT*
                            FROM Blogs
                           
                            ";


            cmd = new SqlCommand(query, con);
    

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            dlBlog.DataSource = dt;
            dlBlog.DataBind();



        }
    }
}