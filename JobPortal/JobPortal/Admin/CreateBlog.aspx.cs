using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace JobPortal.Admin
{
    public partial class CreateBlog : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string query;
        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["title"] = $"Add Blog";
            if (!IsPostBack)
            {
                fillData();
            }
        }

        private void fillData()
        {
            if (Request.QueryString["id"] != null)
            {
                con = new SqlConnection(str);
                query = "Select * from Blogs where BlogId = @id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", Request.QueryString["id"]);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtBlogTitle.Text = reader["Title"].ToString();
                        txtBlogContent.Text = reader["Content"].ToString();
                        txtImageUrl.Text = reader["ImageUrl"].ToString() ;


                        ddlCategory.SelectedValue = reader["Category"].ToString();
                        
                        Session["title"] = "Edit Blog";
                    }
                }
                else
                {
                    lblMsg.Text = "Blog not found";
                    lblMsg.CssClass = "alert alert-danger";
                }

                reader.Close();
                con.Close();
            }
        }

        protected void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string queryType;
                bool isValidToExecute = false;

                con = new SqlConnection(str);

                if (Request.QueryString["id"] != null)
                {
                    // Update the blog
                    query = @"UPDATE Blogs 
                                SET 
                                    Title = @Title, 
                                    Content = @Content, 
                                    Category = @Category,
                                    ImageUrl = @ImageUrl
                                WHERE 
                                    BlogId = @id";
                    queryType = "updated";

                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", Request.QueryString["id"]);
                }
                else
                {
                    // Insert new blog
                    query = @"INSERT INTO Blogs (Title, Content, Category, PublishedDate, ImageUrl) 
                              VALUES (@Title, @Content, @Category, GETDATE(), @ImageUrl)";
                    queryType = "saved";

                    cmd = new SqlCommand(query, con);
                }

                cmd.Parameters.AddWithValue("@Title", txtBlogTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@Content", txtBlogContent.Text.Trim());
                cmd.Parameters.AddWithValue("@Category", ddlCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@ImageUrl", txtImageUrl.Text.Trim());


                isValidToExecute = true;

                if (isValidToExecute)
                {
                    lblMsg.Visible = true;
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        lblMsg.Text = $"Blog {queryType} successfully!";
                        lblMsg.CssClass = "alert alert-success";
                        clear();
                    }
                    else
                    {
                        lblMsg.Text = $"Unable to {queryType} blog";
                        lblMsg.CssClass = "alert alert-danger";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message;
                lblMsg.CssClass = "alert alert-danger";
            }
            finally
            {
                con.Close();
            }
        }

        private void clear()
        {
            txtBlogTitle.Text = string.Empty;
            txtBlogContent.Text = string.Empty;
            txtImageUrl.Text = string.Empty;
            ddlCategory.ClearSelection();
        }
    }
}
