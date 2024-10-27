using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobPortal.User
{
    public partial class UserMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

       
        protected void Logout_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null;
            Session["UserId"] = null;

        }

        protected void Logout_Click1(object sender, EventArgs e)
        {

        }
    }
}