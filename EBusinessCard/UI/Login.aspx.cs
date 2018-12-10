using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessAccessLayer;
using System.Data;

namespace EBusinessCard
{
    public partial class Login : System.Web.UI.Page
    {
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                UserName = txtUsername.Value,
                Password = txtPassword.Value
            };

            dt = newUser.Login();

            if (dt.Rows.Count > 0)
            {
                ResetForm();

                Session["Username"] = dt.Rows[0]["Username"].ToString();
                Response.Redirect("~/UI/HomePage.aspx");
            }else
            {
                ResetForm();
                errorDiv.Style.Add("display", "block");
                lblMessage.Text = "Username And/Or Password not mached!";
            }
        }

        private void ResetForm()
        {
            txtUsername.Value = "";
            txtPassword.Value = "";
        }
    }
}