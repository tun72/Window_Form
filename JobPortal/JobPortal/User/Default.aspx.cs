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

namespace JobPortal.User
{

    public partial class Default : System.Web.UI.Page
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
            if(!IsPostBack)
            {
                showJobs();
                showCategory();
               
            }
        }

        private void showCategory()
        {
            if (dt == null)
            {
                con = new SqlConnection(str);
                string query = @"SELECT 
                                    c.CategoryId,
                                    c.Name,
                                    c.Icon,
                                    COUNT(j.JobId) AS TotalJobs
                                FROM 
                                    Category c
                                LEFT JOIN 
                                    Jobs j ON c.CategoryId = j.CategoryId
                                GROUP BY 
                                    c.CategoryId, c.Name, c.Icon;


                            ";
                cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
            }
            CategoryLoop.DataSource = dt;
            CategoryLoop.DataBind();
            con.Close();



        }

        private void showJobs()
        {
           
            if (dt == null)
            {
                
                con = new SqlConnection(str);
                string query = @"SELECT TOP 5 
                                    j.JobId, 
                                    j.Title, 
                                    j.Salary, 
                                    j.JobType, 
                                    e.CompanyName, 
                                    e.CompanyImage, 
                                    j.Country, 
                                    j.State, 
                                    j.CreateDate AS CreatedDate
                                FROM 
                                    Jobs j
                                JOIN 
                                    Employees e ON j.EmployeeId = e.EmployeeId
                                ORDER BY 
                                    j.CreateDate DESC;
                            ";
                cmd = new SqlCommand(query, con);
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                dt1 = new DataTable();
                sda.Fill(dt1);
            }
            Looper.DataSource = dt1;
            Looper.DataBind();




        }
        public static string RelativeDate(DateTime theDate)

        {

            Dictionary<long, string> thresholds = new Dictionary<long, string>();

            int minute = 60;

            int hour = 60 * minute;

            int day = 24 * hour;

            thresholds.Add(60, "{0} seconds ago");

            thresholds.Add(minute * 2, "a minute ago");

            thresholds.Add(45 * minute, "{0} minutes ago");

            thresholds.Add(120 * minute, "an hour ago");

            thresholds.Add(day, "{0} hours ago");

            thresholds.Add(day * 2, "yesterday");

            thresholds.Add(day * 30, "{0} days ago");

            thresholds.Add(day * 365, "{0} months ago");

            thresholds.Add(long.MaxValue, "{0} years ago");

            long since = (DateTime.Now.Ticks - theDate.Ticks) / 10000000;

            foreach (long threshold in thresholds.Keys)

            {

                if (since < threshold)

                {

                    TimeSpan t = new TimeSpan((DateTime.Now.Ticks - theDate.Ticks));

                    return string.Format(thresholds[threshold], (t.Days > 365 ? t.Days / 365 : (t.Days > 0 ? t.Days : (t.Hours > 0 ? t.Hours : (t.Minutes > 0 ? t.Minutes : (t.Seconds > 0 ? t.Seconds : 0))))).ToString());

                }

            }

            return "";

        }

        protected string GetImageUrl(Object url)
        {
            string url1 = "";
            if (string.IsNullOrEmpty(url.ToString()) || url == DBNull.Value)
            {

                url1 = "~/Images/No_image.png";
            }
            else
            {

                url1 = string.Format("~/{0}", url);
            }
            return ResolveUrl(url1);
        }
    }
}