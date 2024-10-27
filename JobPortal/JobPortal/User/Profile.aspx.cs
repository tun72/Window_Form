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
    public partial class Profile : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string query;
        DataTable dt;

        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("../User/Login");
            }

            if (!IsPostBack)
            {
                ShowUserProfile();
            }

        }

        private void ShowUserProfile()
        {
            con = new SqlConnection(str);
            string query = "Select UserId,UserName, FullName, Address, Phone, Email, Country, Resume from [User] where Username=@username";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("username", Session["Username"]);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dlProfile.DataSource = dt;
            dlProfile.DataBind();
            
           
        }

        protected void dlProfile_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName == "EditUserProfile")
            {
                Response.Redirect($"ResumeBuild.aspx?id={e.CommandArgument.ToString()}");
            }
        }
    }
}