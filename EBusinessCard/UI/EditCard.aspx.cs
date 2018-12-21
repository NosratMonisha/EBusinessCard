using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
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
                    if (Request.QueryString["cid"] != null)
                    {
                        LoadCardByID(Request.QueryString["cid"]);
                    }
                    else
                    {
                        Server.Transfer("~/Errors_UI/PageNotFoundError.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/UI/Login.aspx");
                }
            }
        }
        private void LoadCardByID(string QueryStr)
        {
            BusinessAccess BA = new BusinessAccess();
            DataTable dt = BA.SelectCardValuesByID(QueryStr);

            if (dt.Rows.Count > 0)
            {
                repeater.DataSource = dt;
                Application["CardDetails"] = dt;
                repeater.DataBind();
            }
        }

        protected void repeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                HiddenField hf = (HiddenField)e.Item.FindControl("hiddenField");
                string themeIndex = hf.Value;


                if (themeIndex == "1")
                {
                    var h1CompanyName = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("CompanyName");
                    h1CompanyName.InnerText = "ABC LTD.";
                    var h3FullName = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("FullName");
                    h3FullName.InnerText = "User's Full Name";
                    var h5Designation = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("Designation");
                    h5Designation.InnerText = "B.Sc. in SWE";
                    var pWorkArea1 = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("WorkArea1");
                    pWorkArea1.InnerText = "Front-End Developer";
                    var pWorkArea2 = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("WorkArea2");
                    pWorkArea2.InnerText = "Student of Software Engineering Dept.";
                    var pWorkArea3 = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("WorkArea3");
                    pWorkArea3.InnerText = "Cell: +88012345678901";
                    var pWorkArea4 = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("WorkArea4");
                    pWorkArea4.InnerText = "abc@gmail.com";
                }
                else
                {
                    var h1CompanyName = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("CompanyName");
                    h1CompanyName.InnerText = "ABC LTD.";
                    var h3CompanyFullName = (System.Web.UI.HtmlControls.HtmlGenericControl)e.Item.FindControl("companyFullName");
                    h3CompanyFullName.InnerText = "Atanasoff-Berry Computer";
                    expertise.Style.Add("display", "none");
                    companySection.Style.Add("display", "block");
                }
            }
        }

        protected void btnClearAll_Click(object sender, EventArgs e)
        {
            txtCompanyName.Text = "";
            txtUserFullName.Text = "";
            txtDesignation.Text = "";
            txtExpertiseOn.Text = "";
            txtExpertiseOn2.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtCompanyFullName.Text = "";
            txtAboutComp1.Text = "";
            txtAboutComp2.Text = "";
            txtAboutComp3.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtContactNumber.Text = "";

            foreach (RepeaterItem item in repeater.Items)
            {
                var div = (System.Web.UI.HtmlControls.HtmlGenericControl)item.FindControl("cardHolder");
                div.Style.Add("display", "none");
                var div2 = (System.Web.UI.HtmlControls.HtmlGenericControl)item.FindControl("ActualCard");
                div2.Style.Add("background-color", "white");
            }
        }
    }
}