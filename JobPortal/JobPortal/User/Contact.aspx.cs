using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobPortal.User
{
    public partial class Contact : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                string query = @"Insert into Contact values (@Name, @Email, @Subject, @Message)";
               cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name.Value.Trim());
                cmd.Parameters.AddWithValue("@Email", email.Value.Trim());
                cmd.Parameters.AddWithValue("@Subject", subject.Value.Trim());
                cmd.Parameters.AddWithValue("@Message", message.Value.Trim());
                con.Open();

                int r = cmd.ExecuteNonQuery();

                if(r == 1)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Thank you for reaching out to us! We have successfully received your message";
                    lblMsg.CssClass = "alert alert-success";
                } else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "We regret to inform you that there was an error processing your recent submission";
                    lblMsg.CssClass = "alert alert-danger";
                }

                clear();

                



            }
            catch (Exception ex) {
                Response.Write($"<script>alert({ex})</script>");
            } finally
            {
                con.Close();
            }
        }

        private void clear()
        {
            name.Value = string.Empty;
            email.Value = string.Empty;
            subject.Value = string.Empty;
            message.Value = string.Empty;

        }
    }
}