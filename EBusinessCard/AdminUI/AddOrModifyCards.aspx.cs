using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessAccessLayer;
using System.Web.Services;
using System.Data;

namespace EBusinessCard.AdminUI
{
    public partial class AddOrModifyCards : System.Web.UI.Page
    {
        public static int flag = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CardProp.Style.Add("display", "none");
                cardHolder.Style.Add("display", "none");
            }

            TextBox CardName = (TextBox)System.Web.HttpContext.Current.Session["txtCardName"];
            Session["txtCardName"] = txtCardName;

            if (flag == 0)
            {
                statusH1.InnerText = "Successfully Saved!"; ;
                statusH1.Style.Add("display", "block");
                statusH1.Style.Add("color", "#4caf50");
            }
        }

        protected void ddlOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlOptions.SelectedIndex == 0)
            {
                CardProp.Style.Add("display", "none");
                CardId.Style.Add("display", "none");
                status.Style.Add("display", "none");
            }
            else if (ddlOptions.SelectedIndex == 1)
            {
                CardId.Style.Add("display", "none");
                CardProp.Style.Add("display", "block");
                status.Style.Add("display", "none");
            }
            else if(ddlOptions.SelectedIndex==2)
            {
                LoadAllCardIDs();
            }else
            {
                CardProp.Style.Add("display", "none");
                CardId.Style.Add("display", "flex");
                status.Style.Add("display", "none");
            }
        }

        private void LoadAllCardIDs()
        {
            BusinessAccess BA = new BusinessAccess();
            DataTable dt = BA.SelectAllCardIDs();
            if (dt.Rows.Count > 0)
            {
                ddlCardID.DataSource = dt;
                ddlCardID.DataTextField = "CardsName";
                ddlCardID.DataValueField = "CardID";
                ddlCardID.DataBind();

                ddlCardID.Items.Insert(0, new ListItem { Text = "Select Card ID", Value = "-1" });
                CardId.Style.Add("display", "flex");
                CardProp.Style.Add("display", "block");
            }
            else
            {
                CardId.Style.Add("display", "none");
                CardProp.Style.Add("display", "none");
                status.Style.Add("display", "block");
                statusH1.InnerText = "No Card's Found";
                statusH1.Style.Add("color", "#ff4444");
            }

        }

        protected void ddlTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTheme.SelectedIndex == 0)
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
            else if (ddlTheme.SelectedIndex == 2)
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
            TextBox txtCardName = (TextBox)System.Web.HttpContext.Current.Session["txtCardName"];

            if (txtCardName.Text != "")
            {
                Cards card = new Cards
                {
                    CardsName = CssProperty.CardsName,
                    ActualCardBG = CssProperty.ActualCardBG,
                    ActualCardTextColor = CssProperty.ActualCardTextColor,
                    CardsFontFamily = CssProperty.CardsFontFamily,
                    CardHolderDisplay = CssProperty.CardHolderDisplay,
                    CardHolderPadding = CssProperty.CardHolderPadding,
                    CardHeadBG = CssProperty.CardHeadBG,
                    CardHeadPadding = CssProperty.CardHeadPadding,
                    WorkAreaDisplay = CssProperty.WorkAreaDisplay,
                    CardBodyDisplay = CssProperty.CardBodyDisplay,
                    CardFooterTextAlign = CssProperty.CardFooterTextAlign,
                    CardFooterBorderTop = CssProperty.CardFooterBorderTop,
                    CardFooterPaddingTop = CssProperty.CardFooterPaddingTop
                };

                BusinessAccess BA = new BusinessAccess
                {
                    CardsObj = card
                };

                BA.AddNewCards();

                flag = 0;
                
            }
        }
        
        public void btnClearAll_Click(object sender, EventArgs e)
        {
            txtCardName.Text = "";
            ddlTheme.ClearSelection();
            cardHolder.Style.Add("display", "none");
            status.Style.Add("display", "none");
            flag = 1;
        }
    }


}