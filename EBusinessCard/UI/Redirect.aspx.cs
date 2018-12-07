using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBusinessCard.UI
{
    public partial class Redirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RedirectPageMessage"] == null)
            {
                Response.Redirect("~/Errors_UI/PageNotFoundError.aspx");
            }
            else
            {
                lrlMessage.Text = Session["RedirectPageMessage"].ToString();
            }
        }
    }
}