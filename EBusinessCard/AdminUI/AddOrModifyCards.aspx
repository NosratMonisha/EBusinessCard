<%@ Page Title="" Language="C#" MasterPageFile="~/AdminUI/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddOrModifyCards.aspx.cs" Inherits="EBusinessCard.AdminUI.AddOrModifyCards" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="up1" runat="server">
        <ContentTemplate>
            <div class="childContent">
                <div class="container">
                    <div class="flex-container">
                        <div class="content-flex">
                            <p>Select what you want?</p>
                            <asp:DropDownList ID="ddlOptions" runat="server" CssClass="ddl-options" AutoPostBack="true" OnSelectedIndexChanged="ddlOptions_SelectedIndexChanged">
                                <asp:ListItem Text="Select your Option" Value="-1"></asp:ListItem>
                                <asp:ListItem Text="Add New Cards" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Modify Cards" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Delete Cards" Value="3"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="content-flex hidden" id="CardId" runat="server">
                            <p>Choose Card</p>
                            <asp:DropDownList ID="ddlCardID" runat="server" CssClass="ddl-options" OnSelectedIndexChanged="ddlCardID_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                        </div>

                        <div id="CardProp" runat="server" class="card-prop">
                            <div class="content-flex" id="nameContainer" runat="server">
                                <p>Enter Cards Name</p>
                                <asp:TextBox ID="txtCardName" runat="server" placeholder="Enter cards name" CssClass="txt-card-name" CausesValidation="true" required></asp:TextBox>
                            </div>
                            <div class="content-flex">
                                <p>Select theme</p>
                                <asp:DropDownList ID="ddlTheme" runat="server" CssClass="ddl-options" AutoPostBack="true" OnSelectedIndexChanged="ddlTheme_SelectedIndexChanged">
                                    <asp:ListItem Text="Select theme" Value="-1"></asp:ListItem>
                                    <asp:ListItem Text="Professional" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="General" Value="1"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="content-flex color">
                                <p>Background Color:</p>
                                <ul runat="server" id="colorUl">
                                    <li title="gray" style="background: #555" data-color-code="#555" onclick="liClick(this)"></li>
                                    <li title="darkcyan" style="background: #4ca" data-color-code="#4ca" onclick="liClick(this)"></li>
                                    <li title="denim" style="background: #262c3a" data-color-code="#262c3a" onclick="liClick(this)"></li>
                                    <li title="naturalgreen" style="background: #4caf50" data-color-code="#4caf50" onclick="liClick(this)"></li>
                                    <li title="smoke" style="background: #f5f5f5" data-color-code="#f5f5f5" onclick="liClick(this)"></li>
                                    <li title="black" style="background: #111" data-color-code="#111" onclick="liClick(this)"></li>
                                    <li title="lightred" style="background: #ff8888" data-color-code="#ff8888" onclick="liClick(this)"></li>
                                </ul>
                            </div>

                            <div class="content-flex color">
                                <p>Text Color:</p>
                                <ul runat="server" id="colorUl2">
                                    <li title="white" style="background: #fff" data-color-code="#fff" onclick="liColorClick(this)"></li>
                                    <li title="black" style="background: #000" data-color-code="#000" onclick="liColorClick(this)"></li>
                                    <li title="gray" style="background: #555" data-color-code="#555" onclick="liColorClick(this)"></li>
                                </ul>
                            </div>

                            <div class="btn-section">
                                <asp:Button ID="btnSaveCards" runat="server" Text="Save Card" CssClass="btn-save-card" OnClientClick="ffd()" />
                                <asp:Button ID="btnClearAll" runat="server" Text="Clear All" CssClass="btn-save-card" OnClick="btnClearAll_Click" />
                            </div>
                        </div>
                        <div class="btn-section hidden" id="DeleteContainer" runat="server">
                            <asp:Button ID="btnDelete" runat="server" Text="Delete Card" CssClass="btn-save-card" OnClick="btnDelete_Click" />
                        </div>
                    </div>
                    <div class="right-side-display">
                        <div class="card-display">
                            <div class="card-container">
                                <div class="actual-card" id="ActualCard" runat="server">
                                    <div id="cardHolder" class="cardHolder" runat="server">
                                        <div id="cardHead" runat="server" class="cardHead">
                                            <div id="companyName">
                                                <h3 runat="server" id="CompanyName">ABC LTD.</h3>
                                            </div>
                                            <div>
                                                <h3 runat="server" id="FullName">User's Full Name</h3>
                                                <h5 id="Designation" runat="server">Designation</h5>
                                            </div>
                                        </div>
                                        <div id="workArea" runat="server" class="workArea">
                                            <p runat="server" id="WorkArea1">workarea/service 1</p>
                                            <p runat="server" id="WorkArea2">workarea/service 2</p>
                                            <p runat="server" id="WorkArea3">workarea/service 3</p>
                                            <p runat="server" id="WorkArea4">workarea/service 4</p>
                                        </div>
                                        <div id="cardBody" class="about-hide" runat="server">
                                            <h3 id="companyFullName" runat="server" class="company-full-name"></h3>
                                            <p runat="server" id="about1">About Company 1</p>
                                            <p runat="server" id="about2">About Company 2</p>
                                            <p runat="server" id="about3">About Company 3</p>
                                        </div>
                                        <div id="cardFooter" runat="server" class="cardFooter">
                                            <p id="Add1" runat="server">Address 1, Building No.</p>
                                            <p id="Add2" runat="server">Address 2, Street/Road No.</p>
                                            <p id="contact" runat="server">Contact numbers</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="container">
                    <div class="status" id="status" runat="server">
                        <h1 id="statusH1" runat="server">Successfully Saved new Cards !</h1>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
