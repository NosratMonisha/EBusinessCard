<%@ Page Title="EBCard | Sample Cards" Language="C#" MasterPageFile="~/UI/IndexMaster.Master" AutoEventWireup="true" CodeBehind="CardTemplates.aspx.cs" Inherits="EBusinessCard.UI.CardTemplates" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cp1" runat="server">
    <div class="body-content" style="padding-top: 70px;">
        <div class="container" style="flex-direction: column; min-height: 440px;">
            <div class="childContent">
                <h1 class="child-h1">Cards Template</h1>
                <div class="loc-container">
                    <asp:Repeater ID="repeater" runat="server" OnItemDataBound="repeater_ItemDataBound">
                        <ItemTemplate>
                            <asp:HiddenField ID="hiddenField" runat="server" Value='<%# Eval("ThemeIndex")%>' />
                            <div class="loc-flex-card relative">
                                <div class="actual-card hover-card" id="ActualCard" runat="server" style='<%# "background:" + Eval("ActualCardBG") + ";color:"+Eval("ActualCardTextColor")+";" %>'>
                                    <div id="cardHolder" class="cardHolder" runat="server" style='<%# "display:"+Eval("CardHolderDisplay") +";padding:"+Eval("CardHolderPadding")+";" %>'>
                                        <div id="cardHead" runat="server" class="cardHead" style='<%# "background:"+Eval("CardHeadBG")+";padding:"+Eval("CardHeadPadding")+";" %>'>
                                            <div id="companyName">
                                                <h3 runat="server" id="CompanyName">ABC LTD.</h3>
                                            </div>
                                            <div>
                                                <h3 runat="server" id="FullName">User's Full Name</h3>
                                                <h5 id="Designation" runat="server">Designation</h5>
                                            </div>
                                        </div>
                                        <div id="workArea" runat="server" class="workArea" style='<%# "display:"+Eval("WorkAreaDisplay")+";"%>'>
                                            <p runat="server" id="WorkArea1">workarea/service 1</p>
                                            <p runat="server" id="WorkArea2">workarea/service 2</p>
                                            <p runat="server" id="WorkArea3">workarea/service 3</p>
                                            <p runat="server" id="WorkArea4">workarea/service 4</p>
                                        </div>
                                        <div id="cardBody" class="about-hide" runat="server" style='<%# "display:"+Eval("CardBodyDisplay")+";"%>'>
                                            <h3 id="companyFullName" runat="server" class="company-full-name"></h3>
                                            <p runat="server" id="about1">About Company 1</p>
                                            <p runat="server" id="about2">About Company 2</p>
                                            <p runat="server" id="about3">About Company 3</p>
                                        </div>
                                        <div id="cardFooter" runat="server" class="cardFooter" style='<%# "text-align:"+Eval("CardFooterTextAlign")+";border-top:"+Eval("CardFooterBorderTop")+";padding-top:"+Eval("CardFooterPaddingTop")+";" %>'>
                                            <p id="Add1" runat="server">Address 1, Building No.</p>
                                            <p id="Add2" runat="server">Address 2, Street/Road No.</p>
                                            <p id="contact" runat="server">Contact numbers</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="overlay">
                                    <asp:HiddenField ID="hfCardName" runat="server" Value='<%# Eval("CardsName")%>' />
                                    <a href="AddOrModifyCards.aspx?cn=<%#Eval("CardsName")%>" target="_blank" class="anchor-btn">Edit Card</a>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
