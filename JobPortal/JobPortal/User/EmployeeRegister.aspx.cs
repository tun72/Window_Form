using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobPortal.User
{
    public partial class EmployeeRegister : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                string query = @"Insert into Employees
    (EmployeeName, Email, Password, Position, PhoneNumber, CompanyName, CompanyImage, CompanySite, CompanyAddress, CompanyCountry) 
    values (@EmployeeName, @Email, @Password, @Position, @Phone, @CompanyName, @CompanyImage, @CompanySite, @CompanyAddress, @CompanyCountry)";

                cmd = new SqlCommand(query, con);



                cmd.Parameters.AddWithValue("@EmployeeName", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Position", txtPosition.Text.Trim()); // Static value for position
                cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
                cmd.Parameters.AddWithValue("@CompanyCountry", ddlCountry.SelectedItem.Text); // Correcting the parameter name and assigning the selected text
                cmd.Parameters.AddWithValue("@CompanySite", txtCompanySite.Text.Trim()); // Correcting parameter name
                cmd.Parameters.AddWithValue("@CompanyAddress", txtCompanyAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim()); // Assuming you have this field
                // Assuming you have this field

                if (fuCompanyLogo.HasFile)
                {




                    if (Utils.IsValidExtension(fuCompanyLogo.FileName))
                    {
                        Guid obj = Guid.NewGuid();
                        string imagePath = "/Images/" + obj.ToString() + fuCompanyLogo.FileName;
                        fuCompanyLogo.PostedFile.SaveAs(Server.MapPath("~/Images/") + obj.ToString() + fuCompanyLogo.FileName);
                        cmd.Parameters.AddWithValue("@CompanyImage", imagePath);

                        

                    }
                    else
                    {
                        lblMsg.Visible = true;

                        lblMsg.Text = "Please select .jpg, .jpeg, .png file for logo";
                        lblMsg.CssClass = "alert alert-danger";

                    }



                }
               
                con.Open();

                int r = cmd.ExecuteNonQuery();

                if (r == 1)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Register Successfull ✅";
                    lblMsg.CssClass = "alert alert-success";
                    clear();
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Can't save";
                    lblMsg.CssClass = "alert alert-danger";
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
                    Response.Write($"<script>alert({ex.Message})</script>");


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

        private void clear()
        {
            txtUsername.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtCompanyAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtCompanySite.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtPosition.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty; ;
            ddlCountry.ClearSelection();


        }
    }
}