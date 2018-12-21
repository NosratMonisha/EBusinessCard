<%@ Page Title="EBCard | Create Card" Language="C#" MasterPageFile="~/UI/IndexMaster.Master" AutoEventWireup="true" CodeBehind="CreateCard.aspx.cs" Inherits="EBusinessCard.UI.CreateCard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="up1" runat="server">
        <ContentTemplate>
            <div class="body-content" style="padding-top: 100px;">
                <div class="container full-height" style="height: 407px">
                    <div class="flex-container" style="overflow: auto">
                        <div id="CardProp" runat="server" class="card-prop">
                            <div class="content-flex">
                                <p>Select theme</p>
                                <asp:DropDownList ID="ddlTheme" runat="server" CssClass="ddl-options" AutoPostBack="true" OnSelectedIndexChanged="ddlTheme_SelectedIndexChanged">
                                    <asp:ListItem Text="Select theme" Value="-1"></asp:ListItem>
                                    <asp:ListItem Text="Professional" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="General" Value="1"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="content-flex" id="nameContainer" runat="server">
                                <p>Company's Short Name</p>
                                <asp:TextBox ID="txtCompanyName" runat="server" placeholder="ABC LTD." CssClass="txt-card-name"
                                    onkeyup="companyNameKeyUp(this);">
                                </asp:TextBox>
                            </div>

                            <div class="content-flex" id="Div1" runat="server">
                                <p>Full Name</p>
                                <asp:TextBox ID="txtUserFullName" runat="server" placeholder="User's Full Name" CssClass="txt-card-name"
                                    onkeyup="fullNameKeyUp(this);"></asp:TextBox>
                            </div>

                            <div class="content-flex" id="Div2" runat="server">
                                <p>Designation</p>
                                <asp:TextBox ID="txtDesignation" runat="server" placeholder="B.Sc. in SWE" CssClass="txt-card-name"
                                    onkeyup="designtaionKeyUp(this);"></asp:TextBox>
                            </div>

                            <div id="expertise" runat="server">
                                <div class="content-flex" id="Div3" runat="server">
                                    <p>Expertise On</p>
                                    <asp:TextBox ID="txtExpertiseOn" runat="server" placeholder="Front-End Developer" CssClass="txt-card-name"
                                        onkeyup="ExpertiseKeyUp(this);"></asp:TextBox>
                                </div>

                                <div class="content-flex" id="Div4" runat="server">
                                    <p>Expertise On 2</p>
                                    <asp:TextBox ID="txtExpertiseOn2" runat="server" placeholder="Expertise On 2" CssClass="txt-card-name"
                                        onkeyup="expertise2KeyUp(this);"></asp:TextBox>
                                </div>

                                <div class="content-flex" id="Div5" runat="server">
                                    <p>Cell Phone No.</p>
                                    <asp:TextBox ID="txtPhoneNumber" runat="server" placeholder="0123456789" CssClass="txt-card-name"
                                        onkeyup="phoneNumberKeyUp(this);"></asp:TextBox>
                                </div>

                                <div class="content-flex" id="Div6" runat="server">
                                    <p>Email Address</p>
                                    <asp:TextBox ID="txtEmail" runat="server" placeholder="abc@gmail.com" CssClass="txt-card-name"
                                        onkeyup="emailAddressKeyUp(this);"></asp:TextBox>
                                </div>
                            </div>

                            <div id="companySection" runat="server" class="none">
                                <div class="content-flex" id="Div7" runat="server">
                                    <p>Company's Full Name</p>
                                    <asp:TextBox ID="txtCompanyFullName" runat="server" placeholder="Atanasoff-Berry Computer" CssClass="txt-card-name"
                                        onkeyup="companyFullNameKeyUp(this);"></asp:TextBox>
                                </div>

                                <div class="content-flex" id="Div8" runat="server">
                                    <p>About Company 1</p>
                                    <asp:TextBox ID="txtAboutComp1" runat="server" placeholder="About Company1" CssClass="txt-card-name"
                                        onkeyup="aboutCompanyKeyUp(this);"></asp:TextBox>
                                </div>

                                <div class="content-flex" id="Div9" runat="server">
                                    <p>About Company 2</p>
                                    <asp:TextBox ID="txtAboutComp2" runat="server" placeholder="About Company2" CssClass="txt-card-name"
                                        onkeyup="aboutCompany2KeyUp(this);"></asp:TextBox>
                                </div>

                                <div class="content-flex" id="Div10" runat="server">
                                    <p>About Company 3</p>
                                    <asp:TextBox ID="txtAboutComp3" runat="server" placeholder="About Company3" CssClass="txt-card-name"
                                        onkeyup="aboutCompany3KeyUp(this);"></asp:TextBox>
                                </div>

                            </div>

                            <div class="content-flex" id="Div11" runat="server">
                                <p>Address 1</p>
                                <asp:TextBox ID="txtAddress1" runat="server" placeholder="Address 1" CssClass="txt-card-name"
                                    onkeyup="address1KeyUp(this);"></asp:TextBox>
                            </div>

                            <div class="content-flex" id="Div12" runat="server">
                                <p>Address 2</p>
                                <asp:TextBox ID="txtAddress2" runat="server" placeholder="Address 2" CssClass="txt-card-name"
                                    onkeyup="address2KeyUp(this);"></asp:TextBox>
                            </div>

                            <div class="content-flex" id="Div13" runat="server">
                                <p>Contact Number</p>
                                <asp:TextBox ID="txtContactNumber" runat="server" placeholder="Contact" CssClass="txt-card-name"
                                    onkeyup="contactNumberKeyUp(this);"></asp:TextBox>
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

<%--                            <div class="content-flex color">
                                <p>Gradient:</p>
                                <ul runat="server" id="gradientUl">
                                    <li title="Dusty Grass" style="background-image: linear-gradient(120deg, #d4fc79 0%, #96e6a1 100%);"
                                        data-color-code="linear-gradient(120deg, #d4fc79 0%, #96e6a1 100%);"
                                        onclick="liGradientClick(this)"></li>
                                    <li title="Blessing" style="background-image: linear-gradient(to right, #fddb92 0%, #d1fdff 100%);"
                                        data-color-code="linear-gradient(to top, #fddb92 0%, #d1fdff 100%);"
                                        onclick="liGradientClick(this)"></li>
                                    <li title="Wild Apple" style="background-image: linear-gradient(45deg, #d299c2 0%, #fef9d7 100%);"
                                        data-color-code="linear-gradient(to top, #d299c2 0%, #fef9d7 100%);"
                                        onclick="liGradientClick(this)"></li>
                                    <li title="Night Fade" style="background-image: linear-gradient(#ffffcc, #ccffff);"
                                        data-color-code="linear-gradient(#ffffcc, #ccffff);"
                                        onclick="liGradientClick(this)"></li>
                                </ul>
                            </div>--%>

                            <div class="btn-section">
                                <asp:Button ID="btnSaveCards" runat="server" Text="Download" CssClass="btn-save-card" OnClientClick="btnDownloadClick('BusinessCard')" />
                                <asp:Button ID="btnClearAll" runat="server" Text="Clear All" CssClass="btn-save-card" OnClick="btnClearAll_Click" />
                            </div>
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
                                            <p><span>Cell: </span><span runat="server" id="WorkArea3">workarea/service 3</span></p>
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
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
