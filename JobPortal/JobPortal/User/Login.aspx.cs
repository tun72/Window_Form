using System;
using System.Configuration;
using System.Data.SqlClient;

namespace JobPortal.User
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);

                string adminEmail = ConfigurationManager.AppSettings["email"];
                string password = ConfigurationManager.AppSettings["password"];


                if (role.SelectedValue.Trim() == "0")
                {




                    if (adminEmail == txtEmail.Text.Trim() && password == txtPassword.Text.Trim())
                    {
                        Session["admin"] = adminEmail;
                        lblMsg.Visible = true;
                        lblMsg.Text = "Login Successful ✅";
                        lblMsg.CssClass = "alert alert-success";
                        Response.Redirect("../Admin/Dashboard.aspx", false);


                    }
                    else
                    {

                        throw new Exception("Authentication Failed");
                    }



                }
                else if (role.SelectedValue.Trim() == "2")
                {




                    string query = @"Select * from Employees where  Email = @Email and Password= @Password";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                    con.Open();

                    reader = cmd.ExecuteReader();



                    if (reader.Read())
                    {
                        Session["Empname"] = reader["EmployeeName"].ToString();
                        Session["EmployeeId"] = reader["EmployeeId"].ToString();
                        lblMsg.Visible = true;
                        lblMsg.Text = "Login Successful ✅";
                        lblMsg.CssClass = "alert alert-success";
                        Response.Redirect("../Employee/Dashboard.aspx", false);

                    }

                    else
                    {

                        throw new Exception("Authentication Failed");
                    }




                }
                else
                {
                    string query = @"Select * from [User] where  Email = @Email and Password= @Password";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                    con.Open();

                    reader = cmd.ExecuteReader();



                    if (reader.Read())
                    {
                        Session["Username"] = reader["Username"].ToString();
                        Session["UserId"] = reader["UserId"].ToString();
                        Session["Email"] = reader["Email"].ToString();

                        lblMsg.Visible = true;
                        lblMsg.Text = "Login Successful ✅";
                        lblMsg.CssClass = "alert alert-success";
                        Response.Redirect("Default.aspx");

                    }

                    else
                    {

                        throw new Exception("Authentication Failed");
                    }

                }

            }
            catch (SqlException ex)
            {

                lblMsg.Visible = true;
                lblMsg.Text = ex.Message;
                lblMsg.CssClass = "alert alert-danger";




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
                clear();
            }
        }

        private void clear()
        {

            txtEmail.Text = string.Empty;

            txtPassword.Text = string.Empty;



        }
    }
}