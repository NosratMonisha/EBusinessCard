<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EBusinessCard.Login" %>

<!DOCTYPE html>
<html>
<head>
    <title>Login</title>
    <link href="../css/font-style.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    <link href="../LocalCDN/font-awesome.css" rel="stylesheet" />
</head>
<body>
    <form runat="server" id="loginForm">
        <div id="box">
            <div id="content">
                <div id="content1" class="content">
                    <h1>Login</h1>
                </div>

                <div id="content2" class="content">
                    <label class="lbl">Username</label>
                    <input runat="server" id="txtUsername" class="txtbox" type="text" placeholder="Enter Username" required>
                    <label class="lbl">Password</label>
                    <input runat="server" id="txtPassword" class="txtbox" type="password" placeholder="Enter Password" required>
                </div>

                <div id="content3" class="content">
                    <asp:Button CssClass="button" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    <p><a href="#" target="_blank">Lost your password?</a></p>
                    <p><a href="registration.aspx">Don't have an account?</a></p>
                </div>
            </div>
        </div>

        <div class="error" id="errorDiv" runat="server">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>


