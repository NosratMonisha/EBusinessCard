<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="EBusinessCard.UI.registration" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Personal Registration Form</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
     <link href="../css/registration.css" rel="stylesheet" />
</head>
<body>

    <form runat="server" id="RegistrationForm">
        <div id="form-header">
            <h1 id="title">Registrstion</h1>
            <p id="description">Create personal account</p>
        </div>
        <div id="form-content">
            <div id="form-content-input">
                <div class="content-input-tabs">
                    <div class="input-left-tabs">
                        <label id="Name-label" for="name">Full Name :</label>
                    </div>
                    <div class="input-right-tabs">
                        <input runat="server" type="text" id="txtFullName" class="input-field" placeholder="Enter Full Name" required>
                    </div>
                </div>

                <div class="content-input-tabs">
                    <div class="input-left-tabs">
                        <label id="Userame-label" for="username">Username :</label>
                    </div>
                    <div class="input-right-tabs">
                        <input runat="server" type="text" id="txtUsername" class="input-field" placeholder="Enter Userame" required>
                    </div>
                </div>
                <div class="content-input-tabs">
                    <div class="input-left-tabs">
                        <label id="email-label" for="email">Email :</label>
                    </div>
                    <div class="input-right-tabs">
                        <input runat="server" type="email" id="txtEmail" class="input-field" placeholder="Enter Email Address" required>
                    </div>
                </div>
                <div class="content-input-tabs">
                    <div class="input-left-tabs" id="Dob-label">
                        <label for="number">Date of Birth :</label>
                    </div>
                    <div class="input-right-tabs">
                        <input runat="server" type="date" id="txtDOB" class="input-field" placeholder="Enter date of birth">
                    </div>
                </div>

                <div class="content-input-tabs">
                    <div class="input-left-tabs">
                        <label id="phnNumber-label" for="phnNumber-label">Phone Number :</label>
                    </div>
                    <div class="input-right-tabs" style="margin-left:20px;">
                        <input runat="server" type="Number" id="txtPhoneNumber" class="input-field" placeholder="Enter phone number" required>
                    </div>
                </div>
                <div class="content-input-tabs">
                    <div class="input-left-tabs">
                        <label for="address" id="address-label">Address:</label>
                    </div>
                    <div class="input-right-tabs">
                        <textarea runat="server" id="taAddress" name="address" placeholder="Enter Your address"></textarea>
                    </div>
                </div>
                <div class="content-input-tabs extra">
                    <div class="input-left-tabs">
                        <label id="password-label" for="Password">Password :</label>
                    </div>
                    <div class="input-right-tabs">
                        <input runat="server" type="password" id="txtPassword" class="input-field" placeholder="Enter Password" required>
                    </div>
                </div>
            </div>
        </div>
        <div id="form-footer">
            <asp:Button runat="server" CssClass="button" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click"/>
        </div>
    </form>
</body>
</html>
