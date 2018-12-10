using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessAccessLayer;
using System.Web.Services;

namespace EBusinessCard.AdminUI
{
    public partial class AddOrModifyCards : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CardProp.Style.Add("display", "none");
                cardHolder.Style.Add("display", "none");
            }
        }

        protected void ddlOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlOptions.SelectedIndex == 0)
            {
                CardProp.Style.Add("display", "none");
                CardId.Style.Add("display", "none");
            }
            else if (ddlOptions.SelectedIndex == 1)
            {
                CardId.Style.Add("display", "none");
                CardProp.Style.Add("display", "block");
            }
            else
            {
                CardProp.Style.Add("display", "none");
                CardId.Style.Add("display", "flex");
            }
        }

        protected void ddlTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlTheme.SelectedIndex == 0)
            {
                cardHolder.Style.Add("display", "none");
            }
            else if (ddlTheme.SelectedIndex == 1)
            {
                cardHolder.Style.Add("display", "block");
                CompanyName.InnerText = "ABC LTD.";
                FullName.InnerText = "User's Full Name";
                Designation.InnerText = "B.Sc. in SWE";
                
                WorkArea1.InnerText = "Front-End Developer";
                WorkArea2.InnerText = "Student of Software Engineering Dept.";
                WorkArea3.InnerText = "Cell: +88012345678901";
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
            else if(ddlTheme.SelectedIndex == 2)
            {
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

        [WebMethod]
        public static void AddNewCard(Cards CssProperty)
        {
        
        }
    }
}