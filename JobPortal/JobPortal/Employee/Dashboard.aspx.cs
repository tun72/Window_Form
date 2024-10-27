using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobPortal.Employee
{
    public partial class Dashboard : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataAdapter sda;
        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["EmployeeId"] == null)
            //{
            //    Response.Redirect("../User/Login");
            //}

            if (!IsPostBack)
            {
                
                Jobs();
                AppliedJobs();
                
            }
        }

       

        private void AppliedJobs()
        {
            con = new SqlConnection(str);


            

            string query = @"SELECT
                                  COUNT(*)
                                FROM
                                    Jobs j
                               JOIN
                                    AppliedJobs as a ON j.JobId = a.JobId

                                WHERE
                                    j.EmployeeId = '" + Session["EmployeeId"] + "'"; 

            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["AppliedJobs"] = dt.Rows[0][0];
            }
            else
            {
                Session["AppliedJobs"] = 0;
            }
        }

        private void Jobs()
        {
            con = new SqlConnection(str);
            string query = @"SELECT 
    Count(*)
FROM 
    Jobs j
LEFT JOIN 
    Employees e ON j.EmployeeId = e.EmployeeId
               WHERE j.EmployeeId = '"+ Session["EmployeeId"] + "'";

            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["Jobs"] = dt.Rows[0][0];
            }
            else
            {
                Session["Jobs"] = 0;
            }
        }

      

    }
}
