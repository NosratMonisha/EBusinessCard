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
            string saltedHashedPassword = "";

            if (saltedHashedPassword != null)
            {
                User user = new User
                {
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text
                };

                DataTable dt = user.Login();

                if (dt.Rows.Count > 0)
                {
                    Session["User"] = dt.Rows[0]["Fullname"].ToString();
                    Session["UserWholeRecord"] = dt;

                    if (Session["AbsolutePage"] == null)
                    {
                        Response.Redirect("~/UI/HomePage.aspx");
                    }
                    else
                    {
                        Response.Redirect(Session["AbsolutePage"].ToString());
                    }
                }
                else
                {
                    ResetForm();
                    status.Text = "username and/or password not matched!";
                }
            }
            else
            {
                ResetForm();
                status.Text = "username and/or password not matched!";
            }
        }

        private void ResetForm()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}