<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Redirect.aspx.cs" Inherits="EBusinessCard.UI.Redirect" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Redirect</title>
    <style>
        @font-face {
            font-family: 'OpenSans-Light';
            src: url('../fonts/OpenSans-Light.ttf') format('truetype');
        }

        .message {
            width: 100%;
            margin-top: 250px;
            color: #2692c3;
            font-size: 40px;
            font-family: 'OpenSans-Light', Calibri;
            font-weight: normal !important;
            text-align: center;
        }

        a {
            color: #ff8888;
            text-decoration: none;
        }

            a:hover {
                text-decoration: underline;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container message">
            <asp:Literal ID="lrlMessage" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
