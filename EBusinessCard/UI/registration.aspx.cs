using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessAccessLayer;

namespace EBusinessCard.UI
{
    public partial class registration : System.Web.UI.Page
    {
        BusinessAccess BA;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            User userObj = new User
            {
                UserName = txtUsername.Value,
                UserType = ddlUserType.SelectedItem.ToString(),
                Password = txtPassword.Value,
                Email = txtEmail.Value,
                DOB = txtDOB.Value,
                PhoneNumber = txtPhoneNumber.Value,
                Address = taAddress.InnerText,
                FullName = txtFullName.Value
            };

            userObj.Registration();

            ResetForm();

            Session["RedirectPageMessage"] = "Account Successfully Created. Redirect To <a href = 'Login.aspx'>Login</a> Page.";

            Response.Redirect("~/UI/Redirect.aspx");
        }

        private void ResetForm()
        {
            txtFullName.Value = "";
            txtUsername.Value = "";
            txtPhoneNumber.Value = "";
            txtDOB.Value = "";
            txtEmail.Value = "";
            taAddress.InnerText = "";
        }
    }

}