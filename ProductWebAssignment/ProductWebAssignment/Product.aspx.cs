using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductWebAssignment
{

    public partial class Product : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = ConfigurationManager.ConnectionStrings["ProductDBConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);

                if(txtProductName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
                {
                    Response.Write("<script>alert('Data Can't Save')</script>");
                    return;
                }
                string query = @"Insert into [Product] (ProductName, Price, Quantity) values (@ProductName, @Price, @Quantity)";
                cmd = new SqlCommand(query, con);



                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text.Trim());

                con.Open();

                int r = cmd.ExecuteNonQuery();

                if (r == 1)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Insert Successfull ✅";
                    lblMsg.CssClass = "alert alert-success";
                    ShowData();
                    clear();
                }
                else
                {
                    Response.Write("<script>alert('Data Can't Save')</script>");
                }

            }
            catch (SqlException ex)
            {
                Response.Write("<script>alert('Data Can't Save')</script>");


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


        private void ShowData()
        {


            GridView1.DataBind();
        }

        private void clear()
        {
            txtProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("Update.aspx");

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delete.aspx");
        }


    }
}

/*
 © [2024] [Copyright Tun72]. All rights reserved.
 */