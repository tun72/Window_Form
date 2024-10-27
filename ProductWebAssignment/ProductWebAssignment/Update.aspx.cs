using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductWebAssignment
{
    public partial class Update : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = ConfigurationManager.ConnectionStrings["ProductDBConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                if (txtProductName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
                {
                    Response.Write("<script>alert('All fields are required. Data not saved.')</script>");
                    return;
                }

                string query = @"UPDATE [Product] 
                     SET ProductName = @ProductName, 
                         Price = @Price, 
                         Quantity = @Quantity 
                     WHERE Product_Id = @Product_Id"; 

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text.Trim());
                cmd.Parameters.AddWithValue("@Product_Id",txtId.Text.Trim()); 

                con.Open();

                int r = cmd.ExecuteNonQuery();

                if (r == 1)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Update Successful ✅";
                    lblMsg.CssClass = "alert alert-success";
                    GridView1.DataBind(); 
                    clear(); 
                }
                else
                {
                    Response.Write("<script>alert('Update failed.')</script>");
                }
            }
            catch (SqlException ex)
            {
                Response.Write("<script>alert('SQL Error: Data update failed.')</script>");
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
            txtProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;

        }

       

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                if (string.IsNullOrEmpty(txtId.Text.Trim()))
                {
                    Response.Write("<script>alert('Please enter a Product Id.')</script>");
                    return;
                }

                string query = "SELECT ProductName, Price, Quantity FROM Product WHERE Product_Id = @Product_Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Product_Id", txtId.Text.Trim());

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // Read the first row (should be only one row for a unique Product_Id)
                    txtProductName.Text = reader["ProductName"].ToString();
                    txtPrice.Text = reader["Price"].ToString();
                    txtQuantity.Text = reader["Quantity"].ToString();

                    lblMsg.Visible = true;
                    lblMsg.Text = "Product found!";
                    lblMsg.CssClass = "alert alert-success";
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Product not found!";
                    lblMsg.CssClass = "alert alert-danger";

                    // Optionally, clear the form fields if the product isn't found
                    clear();
                }
            }
            catch (SqlException ex)
            {
                Response.Write("<script>alert('SQL Error: Could not retrieve data.')</script>");
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

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");

        }
    }
}