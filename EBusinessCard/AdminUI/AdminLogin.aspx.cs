using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessAccessLayer;
using System.Data;

namespace EBusinessCard.AdminUI
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text
            };

            DataTable dt = admin.Login();

            if (dt.Rows.Count > 0)
            {
                Session["AdminFullName"] = dt.Rows[0]["Fullname"].ToString();
                Response.Redirect("~/AdminUI/ListOfCards.aspx");
            }
            else
            {
                ResetForm();
                status.Text = "Username and/or password not matched!";
            }
        }

        private void ResetForm()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}