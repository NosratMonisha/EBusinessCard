function liClick(li) {
    bg_color = li.style["background-color"];
    div = document.getElementById("ContentPlaceHolder1_ActualCard");
    div.style.backgroundColor = bg_color;
}

function liColorClick(li) {
    color = li.style["background-color"];
    div = document.getElementById("ContentPlaceHolder1_ActualCard");
    div.style.color = color;
}

//function liGradientClick(li) {
//    backgroundImage = li.style["background-image"];
//    div = document.getElementById("ContentPlaceHolder1_ActualCard");
//    div.style.backgroundImage = backgroundImage;
//}

function companyNameKeyUp(textBox) {
    text = textBox.value;
    companyName = document.getElementById("ContentPlaceHolder1_CompanyName");
    companyName.innerText = text;
}

function fullNameKeyUp(textBox) {
    text = textBox.value;
    fullName = document.getElementById("ContentPlaceHolder1_FullName");
    fullName.innerText = text;
}

function designtaionKeyUp(textBox) {
    text = textBox.value;
    designtation = document.getElementById("ContentPlaceHolder1_Designation");
    designtation.innerText = text;
}

function ExpertiseKeyUp(textBox) {
    text = textBox.value;
    expertise = document.getElementById("ContentPlaceHolder1_WorkArea1");
    expertise.innerText = text;
}

function expertise2KeyUp(textBox) {
    text = textBox.value;
    expertise2 = document.getElementById("ContentPlaceHolder1_WorkArea2");
    expertise2.innerText = text;
}

function phoneNumberKeyUp(textBox) {
    text = textBox.value;
    phoneNumber = document.getElementById("ContentPlaceHolder1_WorkArea3");
    phoneNumber.innerText = text;
}

function emailAddressKeyUp(textBox) {
    text = textBox.value;
    email = document.getElementById("ContentPlaceHolder1_WorkArea4");
    email.innerText = text;
}

function companyFullNameKeyUp(textBox) {
    text = textBox.value;
    companyFullName = document.getElementById("ContentPlaceHolder1_companyFullName");
    companyFullName.innerText = text;
}

function aboutCompanyKeyUp(textBox) {
    text = textBox.value;
    aboutCompany1 = document.getElementById("ContentPlaceHolder1_about1");
    aboutCompany1.innerText = text;
}

function aboutCompany2KeyUp(textBox) {
    text = textBox.value;
    aboutCompany2 = document.getElementById("ContentPlaceHolder1_about2");
    aboutCompany2.innerText = text;
}

function aboutCompany3KeyUp(textBox) {
    text = textBox.value;
    aboutCompany3 = document.getElementById("ContentPlaceHolder1_about3");
    aboutCompany3.innerText = text;
}

function address1KeyUp(textBox) {
    text = textBox.value;
    address1 = document.getElementById("ContentPlaceHolder1_Add1");
    address1.innerText = text;
}

function address2KeyUp(textBox) {
    text = textBox.value;
    address2 = document.getElementById("ContentPlaceHolder1_Add2");
    address2.innerText = text;
}

function contactNumberKeyUp(textBox) {
    text = textBox.value;
    contact = document.getElementById("ContentPlaceHolder1_contact");
    contact.innerText = text;
}
