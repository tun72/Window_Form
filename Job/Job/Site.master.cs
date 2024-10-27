using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Site : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack || !IsPostBack)
        {
            HttpCookie cookie = Request.Cookies["mycookie"];
            if (Session["user"] != null || cookie != null)
            {
                login.Text = "My Profile";
                logout.Text = "Logout";
            }
            else
            {
                login.Text = "Log In";
                logout.Text = "Create My Account";
            }
        }
        
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        if(logout.Text == "Create My Account")
        {
            Response.Redirect("~/Register.aspx");

        }
        else if(logout.Text == "Logout")
        {
            Response.Cookies["mycookie"].Expires = DateTime.Now.AddYears(-1);
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }
    }

    protected void login_Click(object sender, EventArgs e)
    {
        if(login.Text == "Log In") 
        {
                Response.Redirect("~/Login.aspx");
        }
        else if(login.Text == "My Profile")
        {
            Response.Redirect("~/MyProfile.aspx");
        }
    }
}
