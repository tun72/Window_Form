using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class employeer_Applicants : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie mycookie = Request.Cookies["emycookie"];
        if (Session["euser"] != null || mycookie != null)
        {
            if (Session["euser"] != null)
            {
                TextBox1.Text = Session["euser"].ToString();
            }
            if (mycookie != null)
            {
                TextBox1.Text = mycookie["euser"];
            }
        }
        if (!IsPostBack)
        {

            getcompanyid();
        }
    }
    public int id { get; set; }
    public void getcompanyid()
    {
        
        string dbname = ConfigurationManager.ConnectionStrings["DBCSJobPortal"].ConnectionString;
        using (SqlConnection con = new SqlConnection(dbname))
        {
            SqlCommand cmd = new SqlCommand("spgetjobidandusername", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user_name", TextBox1.Text);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                my_copmanyid.Text = rd["companyid"].ToString();
     
            }
        }
    }
}