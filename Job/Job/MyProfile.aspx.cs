using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Web.Security;

public partial class MyProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["mycookie"];
        if (Session["user"] != null || cookie != null)
        {
            if (Session["user"] != null)
            {
                my_hidden.Text = Session["user"].ToString();
            }
            else
            {
                my_hidden.Text = cookie["cuser"];
            }

        }
        else
        {
            Response.Redirect("~/Login.aspx");
        }
        gridshow();
        Show_first();
        if (!IsPostBack)
        {
            Load_Personal_info();
            if (Request.QueryString["i_d"] == null)
            {
                btn_for_apply.Visible = false;
            }

        }

    }

    private void Show_first()
    {
        pnl_personal_info.Visible = false;
        pnl_education_info.Visible = false;
        pnl_other_info.Visible = false;
        pnl_my_resume.Visible = true;
        pnl_my_loginfo.Visible = false;
        btn_my_personal_info.BackColor = System.Drawing.Color.White;
        btn_my_educational_info.BackColor = System.Drawing.Color.White;
        btn_my_other_info.BackColor = System.Drawing.Color.White;
        btn_my_view_resume.BackColor = System.Drawing.Color.Green;
        btn_my_password_change.BackColor = System.Drawing.Color.White;
    }
    public void Load_Personal_info()
    {
        string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
        using (SqlConnection con = new SqlConnection(dbname))
        {
            SqlCommand cmd = new SqlCommand(" select * from Job_seeker_account_info where user_name = '" + my_hidden.Text + "' ", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {

                // hiiden_my_personal_info.Value = rd["id"].ToString();
                txt_myfname.Text = rd["First_name"].ToString();
                txt_mylname.Text = rd["Last_name"].ToString();
                txt_myfathersname.Text = rd["Father_name"].ToString();
                txt_mymothersname.Text = rd["Mother_name"].ToString();
                txt_myreligon.Text = rd["Religon"].ToString();
                txt_mypresent_address.InnerText = rd["Present_address"].ToString();
                txt_mypermanent_address.InnerText = rd["Parmanent_address"].ToString();
                txt_my_fmblno.Text = rd["Mobile"].ToString();
                txt_mye_sss_result.Text = rd["ssc_result"].ToString();
                txt_mye_ssc_institute.Text = rd["ssc_institute"].ToString();
                txt_mye_hsc_institute.Text = rd["hsc_institute"].ToString();
                txt_mye_hsc_result.Text = rd["hsc_result"].ToString();
                txt_mye_honors_major.Text = rd["hnrs_major"].ToString();
                txt_mye_honors_dgrtitle.Text = rd["hnrs_title"].ToString();
                txt_my_hnrsinstitue.Text = rd["hnrs_institue"].ToString();
                txt_my_hnrsresult.Text = rd["hnrs_result"].ToString();
            }
        }

    }


    protected void btn_my_personal_info_Click(object sender, EventArgs e)
    {
        pnl_personal_info.Visible = true;
        pnl_education_info.Visible = false;
        pnl_other_info.Visible = false;
        pnl_my_resume.Visible = false;
        pnl_my_loginfo.Visible = false;
        btn_my_personal_info.BackColor = System.Drawing.Color.Green;
        btn_my_educational_info.BackColor = System.Drawing.Color.White;
        btn_my_other_info.BackColor = System.Drawing.Color.White;
        btn_my_view_resume.BackColor = System.Drawing.Color.White;
        btn_my_password_change.BackColor = System.Drawing.Color.White;

    }

    protected void btn_my_educational_info_Click(object sender, EventArgs e)
    {
        pnl_personal_info.Visible = false;
        pnl_education_info.Visible = true;
        pnl_other_info.Visible = false;
        pnl_my_resume.Visible = false;
        pnl_my_loginfo.Visible = false;
        btn_my_personal_info.BackColor = System.Drawing.Color.White;
        btn_my_educational_info.BackColor = System.Drawing.Color.Green;
        btn_my_other_info.BackColor = System.Drawing.Color.White;
        btn_my_view_resume.BackColor = System.Drawing.Color.White;
        btn_my_password_change.BackColor = System.Drawing.Color.White;

    }

    protected void btn_my_other_info_Click(object sender, EventArgs e)
    {
        pnl_personal_info.Visible = false;
        pnl_education_info.Visible = false;
        pnl_other_info.Visible = true;
        pnl_my_resume.Visible = false;
        pnl_my_loginfo.Visible = false;
        btn_my_personal_info.BackColor = System.Drawing.Color.White;
        btn_my_educational_info.BackColor = System.Drawing.Color.White;
        btn_my_other_info.BackColor = System.Drawing.Color.Green;
        btn_my_view_resume.BackColor = System.Drawing.Color.White;
        btn_my_password_change.BackColor = System.Drawing.Color.White;

    }

    protected void btn_my_view_resume_Click(object sender, EventArgs e)
    {

        Response.Redirect("~/MyProfile.aspx");
        pnl_personal_info.Visible = false;
        pnl_education_info.Visible = false;
        pnl_other_info.Visible = false;
        pnl_my_resume.Visible = true;
        pnl_my_loginfo.Visible = false;
        btn_my_personal_info.BackColor = System.Drawing.Color.White;
        btn_my_educational_info.BackColor = System.Drawing.Color.White;
        btn_my_other_info.BackColor = System.Drawing.Color.White;
        btn_my_view_resume.BackColor = System.Drawing.Color.Green;
        btn_my_password_change.BackColor = System.Drawing.Color.White;

    }

    protected void btn_save_my_personalinfo_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbname))
            {
                SqlCommand cmd = new SqlCommand("spJob_Profile_Info", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_name", my_hidden.Text);
                cmd.Parameters.AddWithValue("@First_name", txt_myfname.Text);
                cmd.Parameters.AddWithValue("@Last_name", txt_mylname.Text);
                cmd.Parameters.AddWithValue("@Father_name", txt_myfathersname.Text);
                cmd.Parameters.AddWithValue("@Mother_name", txt_mymothersname.Text);
                cmd.Parameters.AddWithValue("@Religon_name", txt_myreligon.Text);
                cmd.Parameters.AddWithValue("@Matriual_Status", drp_mymarried.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@Gender", drp_mygender.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@Present_address", txt_mypresent_address.InnerText);
                cmd.Parameters.AddWithValue("@Parmanent_address", txt_mypermanent_address.InnerText);
                cmd.Parameters.AddWithValue("@Mobile", txt_my_fmblno.Text);
                cmd.Parameters.AddWithValue("@Omobile", txt_my_omblno.Text);
                con.Open();
                int value = (int)cmd.ExecuteNonQuery();
                if (value != 1)
                {
                    lblmyp.Text = "Personal info is not updated.<br /> Try again ";
                }
                Response.Redirect("~/MyProfile.aspx");
            }
        }
        else
        {
            lblmyp.Text = "Enter all the requiremnets";
        }


    }
    protected void btn_cancel_my_personalinfo_Click(object sender, EventArgs e)
    {
        Show_first();
        Response.Redirect("~/MyProfile.aspx");
    }

    protected void btn_mye_ssc_save_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbname))
            {
                SqlCommand cmd = new SqlCommand("spJob_seeker_ssceducation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_name", my_hidden.Text);
                cmd.Parameters.AddWithValue("@ssc_group", drp_mye_ssc_majorgroup.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@ssc_year", drp_mye_ssc_passingyear.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@ssc_institute", txt_mye_ssc_institute.Text);
                cmd.Parameters.AddWithValue("@ssc_result", txt_mye_sss_result.Text);
                con.Open();
                int value = (int)cmd.ExecuteNonQuery();
                if (value != 1)
                {
                    lblmyp.Text = "SSC info is not updated.<br /> Try again ";
                }
                Response.Redirect("~/MyProfile.aspx");
            }
        }


    }
    protected void btn_mye_ssc_cancel_Click(object sender, EventArgs e)
    {
        Show_first();
        Response.Redirect("~/MyProfile.aspx");
    }

    protected void btn_mye_hsc_save_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbname))
            {
                SqlCommand cmd = new SqlCommand("spJob_seeker_hsceducation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_name", my_hidden.Text);
                cmd.Parameters.AddWithValue("@hsc_group", drp_mye_hsc_majorgroup.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@hsc_year", drp_mye_hsc_passingyear.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@hsc_institute", txt_mye_ssc_institute.Text);
                cmd.Parameters.AddWithValue("@hsc_result", txt_mye_hsc_result.Text);
                con.Open();
                int value = (int)cmd.ExecuteNonQuery();
                if (value != 1)
                {
                    lblmyp.Text = "HSC info is not updated.<br /> Try again ";
                }
                Response.Redirect("~/MyProfile.aspx");
            }
        }
        else
        {
            lblmyp.Text = "Enter all the requiremnets";
        }
    }
    protected void btn_mye_hsc_cancel_Click(object sender, EventArgs e)
    {
        Show_first();
        Response.Redirect("~/MyProfile.aspx");
    }

    protected void btn_my_hnr_save_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbname))
            {
                SqlCommand cmd = new SqlCommand("spJob_seeker_honorseducation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_name", my_hidden.Text);
                cmd.Parameters.AddWithValue("@hnrs_title", txt_mye_honors_dgrtitle.Text);
                cmd.Parameters.AddWithValue("@hnrs_major", txt_mye_honors_major.Text);
                cmd.Parameters.AddWithValue("@hnrs_result", txt_my_hnrsresult.Text);
                cmd.Parameters.AddWithValue("@hnrs_institue", txt_my_hnrsinstitue.Text);
                con.Open();
                int value = (int)cmd.ExecuteNonQuery();
                if (value != 1)
                {
                    lblmyp.Text = "Info is not updated.<br /> Try again ";
                }
                Response.Redirect("~/MyProfile.aspx");
            }
        }
        else
        {
            lblmyp.Text = "Enter all the requiremnets";
        }

    }

    protected void btn_my_hnrs_cancel_Click(object sender, EventArgs e)
    {
        Show_first();
        Response.Redirect("~/MyProfile.aspx");
    }

    protected void btn_mypicture_upload_Click(object sender, EventArgs e)
    {
        HttpPostedFile postedfile = upld_my_pic.PostedFile;
        string filename = Path.GetFileName(postedfile.FileName);
        int filesize = postedfile.ContentLength;
        string fileextension = Path.GetExtension(filename);
        if (fileextension.ToLower() == ".jpg" || fileextension.ToLower() == ".png")
        {
            if (filesize > 2097152)
            {
                pnl_personal_info.Visible = false;
                pnl_education_info.Visible = false;
                pnl_other_info.Visible = true;
                pnl_my_resume.Visible = false;
                btn_my_personal_info.BackColor = System.Drawing.Color.White;
                btn_my_educational_info.BackColor = System.Drawing.Color.White;
                btn_my_other_info.BackColor = System.Drawing.Color.Green;
                btn_my_view_resume.BackColor = System.Drawing.Color.White;

                lbl_pic.Text = "Only less than 2mb photo is allowed";

            }
            else
            {

                string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
                using (SqlConnection con = new SqlConnection(dbname))
                {
                    byte[] bytes = new byte[filesize];
                    postedfile.InputStream.Read(bytes, 0, filesize);
                    SqlCommand cmd = new SqlCommand("update Job_seeker_account_info set my_pic = @mypic where user_name = @user_name", con);
                    cmd.Parameters.AddWithValue("@mypic", bytes);
                    cmd.Parameters.AddWithValue("@user_name", my_hidden.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    lbl_pic.Text = "Upload";

                    pnl_personal_info.Visible = false;
                    pnl_education_info.Visible = false;
                    pnl_other_info.Visible = true;
                    pnl_my_resume.Visible = false;
                    btn_my_personal_info.BackColor = System.Drawing.Color.White;
                    btn_my_educational_info.BackColor = System.Drawing.Color.White;
                    btn_my_other_info.BackColor = System.Drawing.Color.Green;
                    btn_my_view_resume.BackColor = System.Drawing.Color.White;

                }
            }
            //Stream streamread = postedfile.InputStream;
            //BinaryReader binary_reader = new BinaryReader(streamread);
            //byte[] bytes = binary_reader.ReadBytes((int)streamread.Length);

        }
        else
        {
            pnl_personal_info.Visible = false;
            pnl_education_info.Visible = false;
            pnl_other_info.Visible = true;
            pnl_my_resume.Visible = false;
            btn_my_personal_info.BackColor = System.Drawing.Color.White;
            btn_my_educational_info.BackColor = System.Drawing.Color.White;
            btn_my_other_info.BackColor = System.Drawing.Color.Green;
            btn_my_view_resume.BackColor = System.Drawing.Color.White;

            lbl_pic.Text = "Only jpg photo is allowed";
        }
    }

    protected void btn_mycv_upload_Click(object sender, EventArgs e)
    {
        HttpPostedFile postedcv = upld_my_cv.PostedFile;
        string cv_name = Path.GetFileName(postedcv.FileName);
        int cv_size = postedcv.ContentLength;
        string cv_extension = Path.GetExtension(cv_name);
        if (cv_extension.ToLower() == ".doc" || cv_extension.ToLower() == ".docs")
        {
            if (cv_size < 2097152)
            {

                string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
                using (SqlConnection con = new SqlConnection(dbname))
                {

                    byte[] bytes = new byte[cv_size];
                    postedcv.InputStream.Read(bytes, 0, cv_size);
                    SqlCommand cmd = new SqlCommand("update Job_seeker_account_info set my_cv = @mycv,my_cv_name=@my_cv_name where user_name = @user_name", con);
                    cmd.Parameters.AddWithValue("@mycv", bytes);
                    cmd.Parameters.AddWithValue("@my_cv_name", my_hidden.Text + " " + cv_name);
                    cmd.Parameters.AddWithValue("@user_name", my_hidden.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    lbl_cv.Text = "Upload";

                    pnl_personal_info.Visible = false;
                    pnl_education_info.Visible = false;
                    pnl_other_info.Visible = true;
                    pnl_my_resume.Visible = false;
                    btn_my_personal_info.BackColor = System.Drawing.Color.White;
                    btn_my_educational_info.BackColor = System.Drawing.Color.White;
                    btn_my_other_info.BackColor = System.Drawing.Color.Green;
                    btn_my_view_resume.BackColor = System.Drawing.Color.White;
                }

            }
            else
            {
                pnl_personal_info.Visible = false;
                pnl_education_info.Visible = false;
                pnl_other_info.Visible = true;
                pnl_my_resume.Visible = false;
                btn_my_personal_info.BackColor = System.Drawing.Color.White;
                btn_my_educational_info.BackColor = System.Drawing.Color.White;
                btn_my_other_info.BackColor = System.Drawing.Color.Green;
                btn_my_view_resume.BackColor = System.Drawing.Color.White;
                lbl_cv.Text = "Only lessthan 2mb file is allowed";
            }
        }
        else
        {
            pnl_personal_info.Visible = false;
            pnl_education_info.Visible = false;
            pnl_other_info.Visible = true;
            pnl_my_resume.Visible = false;
            btn_my_personal_info.BackColor = System.Drawing.Color.White;
            btn_my_educational_info.BackColor = System.Drawing.Color.White;
            btn_my_other_info.BackColor = System.Drawing.Color.Green;
            btn_my_view_resume.BackColor = System.Drawing.Color.White;
            lbl_cv.Text = "Only doc or docs file is allowed";
        }
    }
    public void gridshow()
    {

        string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
        using (SqlConnection con = new SqlConnection(dbname))
        {
            SqlCommand cmd = new SqlCommand("select my_cv,my_cv_name from Job_seeker_account_info where my_cv is not null and user_name = @user_name ", con);
            cmd.Parameters.AddWithValue("user_name", my_hidden.Text);
            con.Open();
            GridView4.DataSource = cmd.ExecuteReader();
            GridView4.DataBind();
        }
    }
    protected void cv_download_Click(object sender, EventArgs e)
    {
        string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
        using (SqlConnection con = new SqlConnection(dbname))
        {
            SqlCommand cmd = new SqlCommand("select my_cv,my_cv_name from Job_seeker_account_info where my_cv is not null and user_name = @user_name ", con);
            cmd.Parameters.AddWithValue("user_name", my_hidden.Text);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Response.Clear();
                Response.Buffer = true;
                Response.ContentType = "application/octet-stream";
                Response.AddHeader("content-disposition", "attachment;filename=" + rd["my_cv_name"].ToString()); // to open file prompt Box open or Save file  
                Response.Charset = "";
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite((byte[])rd["my_cv"]);
                Response.End();
            }
        }

    }

    protected void btn_my_log_chnge_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbname))
            {
                string password = FormsAuthentication.HashPasswordForStoringInConfigFile(txt_change_pass.Text, "SHA1");
                SqlCommand cmd = new SqlCommand("spJob_seeker_reset_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_name", txt_change_user_name.Text);
                cmd.Parameters.AddWithValue("@user_namee", my_hidden.Text);
                cmd.Parameters.AddWithValue("@email", txt_change_email.Text);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                int value = (int)cmd.ExecuteNonQuery();
                if (value == 1)
                {
                    Response.Cookies["mycookie"].Expires = DateTime.Now.AddYears(-1);
                    Session.Clear();
                    Response.Redirect("~/Login.aspx");
                }
            }
        }
        else
        {
            lbl_my_user.Text = my_hidden.Text;
        }

    }

    protected void btn_my_log_cancel_Click(object sender, EventArgs e)
    {
        Show_first();
    }

    protected void btn_my_password_change_Click(object sender, EventArgs e)
    {
        lbl_my_user.Text = my_hidden.Text;
        pnl_personal_info.Visible = false;
        pnl_education_info.Visible = false;
        pnl_other_info.Visible = false;
        pnl_my_resume.Visible = false;
        pnl_my_loginfo.Visible = true;
        btn_my_personal_info.BackColor = System.Drawing.Color.White;
        btn_my_educational_info.BackColor = System.Drawing.Color.White;
        btn_my_other_info.BackColor = System.Drawing.Color.White;
        btn_my_view_resume.BackColor = System.Drawing.Color.White;
        btn_my_password_change.BackColor = System.Drawing.Color.Green;
    }


    protected void btn_for_apply_Click(object sender, ImageClickEventArgs e)
    {
        if (Request.QueryString["i_d"] != null)
        {

            string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbname))
            {
                try
                {
                    // lblcongo.Text = Request.QueryString["i_d"];
                    SqlCommand cmd = new SqlCommand("spInsertjobandseekder", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", my_hidden.Text);
                    cmd.Parameters.AddWithValue("@titlename", Request.QueryString["job_title"]);
                    con.Open();
                    int value = (int)cmd.ExecuteNonQuery();
                    if (value == 1)
                    {
                        lblcongo.Text = "Thanks for applying ";
                        lblcongo.BackColor = System.Drawing.Color.Yellow;
                       
                    }
                }
                catch
                {
                    lblcongo.Text = "You already applied";
                    lblcongo.BackColor = System.Drawing.Color.Yellow;
                }
            }
        }
    }
}
