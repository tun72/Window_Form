using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobPortal.Admin
{
    public partial class ContactList : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string query;
        DataTable dt;

        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("../User/Login");
            }

            if (!IsPostBack)
            {
                ShowContact();
            }

        }

        private void ShowContact()
        {
            string query = string.Empty;

            con = new SqlConnection(str);

            query = @"Select Row_Number() over(Order by (Select 1)) as  [Sr.No], ContactId, Name, Email, Subject , Message from Contact";
            cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            ShowContact();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {

                GridViewRow row = GridView1.Rows[e.RowIndex];
                int ContactId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
                con = new SqlConnection(str);
                cmd = new SqlCommand("Delete from Contact where ContactId = @id", con);
                cmd.Parameters.AddWithValue("@id", ContactId);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    lblMsg.Text = "Contact Delete Successfully";
                    lblMsg.CssClass = "alert alert-success";

                }
                else
                {
                    lblMsg.Text = "Contact Deleting fail!";
                    lblMsg.CssClass = "alert alert-danger";

                }

                con.Close();
                GridView1.EditIndex = -1;

                ShowContact();


            }
            catch (Exception ex)
            {
                con.Close();
                Response.Write($"<script>alert({ex.Message})</script>");

            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditJob")
            {
                Response.Redirect("AddJobs.aspx?id=" + e.CommandArgument.ToString());
            }
        }
    }

}
 
