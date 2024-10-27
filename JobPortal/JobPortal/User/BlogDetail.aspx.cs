using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;

namespace JobPortal.User
{
    public partial class BlogDetail : System.Web.UI.Page
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DataTable dt;

        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            int blogId = Convert.ToInt32(Request.QueryString["blogId"]);
            BindBlogDetail(blogId);
        }
        private void BindBlogDetail(int blogId)
        {
            // Make sure you have your database connection initialized properly
            using (SqlConnection con = new SqlConnection(str))
            {
                try
                {
                    // Query to select blog details by BlogId
                    string query = @"SELECT * FROM Blogs WHERE BlogId = @BlogId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add the correct parameter
                        cmd.Parameters.AddWithValue("@BlogId", blogId);

                        // Open the connection
                        con.Open();

                        // Execute the query
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        // Bind the data to the DataList
                        DataList1.DataSource = dt;
                        DataList1.DataBind();
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the error properly (e.g., log the error message to a file or display it in a label)
                    Console.WriteLine(ex.Message);  // Example logging
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/"); // Update with your actual page URL
        }


        // Event handler for "Back" button click

    }
}