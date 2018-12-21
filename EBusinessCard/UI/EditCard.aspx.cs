using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBusinessCard.UI
{
    public partial class EditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {

                }
                else
                {
                    Response.Redirect("~/UI/Login.aspx");
                }
            }
        }
    }
}