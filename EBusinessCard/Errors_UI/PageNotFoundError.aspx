<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageNotFoundError.aspx.cs" Inherits="EBusinessCard.Errors_UI.PageNotFoundError" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page Not Found</title>
    <style>
        @font-face {
            font-family: 'OpenSans-Light';
            src: url('../fonts/OpenSans-Light.ttf') format('truetype');
        }

        h1 {
            font-family: 'OpenSans-Light', Calibri;
            font-weight: normal;
        }

        .h1 {
            margin-top: 0px;
            color: #ff6666;
            font-size: 70px;
            text-align: center;
        }

        .f-h1 {
            font-size: 100px;
            margin-bottom: 0px;
            margin-top: 180px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="h1 f-h1">404!</h1>
            <h1 class="h1">PAGE NOT FOUND!</h1>
        </div>
    </form>
</body>
</html>
