using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class employeer_AddJobs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie mycookie = Request.Cookies["emycookie"];
        if (Session["euser"] != null || mycookie != null)
        {
            if(Session["euser"] != null)
            {
                my_hidden.Text = Session["euser"].ToString();
            }
            if(mycookie != null)
            {
                my_hidden.Text = mycookie["euser"];
            }
        }
        if (!IsPostBack)
        {
            job_calender.Visible = false;
        }

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (job_calender.Visible)
        {
            job_calender.Visible = false;
            btn_submit.Focus();
        }
        else
        {
            job_calender.Visible = true;
            btn_submit.Focus();
        }
    }


    protected void job_calender_SelectionChanged1(object sender, EventArgs e)
    {
        txt_job_deadline.Text = job_calender.SelectedDate.ToString("d");
        job_calender.Visible = false;
        btn_submit.Focus();
    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {

        if (Page.IsValid)
        {
            string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbname))
            {
                SqlCommand cmd = new SqlCommand("spJobsinser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_name", my_hidden.Text);
                cmd.Parameters.AddWithValue("@title", txt_job_title.Text);
                cmd.Parameters.AddWithValue("@catagory",drp_job_catagory.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@vacancy", txt_job_vacancy.Text);
                cmd.Parameters.AddWithValue("@discription", txt_job_discription.Text);
                cmd.Parameters.AddWithValue("@nature",drp_job_nature.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@educationalrequiremnt", txt_job_education_requiremnt.Text);
                cmd.Parameters.AddWithValue("@loaction", txt_job_location.Text);
                cmd.Parameters.AddWithValue("@salary", txt_job_salary.Text);
                cmd.Parameters.AddWithValue("@deadline", txt_job_deadline.Text);
                con.Open();
                int returnvalue = (int)cmd.ExecuteScalar();
                if (returnvalue == 1)
                {
                    Response.Redirect("~/employeer/Default.aspx");
                }
                else
                {
                    lbljobcongo.Text = "Try Again";
                }
                con.Close();
            }
        }
        else
        {
            lbljobcongo.Text = "You must fulfill all the requirements";
        }

    }
}
