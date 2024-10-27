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

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            HttpCookie cookie = Request.Cookies["mycookie"];
            if (Session["user"] != null || cookie != null)
            {
                Response.Redirect("~/Default.aspx");
            }
            txt_register_job_seeker_email.Focus();
            rpanel_job_seeker.Visible = true;
            rpanel_employeer.Visible = false;
            btn_register_job_seeker.BackColor = System.Drawing.Color.Green;
            btn_register_employeers.BackColor = System.Drawing.Color.White;
        }
    }

    protected void btn_register_job_seeker_Click(object sender, EventArgs e)
    {
        txt_register_job_seeker_email.Focus();
        rpanel_job_seeker.Visible = true;
        rpanel_employeer.Visible = false;
        btn_register_job_seeker.BackColor = System.Drawing.Color.Green;
        btn_register_employeers.BackColor = System.Drawing.Color.White;
    }

    protected void btn_register_employeers_Click(object sender, EventArgs e)
    {
        txt_register_employeer_email.Focus();
        rpanel_job_seeker.Visible = false;
        rpanel_employeer.Visible = true;
        btn_register_job_seeker.BackColor = System.Drawing.Color.White;
        btn_register_employeers.BackColor = System.Drawing.Color.Green;
    }

    //Registration Database For Job_seeker


    protected void btn_register_job_seeker_go_register_Click(object sender, EventArgs e)
    {
        if (Page.IsValid && txt_register_job_seeker_checkbox.Checked)
        {
            string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbname))
            {
                SqlCommand cmd = new SqlCommand("spJob_seeker_account_info", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string password = FormsAuthentication.HashPasswordForStoringInConfigFile(txt_register_job_seeker_pass.Text, "SHA1");
                cmd.Parameters.AddWithValue("@email", txt_register_job_seeker_email.Text);
                cmd.Parameters.AddWithValue("@user_name", txt_register_job_seeker_user_name.Text);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                int returnvalue = (int)cmd.ExecuteScalar();
                if (returnvalue == 1)
                {
                    Response.Redirect("~/Login.aspx?id=register");
                }
                else
                {
                    rlblj.Text = "User name is already use";
                }
                con.Close();
            }

        }
        else
        {
            rlblj.Text = "You must fulfill all the requirements";
        }

    }
    //for register database

    protected void btn_register_employeer_go_register_Click(object sender, EventArgs e)
    {
        if (Page.IsValid && txt_register_employeer_checkbox.Checked)
        {
            string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbname))
            {
                SqlCommand cmd = new SqlCommand("spEmployeers_account_info", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string password = FormsAuthentication.HashPasswordForStoringInConfigFile(txt_register_employeer_pass.Text, "SHA1");
                cmd.Parameters.AddWithValue("@email", txt_register_employeer_email.Text);
                cmd.Parameters.AddWithValue("@user_name", txt_register_employeer_user_name.Text);
                cmd.Parameters.AddWithValue("@pass", password);
                con.Open();
                int returnvalue = (int)cmd.ExecuteScalar();
                if (returnvalue == 1)
                {
                    Response.Redirect("~/Login.aspx?id=registers");
                }
                else
                {
                    rlble.Text = "User name is already use";
                }
                con.Close();
            }
        }
        else
        {
            rlble.Text = "You must fulfill all the requirements";
        }

    }
}

