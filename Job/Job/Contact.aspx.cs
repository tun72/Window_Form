using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txt_name.Focus();
        if (!IsPostBack)
        {
            panel_office_address.Visible = true;
            panel_message_me.Visible = false;
            btn_office_address.BackColor = System.Drawing.Color.Green;
        }
    }
    protected void btn_office_address_Click(object sender, EventArgs e)
    {
       
            panel_office_address.Visible = true;
            panel_message_me.Visible = false;
            btn_office_address.BackColor = System.Drawing.Color.Green;
            btn_mail_us.BackColor = System.Drawing.Color.White;
   }

    protected void btn_mail_us_Click(object sender, EventArgs e)
    {
        panel_message_me.Visible = true;
        panel_office_address.Visible = false;
        btn_mail_us.BackColor = System.Drawing.Color.Green;
        btn_office_address.BackColor = System.Drawing.Color.White;
        lbl_msg.Text = " ";
    }



    protected void btn_messge_submit_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(txt_email.Text);
                msg.To.Add("aalifkhan7@gmail.com");
                msg.Subject = "Our report of many thing";
                msg.Body = "Name " + txt_name.Text + "<br/>" + "Phone Number : " + txt_number.Text + "<br/>" + "Comments " + txt_comments + "<br/>";
                msg.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential();
                smtp.Send(msg);
                lbl_msg.Text = "Thank you for your support";
                lbl_msg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
       
                lbl_msg.Text = "Try again";
                lbl_msg.ForeColor = System.Drawing.Color.Red;

            }
        }
        catch(Exception ex)
        {
            lbl_msg.Text = "Try again <br/ >" + ex.Message;
            lbl_msg.ForeColor = System.Drawing.Color.Red;

        }
        
    }
}