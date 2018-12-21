using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBusinessCard.UI
{
    public partial class CreateCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    cardHolder.Style.Add("display", "none");
                }
                else
                {
                    Response.Redirect("~/UI/Login.aspx");
                }
            }
        }

        protected void ddlTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTheme.SelectedIndex == 0)
            {
                cardHolder.Style.Add("display", "none");
                expertise.Style.Add("display", "block");
            }
            else if (ddlTheme.SelectedIndex == 1)
            {
                expertise.Style.Add("display", "block");
                companySection.Style.Add("display", "none");
                cardHolder.Style.Add("display", "block");
                CompanyName.InnerText = "ABC LTD.";
                FullName.InnerText = "User's Full Name";
                Designation.InnerText = "B.Sc. in SWE";

                WorkArea1.InnerText = "Front-End Developer";
                WorkArea2.InnerText = "Student of Software Engineering Dept.";
                WorkArea3.InnerText = "+88012345678901";
                WorkArea4.InnerText = "abc@gmail.com";

                // changes
                cardHolder.Style.Add("padding", "20px");
                workArea.Style.Add("display", "block");
                cardBody.Style.Add("display", "none");
                cardFooter.Style.Add("text-align", "right");
                cardFooter.Style.Add("border-top", "none");
                cardFooter.Style.Add("padding-top", "0px");
                cardHead.Style.Add("background-color", "transparent");
                cardHead.Style.Add("padding", "0px");
            }
            else if (ddlTheme.SelectedIndex == 2)
            {
                companySection.Style.Add("display", "block");
                expertise.Style.Add("display", "none");
                cardHolder.Style.Add("display", "block");
                workArea.Style.Add("display", "none");
                cardHead.Style.Add("padding", "4px 10px");
                cardHead.Style.Add("box-sizing", "border-box");
                cardHolder.Style.Add("padding", "0px");
                cardHead.Style.Add("background-color", "#ccc");
                CompanyName.InnerText = "ABC LTD.";
                companyFullName.InnerText = "Atanasoff-Berry Computer";
                cardBody.Style.Add("display", "block");
                cardFooter.Style.Add("text-align", "center");
                cardFooter.Style.Add("border-top", "1px solid #dddddd");
                cardFooter.Style.Add("padding-top", "5px");
            }
        }

        protected void btnClearAll_Click(object sender, EventArgs e)
        {
            ddlTheme.ClearSelection();
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

            cardHolder.Style.Add("display", "none");
            companySection.Style.Add("display", "none");
        }
    }
}