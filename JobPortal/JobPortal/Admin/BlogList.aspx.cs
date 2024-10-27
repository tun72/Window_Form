using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.UI.WebControls;

namespace JobPortal.Admin
{
    public partial class BlogList : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string query;
        DataTable dt;

        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        protected void Page_PreRender(object sender, EventArgs e)
        {

            if (Session["admin"] == null)
            {
                Response.Redirect("../User/Login");
            }

            
            if (!IsPostBack)
            {
                ShowBlogs();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowBlogs();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            ShowBlogs();
        }

        private void ShowBlogs()
        {
            con = new SqlConnection(str);
            query = @"SELECT ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS SrNo,  BlogId, Title, 
                      Category AS CategoryName, 
                      PublishedDate
                      FROM Blogs";
            cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            if (Request.QueryString["id"] != null)
            {
                linkBack.Visible = true;
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                GridViewRow row = GridView1.Rows[e.RowIndex];
                int blogId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
                con = new SqlConnection(str);
                cmd = new SqlCommand("DELETE FROM Blogs WHERE BlogId = @id", con);
                cmd.Parameters.AddWithValue("@id", blogId);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    lblMsg.Text = "Blog Deleted Successfully";
                    lblMsg.CssClass = "alert alert-success";
                }
                else
                {
                    lblMsg.Text = "Unable to delete the blog";
                    lblMsg.CssClass = "alert alert-danger";
                }
                con.Close();
                GridView1.EditIndex = -1;
                ShowBlogs();
            }
            catch (Exception ex)
            {
                con.Close();
                Response.Write($"<script>alert({ex.Message})</script>");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditBlog")
            {
                Response.Redirect("CreateBlog.aspx?id=" + e.CommandArgument.ToString());
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.ID = e.Row.RowIndex.ToString();
                if (Request.QueryString["id"] != null)
                {
                    int blogId = Convert.ToInt32(GridView1.DataKeys[e.Row.RowIndex].Values[0]);
                    if (blogId == Convert.ToInt32(Request.QueryString["id"]))
                    {
                        e.Row.BackColor = ColorTranslator.FromHtml("#A1DF2");
                    }
                }
            }
        }
    }
}
