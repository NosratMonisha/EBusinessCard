using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessAccessLayer;

namespace EBusinessCard.AdminUI
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (Session["AdminFullName"] != null)
                //{
                //    lblAdminFullName.Text = Session["AdminFullName"].ToString();
                //}else
                //{
                //    Response.Redirect("~/AdminUI/AdminLogin.aspx");
                //}
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/AdminUI/AdminLogin.aspx");
        }
    }
}