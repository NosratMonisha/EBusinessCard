using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace EBusinessCard
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();

            var exception = (HttpException)ex;
            int httpCode = exception.GetHttpCode();

            Server.ClearError();

            if (!Response.IsRequestBeingRedirected)
            {
                if (httpCode == 404)
                {
                    Response.Redirect("~/Errors_UI/PageNotFoundError.aspx");
                }
                else
                {
                    Response.Redirect("~/Errors_UI/Error.aspx");
                }
            }
        }
    }
}