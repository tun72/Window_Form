using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobPortal.User
{
    public partial class JobDetail : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DataTable dt;
        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public int jobCount = 0;
        public string jobTitle = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["id"] != null)
            {
                showJobDetails();
                DataBind();
            }


            else
            {
                Response.Redirect("JobLiting.aspx");
            }
        }

        private void showJobDetails()
        {



            int currentJobId = Convert.ToInt32(Request.QueryString["JobId"]);

            // Example SQL query to fetch related jobs based on category

  





            con = new SqlConnection(str);
            
            string query = @"SELECT*
                            FROM Jobs
                            JOIN Category ON Jobs.CategoryId = Category.CategoryId
                            LEFT JOIN EMployees as e ON e.EmployeeId = Jobs.EmployeeId
                            WHERE Jobs.JobId = @id
                            ";


            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Request.QueryString["id"]);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            DataList1.DataSource = dt;
            DataList1.DataBind();

            int categoryId = Convert.ToInt32(dt.Rows[0]["CategoryId"]);


            string query2 = @"SELECT TOP 5 JobId, Title, CompanyName, CompanyImage, State, Country, Salary
FROM Jobs JOIN Category ON Jobs.CategoryId = Category.CategoryId LEFT JOIN EMployees as e ON e.EmployeeId = Jobs.EmployeeId WHERE Jobs.CategoryId=@CategoryId and JobId != @JobId";

           

            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@CategoryId", categoryId);
            cmd2.Parameters.AddWithValue("@JobId", Request.QueryString["id"]);


            //cmd.Parameters.AddWithValue("@JobId", Request.QueryString["id"]);



            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd2); ;
            DataTable dt2 = new DataTable();
            dataAdapter.Fill(dt2);



          


            dlRelatedJobs.DataSource = dt2;
            dlRelatedJobs.DataBind();

            jobTitle = dt.Rows[0]["Title"].ToString();


        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {

            if (e.CommandName == "ApplyJob")
            {
                if (Session["Username"] != null)
                {
                    try
                    {
                        con = new SqlConnection(str);
                        string query = @"Insert into AppliedJobs values (@JobId, @UserId)";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@JobId", Request.QueryString["id"]);
                        cmd.Parameters.AddWithValue("@UserId", Session["userId"]);
                        con.Open();
                        int r = cmd.ExecuteNonQuery();
                        if (r > 0)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "Job applied successfully";
                            lblMsg.CssClass = "alert alert-success";
                            showJobDetails();


                        }
                        else
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "Cannot apply the job please try after sometime...!";
                            lblMsg.CssClass = "alert alert-danger";

                        }

                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('" + ex.Message + "'); </script>");
                    }
                    finally
                    {
                        con.Close();


                    }
                }
                else
                {
                    Response.Redirect("Login");
                }
            }
        }

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (Session["Username"] != null)
            {
                LinkButton btnAppliedJob = e.Item.FindControl("ApplyJob") as LinkButton;
                if (isApplied())
                {
                    btnAppliedJob.Enabled = false;
                    btnAppliedJob.Text = "Applied";
                }
                else
                {
                    btnAppliedJob.Enabled = true;
                    btnAppliedJob.Text = "Applie Now";
                }
            }
        }

        bool isApplied()
        {
            con = new SqlConnection(str);
            string query = @"select * from AppliedJobs where UserId=@userId and JobId=@JobId";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@JobId", Request.QueryString["id"]);
            cmd.Parameters.AddWithValue("@UserId", Session["UserId"]);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        protected string GetImageUrl(Object url)
        {
            string url1 = "";
            if (string.IsNullOrEmpty(url.ToString()) || url == DBNull.Value)
            {

                url1 = "~/Images/No_image.png";
            }
            else
            {

                url1 = string.Format("~/{0}", url);
            }
            return ResolveUrl(url1);
        }
    }
}