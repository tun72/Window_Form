using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductWebAssignment
{
    public partial class Delete : System.Web.UI.Page
    {

        SqlConnection con;
        SqlCommand cmd;
        string str = ConfigurationManager.ConnectionStrings["ProductDBConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                if (string.IsNullOrEmpty(txtId.Text.Trim()))
                {
                    Response.Write("<script>alert('Please enter a Product Id.')</script>");
                    return;
                }

                string query = "DELETE FROM Product WHERE Product_Id = @Product_Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Product_Id", txtId.Text.Trim());

                con.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Product deleted successfully! ✅";
                    lblMsg.CssClass = "alert alert-success";

                    // Optionally, clear the form fields
                    clear();
                    GridView1.DataBind(); // Refresh the GridView to reflect the deletion
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Product not found or could not be deleted!";
                    lblMsg.CssClass = "alert alert-danger";
                }
            }
            catch (SqlException ex)
            {
                Response.Write("<script>alert('SQL Error: Could not delete data.')</script>");
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('Error: {ex.Message}')</script>");
            }
            finally
            {
                con.Close();
            }

        }

        private void clear()
        {
            txtId.Text = string.Empty;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");
        }
    }
}