using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace JobPortal.Employee
{
    public partial class ViewResumes : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DataTable dt;
        DataTable dt1;
        string str = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public int jobCount = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["EmployeeId"] == null)
            //{
            //    Response.Redirect("../User/Login");
            //}

            showCategory();

        }

       

        private void showCategory()
        {

            
                if (dt == null)
            {
                
                    con = new SqlConnection(str);
                string query = @"SELECT 
                                    j.JobId,
                                    j.Title,
	                                c.icon,
	
                                    COUNT(a.AppliedJobId) AS NumberOfApplications
                                FROM 
                                    Jobs j
                                LEFT JOIN 
                                    AppliedJobs a ON j.JobId = a.JobId
                                LEFT JOIN
                                    Category c ON j.CategoryId = c.CategoryId
                                WHERE 
                                    j.EmployeeId = @EmpId  
                                GROUP BY 
                                    j.JobId, j.Title, c.icon
                                ORDER BY 
                                    NumberOfApplications DESC;
                            ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EmpId", Session["EmployeeId"]);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
            }
            JobLooper.DataSource = dt;
            JobLooper.DataBind();
            con.Close();



        }
    }
}