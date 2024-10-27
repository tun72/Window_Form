using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class employeer_MyJobs : System.Web.UI.Page
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

    }


    protected void btn_delte_myjobs_Click(object sender, ImageClickEventArgs e)
    {

    }
}