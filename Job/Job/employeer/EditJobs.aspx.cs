using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class employeer_EditJobs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["id"] == null)
        {
            Response.Redirect("~/employeer/MyJobs.aspx");
        }
        HttpCookie mycookie = Request.Cookies["emycookie"];
        if (Session["euser"] != null || mycookie != null)
        {
            if (Session["euser"] != null)
            {
                my_hidden.Text = Session["euser"].ToString();
            }
            if (mycookie != null)
            {
                my_hidden.Text = mycookie["euser"];
            }
        }
        if (!IsPostBack)
        {
            editfill();
            job_calender.Visible = false;
        }

    }
    public void editfill()
    {
        string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
        using (SqlConnection con = new SqlConnection(dbname))
        {
            SqlCommand cmd = new SqlCommand("spgetjobseditfull", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user_name", my_hidden.Text);
            cmd.Parameters.AddWithValue("@id", Request.QueryString["id"]);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                txt_job_title.Text = rd["Jobs_Title"].ToString();
                txt_job_vacancy.Text = rd["Vacancy"].ToString();
                txt_job_discription.Text = rd["Discription"].ToString();
                txt_job_education_requiremnt.Text = rd["Educational_req"].ToString();
                txt_job_location.Text = rd["Jobs_Location"].ToString();
                txt_job_salary.Text = rd["Salary"].ToString();
                txt_job_deadline.Text = rd["Jobs_deadline"].ToString();
            }
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (job_calender.Visible)
        {
            job_calender.Visible = false;
            btn_update.Focus();
        }
        else
        {
            job_calender.Visible = true;
            btn_update.Focus();
        }
    }

    protected void job_calender_SelectionChanged(object sender, EventArgs e)
    {
        txt_job_deadline.Text = job_calender.SelectedDate.ToString("d");
        job_calender.Visible = false;
        btn_update.Focus();
    }

    protected void btn_update_Click(object sender, EventArgs e)
    {

        if (Page.IsValid)
        {
            string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbname))
            {
                SqlCommand cmd = new SqlCommand("spjobsupdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",Request.QueryString["id"]);
                cmd.Parameters.AddWithValue("@title", txt_job_title.Text);
                cmd.Parameters.AddWithValue("@catagory", drp_job_catagory.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@vacancy", txt_job_vacancy.Text);
                cmd.Parameters.AddWithValue("@discription", txt_job_discription.Text);
                cmd.Parameters.AddWithValue("@nature", drp_job_nature.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@educationalrequiremnt", txt_job_education_requiremnt.Text);
                cmd.Parameters.AddWithValue("@loaction", txt_job_location.Text);
                cmd.Parameters.AddWithValue("@salary", txt_job_salary.Text);
                cmd.Parameters.AddWithValue("@deadline", txt_job_deadline.Text);
                con.Open();
                int returnvalue = (int)cmd.ExecuteNonQuery();
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