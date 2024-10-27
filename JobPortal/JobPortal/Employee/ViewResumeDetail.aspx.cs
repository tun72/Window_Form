using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobPortal.Employee
{
    public partial class ViewResumeDetail : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["EmployeeId"] == null)
            //{
            //    Response.Redirect("../User/Login");
            //}

            if (Request.QueryString["JobId"] == null)
            {
                Response.Redirect("ViewResumes.aspx");
            }

            if (!IsPostBack)
            {
                ShowAppliedJob();
            }

        }

        private void ShowAppliedJob()
        {
            string query = string.Empty;
            con = new SqlConnection(str);
            query = @"SELECT 
                        ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS [Sr.No], 
                        aj.AppliedJobId, 
                        e.CompanyName, 
                        e.CompanyImage, 
                        aj.JobId, 
                        j.Title, 
                        u.Phone, 
                        u.FullName, 
                        u.Email, 
                        u.Resume
                    FROM 
                        AppliedJobs aj
                    INNER JOIN 
                        [User] u ON aj.UserId = u.UserId 
                    INNER JOIN 
                        Jobs j ON aj.JobId = j.JobId
                    INNER JOIN 
                        Employees e ON j.EmployeeId = e.EmployeeId
                    WHERE
                        j.EmployeeId = '" + Session["EmployeeId"] + "' AND j.JobId = '" + Request.QueryString["JobId"] + "'";
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
            ShowAppliedJob();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {

                GridViewRow row = GridView1.Rows[e.RowIndex];
                int appliedJobId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
                con = new SqlConnection(str);
                cmd = new SqlCommand("Delete from AppliedJobs where AppliedJobId = @id", con);
                cmd.Parameters.AddWithValue("@id", appliedJobId);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    lblMsg.Text = "Resume Delete Successfully";
                    lblMsg.CssClass = "alert alert-success";

                }
                else
                {
                    lblMsg.Text = "Can't Delete this Jobs";
                    lblMsg.CssClass = "alert alert-danger";

                }


                GridView1.EditIndex = -1;

                ShowAppliedJob();


            }
            catch (Exception ex)
            {

                Response.Write($"<script>alert({ex.Message})</script>");

            }
            finally
            {
                con.Close();
            }

        }

        


    }
}
