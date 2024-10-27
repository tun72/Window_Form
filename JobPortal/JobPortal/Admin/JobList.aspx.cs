using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobPortal.Admin
{
    public partial class JobList : System.Web.UI.Page
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
                ShowJob();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowJob();


        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            ShowJob();
        }

        private void ShowJob()
        {
            string query = string.Empty;

            con = new SqlConnection(str);
            query = @"
            SELECT
    ROW_NUMBER() OVER(ORDER BY(SELECT 1)) AS[Sr.No], 
    Jobs.JobId, 
    Jobs.Title, 
    Jobs.NoOfPost, 
    Jobs.Qulification AS Qualification, 
    Jobs.Experience, 
    Jobs.LastDateToApply, 
    Employees.CompanyName,
    Jobs.Country, 
    Jobs.State, 
    Jobs.CreateDate,
  Jobs.isConfirm
FROM
    Jobs
INNER JOIN
    Employees ON Jobs.EmployeeId = Employees.EmployeeId";


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
                int jobId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
                con = new SqlConnection(str);
                cmd = new SqlCommand("Delete from Jobs where JobId = @id", con);
                cmd.Parameters.AddWithValue("@id", jobId);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    lblMsg.Text = "Job Delete Successfully";
                    lblMsg.CssClass = "alert alert-success";

                }
                else
                {
                    lblMsg.Text = "Can't Delete this Jobs";
                    lblMsg.CssClass = "alert alert-danger";

                }

                con.Close();
                GridView1.EditIndex = -1;

                ShowJob();


            }
            catch (Exception ex)
            {
                con.Close();
                Response.Write($"<script>alert({ex.Message})</script>");

            }

        }

        public void confirmJob(Boolean status, String id)
        {
            try
            {
                string query = @"UPDATE Jobs 
                                SET 
                                    isConfirm=@detail
                                WHERE 
                                    JobId = @id";


                con = new SqlConnection(str);
                cmd = new SqlCommand(query, con);

                con.Open();

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@detail", status);


                cmd.Parameters.AddWithValue("@id", id);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    lblMsg.Text = "Job Update Successfully";
                    lblMsg.CssClass = "alert alert-success";

                }
                else
                {
                    lblMsg.Text = "Can't Update this Jobs";
                    lblMsg.CssClass = "alert alert-danger";

                }

                ShowJob();

            }
            catch (Exception ex)
            {
                con.Close();
                Response.Write($"<script>alert({ex.Message})</script>");

            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditJobConfirm")
            {
                confirmJob(true, e.CommandArgument.ToString());

            }
            else if (e.CommandName == "EditJobPending")
            {
                confirmJob(false, e.CommandArgument.ToString());

            }
            else if (e.CommandName == "DetailJob")
            {
                Response.Redirect("/JobDetail?id=" + e.CommandArgument.ToString());

            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.ID = e.Row.RowIndex.ToString();
                if (Request.QueryString["id"] != null)
                {
                    int jobId = Convert.ToInt32(GridView1.DataKeys[e.Row.RowIndex].Values[0]);
                    if (jobId == Convert.ToInt32(Request.QueryString["id"]))
                    {
                        e.Row.BackColor = ColorTranslator.FromHtml("#A1DF2");
                    }
                }
            }
        }
    }
}