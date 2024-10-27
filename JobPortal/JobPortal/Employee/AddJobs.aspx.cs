using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobPortal.Employee
{
    public partial class AddJobs : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string query;
        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            Session["title"] = $"Add Job";

            

            //if (Session["EmployeeId"] == null)
            //{
            //    Response.Redirect("../User/Login");
            //}

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
                query = "Select * from Jobs where JobId = '" + Request.QueryString["id"] + "'";
                cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtJobTitle.Text = reader["Title"].ToString();
                        txtNoPost.Text = reader["NoOfPost"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
                        // Assign other fields as needed, for example:
                        txtQualification.Text = reader["Qulification"].ToString();
                        txtExperience.Text = reader["Experience"].ToString();
                        txtSpecialization.Text = reader["Specilization"].ToString();
                        txtLastDate.Text = Convert.ToDateTime(reader["LastDateToApply"]).ToString("yyyy-MM-dd");
                        txtSalary.Text = reader["Salary"].ToString();
                        ddlJobType.SelectedValue = reader["JobType"].ToString();
                        txtWebsite.Text = reader["Website"].ToString();
                        ddlCountry.SelectedValue = reader["Country"].ToString();
                        txtState.Text = reader["State"].ToString();
                        linkBtnBack.Visible = true;
                        ddlCategory.SelectedValue = reader["CategoryId"].ToString();
                        Session["title"] = "Edit Job";


                    }
                }
                else
                {
                    lblMsg.Text = "Job not found";
                    lblMsg.CssClass = "alert alert-danger";
                }

                reader.Close();
                con.Close();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string type, concatQuery, imagePath = string.Empty;
                bool isValidToExecute = false;

                con = new SqlConnection(str);



                if (Request.QueryString["id"] != null)
                {




                    query = @"UPDATE Jobs 
                                SET 
                                    Title = @Title, 
                                    NoOfPost = @NoOfPost, 
                                    Description = @Description, 
                                    Qulification = @Qulification, 
                                    Experience = @Experience, 
                                    Specilization = @Specilization, 
                                    LastDateToApply = @LastDateToApply,  
                                    Salary = @Salary, 
                                    JobType = @JobType, 
                                   
                                    Website = @Website, 
             
                                   
                                    Country = @Country, 
                                    State = @State,
                                    CategoryId = @CategoryId
                                WHERE 
                                    JobId = @id and EmployeeId = @EmployeeId";
                    type = "updated";

                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Title", txtJobTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@NoOfPost", txtNoPost.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@Qulification", txtQualification.Text.Trim());
                    cmd.Parameters.AddWithValue("@Experience", txtExperience.Text.Trim());
                    cmd.Parameters.AddWithValue("@Specilization", txtSpecialization.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastDateToApply", txtLastDate.Text.Trim());
                    cmd.Parameters.AddWithValue("@Salary", txtSalary.Text.Trim());
                    cmd.Parameters.AddWithValue("@JobType", ddlJobType.SelectedValue.Trim());



                    cmd.Parameters.AddWithValue("@Website", txtWebsite.Text.Trim());

                    cmd.Parameters.AddWithValue("@Country", ddlCountry.Text.Trim());
                    cmd.Parameters.AddWithValue("@State", txtState.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", Request.QueryString["id"]);
                    cmd.Parameters.AddWithValue("@CategoryId", ddlCategory.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@EmployeeId", Session["EmployeeId"]);






                    isValidToExecute = true;

                }
                else
                {
                    type = "saved";

                    query = @"INSERT INTO Jobs (Title, NoOfPost, Description, Qulification, Experience,
           Specilization, LastDateToApply, Salary, JobType, CreateDate, CategoryId,
           EmployeeId, State, Country, Website, isConfirm)
           VALUES (@Title, @NoOfPost, @Description, @Qulification, @Experience,
           @Specilization, @LastDateToApply, @Salary, @JobType, @CreateDate, @CategoryId,
           @EmployeeId, @State, @Country, @Website, @isConfirm)";

                    DateTime time = DateTime.Now;
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Title", txtJobTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@NoOfPost", txtNoPost.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@Qulification", txtQualification.Text.Trim());
                    cmd.Parameters.AddWithValue("@Experience", txtExperience.Text.Trim());
                    cmd.Parameters.AddWithValue("@Specilization", txtSpecialization.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastDateToApply", txtLastDate.Text.Trim());
                    cmd.Parameters.AddWithValue("@Salary", txtSalary.Text.Trim());
                    cmd.Parameters.AddWithValue("@JobType", ddlJobType.SelectedValue.Trim());

                    cmd.Parameters.AddWithValue("@Website", txtWebsite.Text.Trim());

                    cmd.Parameters.AddWithValue("@Country", ddlCountry.Text.Trim());
                    cmd.Parameters.AddWithValue("@State", txtState.Text.Trim());
                    cmd.Parameters.AddWithValue("@CreateDate", time.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@CategoryId", ddlCategory.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@EmployeeId", Session["EmployeeId"]);
                    cmd.Parameters.AddWithValue("@isConfirm", false);




                    isValidToExecute = true;




                }

                if (isValidToExecute)
                {
                    lblMsg.Visible = true;
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        lblMsg.Visible = true;

                        lblMsg.Text = $"Job {type} Successfully";
                        lblMsg.CssClass = "alert alert-success";
                        this.clear();
                    }
                    else
                    {
                        lblMsg.Visible = true;

                        lblMsg.Text = $"Cann't {type} Data";
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

            txtDescription.Text = string.Empty;

            txtExperience.Text = string.Empty;
            txtJobTitle.Text = string.Empty;
            txtNoPost.Text = string.Empty;
            txtQualification.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtSpecialization.Text = string.Empty;
            txtState.Text = string.Empty;
            txtWebsite.Text = string.Empty;
            txtDescription.Text = string.Empty;
            ddlJobType.ClearSelection();
            ddlCountry.ClearSelection();

        }

        //private bool IsValidExtension(string fileName)
        //{
        //    bool isValid = false;
        //    string[] fileExtensions = { ".jpg", "jpeg", ".png" };


        //    isValid = fileExtensions.Where(stringToCheck => fileName.Contains(stringToCheck)).Any();
        //    Console.WriteLine(isValid);
        //    return isValid;
        //}
    }
}
