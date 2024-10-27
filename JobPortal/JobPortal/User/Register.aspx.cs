using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace JobPortal.User
{
    public partial class Register : System.Web.UI.Page
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
                string query = @"Insert into [User] (UserName, Email, Password, FullName, Address, Phone, Country) values (@UserName, @Email, @Password, @FullName, @Address, @Phone, @Country)";
                cmd = new SqlCommand(query, con);



                cmd.Parameters.AddWithValue("@UserName", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Country", ddlCountry.SelectedValue);
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
            catch (SqlException ex) {
                if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "<b>" + txtUsername.Text.Trim() + "</b>" +" username already exist, try new one ...";
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
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty; ;
            ddlCountry.ClearSelection();
                
    
        }
    }
}