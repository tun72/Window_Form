using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            HttpCookie cookie = Request.Cookies["mycookie"];
            if (Session["user"] != null || cookie != null)
            {
                Response.Redirect("~/MyProfile.aspx");
            }
            panel_job_seeker.Visible = true;
            panel_employeer.Visible = false;
            btn_login_job_seeker.BackColor = System.Drawing.Color.Green;
            if (Request.QueryString["id"] != null)
            {

                if (Request.QueryString["id"].ToString() == "register")
                {
                    llblj.Text = "You have successfully registred.<br/>";
                    panel_job_seeker.Visible = false;
                    panel_employeer.Visible = true;
                    btn_login_employeers.BackColor = System.Drawing.Color.Green;
                    btn_login_job_seeker.BackColor = System.Drawing.Color.White;
                }
            }
        }
    }


    protected void btn_login_job_seeker_Click(object sender, EventArgs e)
    {
        txt_login_seeker_name.Focus();
        panel_job_seeker.Visible = true;
        panel_employeer.Visible = false;
        btn_login_job_seeker.BackColor = System.Drawing.Color.Green;
        btn_login_employeers.BackColor = System.Drawing.Color.White;

    }

    protected void btn_login_employeers_Click(object sender, EventArgs e)
    {
        txt_login_employeer_name.Focus();
        panel_employeer.Visible = true;
        panel_job_seeker.Visible = false;
        btn_login_employeers.BackColor = System.Drawing.Color.Green;
        btn_login_job_seeker.BackColor = System.Drawing.Color.White;

    }
    // login job_seeker
    protected void btn_login_seeker_login_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            //calling databse
            string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbname))
            {
                SqlCommand cmd = new SqlCommand("spJob_seeker_account_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string password = FormsAuthentication.HashPasswordForStoringInConfigFile(txt_login_seeker_name_pass.Text, "SHA1");
                cmd.Parameters.AddWithValue("@user_name", txt_login_seeker_name.Text);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                int returnvalue = (int)cmd.ExecuteScalar();
                if(returnvalue == 1)
                {
                    if (checkbx_login_seeker.Checked)
                    {
                        HttpCookie cookies = new HttpCookie("mycookie"); //creating cookie object where mycookie is cookie name
                        cookies["cuser"] = txt_login_seeker_name.Text;
                        cookies.Expires = DateTime.Now.AddYears(3);
                        Response.Cookies.Add(cookies); // it gives the response in browser
                    }
                    Session["user"] = txt_login_seeker_name.Text;
                    Response.Redirect("~/MyProfile.aspx");
                }
                else
                {
                    llblj.Text = "User name or password is incorrect";
                }
            }
        }
        else
        {
            llblj.Text = "Please fill all the requirements";
        }
    }

    protected void btn_login_employeer_login_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            //calling databse
            string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbname))
            {
                SqlCommand cmd = new SqlCommand("spEmployeers_account_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string password = FormsAuthentication.HashPasswordForStoringInConfigFile(txt_login_employeer_pass.Text, "SHA1");
                cmd.Parameters.AddWithValue("@user_name", txt_login_employeer_name.Text);
                cmd.Parameters.AddWithValue("@pass", password);
                con.Open();
                int returnvalue = (int)cmd.ExecuteScalar();
                if (returnvalue == 1)
                {
                    if (checkbx_login_employeer.Checked)
                    {
                        HttpCookie cookies = new HttpCookie("emycookie");
                        cookies["euser"] = txt_login_employeer_name.Text;
                        cookies.Expires = DateTime.Now.AddYears(3);
                        Response.Cookies.Add(cookies);
                    }
                    Session["euser"] = txt_login_employeer_name.Text;
                    Response.Redirect("~/employeer/Default.aspx");
                }
                else
                {
                    llble.Text = "User name or password is incorrect";
                }
            }
        }
        else
        {
            llble.Text = "Please fill all the requirements";
        }
    }
}