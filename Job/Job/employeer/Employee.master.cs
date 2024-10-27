﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class employeer_Employee : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie mycookie = Request.Cookies["emycookie"];
        if(Session["euser"] !=null || mycookie != null)
        {

        }
        else
        {
            Response.Redirect("~/Login.aspx");
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Cookies["emycookie"].Expires = DateTime.Now.AddYears(-1);
        Session.Clear();
        Response.Redirect("~/Login.aspx");
    }
}
