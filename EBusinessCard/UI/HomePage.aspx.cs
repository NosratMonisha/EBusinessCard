using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBusinessCard.UI
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEditCardTemplate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/CardTemplates.aspx");
        }

        protected void btnCreateCardTemplate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/CreateCard.aspx");
        }
    }
}