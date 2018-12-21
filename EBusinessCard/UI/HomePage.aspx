<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/UI/IndexMaster.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="EBusinessCard.UI.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="body-content">
        <div class="container" style="flex-direction: column;">
            <div id="body-content-header">
                <div id="branding">
                    <h1>“There Are No Secrets to Success. It is the Result of Preparation, Hard Work, and Learning From
                        Failure.” – Colin Powell</h1>
                </div>
                <h1 id="subheading">Follow 3 easy steps and made your own business card</h1>
                <ul>
                    <li  style="background-image: linear-gradient(to left, #b8a1ec, #fbc2eb);">
                        <h5 class="body-content-header-list">Step-1</h5>
                        <p class="body-content-header-list-para">Choose template</p>
                    </li>
                    <li style="background-image: linear-gradient(to left, #FBC2EB, #BDD3F8);">
                        <h5 class="body-content-header-list">Step-2</h5>
                        <p class="body-content-header-list-para">Edit Template</p>
                    </li>
                    <li style="background-image: linear-gradient(to left, #afe1ff, #ffbec4);">
                        <h5 class="body-content-header-list">Step-3</h5>
                        <p class="body-content-header-list-para">Save it and get your business card</p>
                    </li>
                </ul>
            </div>
            <div id="body-content-middle1" class="body-content-middle">
                <div class="body-content-middle-left">
                    <h1>Make your visiting card own. Save time, save money.
                    </h1>
                    <div class="templatebtn">
                        <asp:Button ID="btnCreateCardTemplate" runat="server" Text="Create Card Template" OnClick="btnCreateCardTemplate_Click"/>
                    </div>
                </div>
                <div class="body-content-middle-right">
                    <img src="../Images/bcp-5.jpg" alt="pic1">
                </div>
            </div>
            <div id="body-content-middle2" class="body-content-middle">
                <div class="body-content-middle-left">
                    <h1>Make a visiting card for your company and give your employee a stannig card.
                    </h1>
                    <div class="templatebtn">
                        <asp:Button ID="btnEditCardTemplate" runat="server" Text="Edit Card Template" OnClick="btnEditCardTemplate_Click"/>
                    </div>
                </div>
                <div class="body-content-middle-right">
                    <img src="../Images/bcp-1.jpg" alt="pic2">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
