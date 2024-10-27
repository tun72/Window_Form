using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobPortal.User
{
    public partial class ResumeBuild : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("../User/Login.aspx");
            }

            if (!IsPostBack)
            {
                ShowUserProfile();
            }

        }

        private void ShowUserProfile()
        {
            try
            {
                con = new SqlConnection(str);
                string query = "Select * from [User] where UserId=@UserId";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", Request.QueryString["id"]);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    if (sdr.Read())
                    {
                        txtUsername.Text = sdr["UserName"].ToString();
                        txtFullName.Text = sdr["FullName"].ToString();
                        txtEmail.Text = sdr["Email"].ToString();
                        txtPhone.Text = sdr["Phone"].ToString();
                        txtTenth.Text = sdr["TenthGrade"].ToString();
                        txtTwelfth.Text = sdr["TwelfthGrade"].ToString();
                        txtGraduation.Text = sdr["GraduationGrade"].ToString();
                        txtPostGraduation.Text = sdr["PostGraduationGrade"].ToString();
                        txtPhd.Text = sdr["Phd"].ToString();
                        txtWork.Text = sdr["WorkOn"].ToString();
                        txtExperience.Text = sdr["Experience"].ToString();
                        txtAddress.Text = sdr["Address"].ToString();
                        ddlCountry.SelectedValue = sdr["Country"].ToString();

                    }
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "User not Found!";
                    lblMsg.CssClass = "alert alert-danger";
                }

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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["id"] != null)
                {
                    string concatQuery = string.Empty;
                    string filePath = string.Empty;

                    bool isValid = false;
                    con = new SqlConnection(str);
                    if (fuResume.HasFile)
                    {
                        if (Utils.IsValidExtension(fuResume.FileName, true))
                        {
                            concatQuery = "Resume=@Resume,";
                            isValid = true;
                        }
                        else
                        {
                            concatQuery = string.Empty;
                        }

                    }
                    else
                    {
                        concatQuery = string.Empty;
                    }

                    // Define the base query
                    string query = @"Update [User] set UserName=@Username, FullName=@Name, Email=@Email, Phone=@Mobile, 
                TenthGrade=@TenthGrade, TwelfthGrade=@TwelfthGrade, GraduationGrade=@GraduationGrade, 
                PostGraduationGrade=@PostGraduationGrade, Phd=@Phd, WorkOn=@WorksOn, 
                Experience=@Experience, " + concatQuery +
                                    "Address=@Address, Country=@Country where UserId=@UserId";

                    // Create the SqlCommand object with the query and connection
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Add parameters to the SqlCommand
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Mobile", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenthGrade", txtTenth.Text.Trim());
                    cmd.Parameters.AddWithValue("@TwelfthGrade", txtTwelfth.Text.Trim());
                    cmd.Parameters.AddWithValue("@GraduationGrade", txtGraduation.Text.Trim());
                    cmd.Parameters.AddWithValue("@PostGraduationGrade", txtPostGraduation.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phd", txtPhd.Text.Trim());
                    cmd.Parameters.AddWithValue("@WorksOn", txtWork.Text.Trim());
                    cmd.Parameters.AddWithValue("@Experience", txtExperience.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@Country", ddlCountry.SelectedValue);
                    cmd.Parameters.AddWithValue("@UserId", Request.QueryString["id"]);

                    if (fuResume.HasFile)
                    {
                        if(Utils.IsValidExtension(fuResume.FileName, true))
                        {
                            Guid obj = Guid.NewGuid();
                            filePath = "Resumes/" + obj.ToString() + fuResume.FileName;
                            fuResume.PostedFile.SaveAs(Server.MapPath("~/Resumes/") + obj.ToString() + fuResume.FileName);
                            cmd.Parameters.AddWithValue("@Resume", filePath);
                        } else
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "Please select .doc, .docx, .pdf file for resume.";
                            lblMsg.CssClass = "alert alert-danger";

                        }
                       
                    }
                    else
                    {
                        isValid = true;

                    }
                    if (isValid)
                    {
                        con.Open();
                        int r = cmd.ExecuteNonQuery();
                        if (r > 0)
                        {
                            Session["UserName"] = txtUsername.Text;
                            lblMsg.Visible = true;
                            lblMsg.Text = "Resume updated Successfully.";
                            lblMsg.CssClass = "alert alert-success";
                        }
                        else
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "Cannot update Resume please try later";
                            lblMsg.CssClass = "alert alert-danger";

                        }
                    }
                    else
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Cannot update Resume please try later";
                        lblMsg.CssClass = "alert alert-danger";
                    }

                }

            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "<b>" + txtUsername.Text.Trim() + "</b>" + " username already exist, try new one ...";
                    lblMsg.CssClass = "alert alert-danger";
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Something went Wrong";
                    lblMsg.CssClass = "alert alert-danger";


                }
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Something went Wrong";
                lblMsg.CssClass = "alert alert-danger";
                Response.Write($"<script>alert({ex.Message})</script>");
            }

            finally
            {
                con.Close();
            }
        }


    }
}