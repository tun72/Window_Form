using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace JobPortal
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);




        }



        void RegisterRoutes(RouteCollection routes)
        {
            // Route for User/Login page
            routes.MapPageRoute(
                "UserLoginRoute",           // Route name
                "User/Login",               // URL pattern
                "~/User/Login.aspx"         // Physical file
            );

            routes.MapPageRoute(
               "UserLoginRoute2",           // Route name
               "Login",               // URL pattern
               "~/User/Login.aspx"         // Physical file
           );

            routes.MapPageRoute(
              "UserRegisterRoute",           // Route name
              "Register",               // URL pattern
              "~/User/Register.aspx"         // Physical file
          );

            routes.MapPageRoute(
              "UserHomeRoute",           // Route name
              "",               // URL pattern
              "~/User/Default.aspx"         // Physical file
          );

            routes.MapPageRoute(
             "UserJobListRoute",           // Route name
             "JobListing",               // URL pattern
             "~/User/JobListing.aspx"         // Physical file
         );

            routes.MapPageRoute(
         "UserDetailRoute",           // Route name
         "JobDetail",               // URL pattern
         "~/User/JobDetail.aspx"         // Physical file
        );

            routes.MapPageRoute(
     "UserAboutRoute",           // Route name
     "About",               // URL pattern
     "~/User/About.aspx"         // Physical file
    );

            routes.MapPageRoute(
     "UserContactRoute",           // Route name
     "Contact",               // URL pattern
     "~/User/Contact.aspx"         // Physical file
    );

        }

    }
}