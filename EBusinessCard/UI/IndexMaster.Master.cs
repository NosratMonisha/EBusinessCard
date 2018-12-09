using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBusinessCard.UI
{
    public partial class IndexMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    loginLi.Style.Add("display", "none");
                    userImageContainer.Style.Add("display", "flex");
                    lblUserName.Text = Session["Username"].ToString();
                    btnLogOut.Style.Add("display", "block !important");
                }
            }
            else
            {

            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/UI/HomePage.aspx");
        }
    }
}