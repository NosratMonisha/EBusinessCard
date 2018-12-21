function E_liClick(li) {
    bg_color = li.style["background-color"];
    div = document.getElementById("ContentPlaceHolder1_repeater_ActualCard_0");
    div.style.backgroundColor = bg_color;
}

function E_liColorClick(li) {
    color = li.style["background-color"];
    div = document.getElementById("ContentPlaceHolder1_repeater_ActualCard_0");
    div.style.color = color;
}

//function liGradientClick(li) {
//    backgroundImage = li.style["background-image"];
//    div = document.getElementById("ContentPlaceHolder1_repeater_ActualCard");
//    div.style.backgroundImage = backgroundImage;
//}

function E_companyNameKeyUp(textBox) {
    text = textBox.value;
    companyName = document.getElementById("ContentPlaceHolder1_repeater_CompanyName_0");
    companyName.innerText = text;
}

function E_fullNameKeyUp(textBox) {
    text = textBox.value;
    fullName = document.getElementById("ContentPlaceHolder1_repeater_FullName_0");
    fullName.innerText = text;
}

function E_designtaionKeyUp(textBox) {
    text = textBox.value;
    designtation = document.getElementById("ContentPlaceHolder1_repeater_Designation_0");
    designtation.innerText = text;
}

function E_ExpertiseKeyUp(textBox) {
    text = textBox.value;
    expertise = document.getElementById("ContentPlaceHolder1_repeater_WorkArea1_0");
    expertise.innerText = text;
}

function E_expertise2KeyUp(textBox) {
    text = textBox.value;
    expertise2 = document.getElementById("ContentPlaceHolder1_repeater_WorkArea2_0");
    expertise2.innerText = text;
}

function E_phoneNumberKeyUp(textBox) {
    text = textBox.value;
    phoneNumber = document.getElementById("ContentPlaceHolder1_repeater_WorkArea3_0");
    phoneNumber.innerText = text;
}

function E_emailAddressKeyUp(textBox) {
    text = textBox.value;
    email = document.getElementById("ContentPlaceHolder1_repeater_WorkArea4_0");
    email.innerText = text;
}

function E_companyFullNameKeyUp(textBox) {
    text = textBox.value;
    companyFullName = document.getElementById("ContentPlaceHolder1_repeater_companyFullName_0");
    companyFullName.innerText = text;
}

function E_aboutCompanyKeyUp(textBox) {
    text = textBox.value;
    aboutCompany1 = document.getElementById("ContentPlaceHolder1_repeater_about1_0");
    aboutCompany1.innerText = text;
}

function E_aboutCompany2KeyUp(textBox) {
    text = textBox.value;
    aboutCompany2 = document.getElementById("ContentPlaceHolder1_repeater_about2_0");
    aboutCompany2.innerText = text;
}

function E_aboutCompany3KeyUp(textBox) {
    text = textBox.value;
    aboutCompany3 = document.getElementById("ContentPlaceHolder1_repeater_about3_0");
    aboutCompany3.innerText = text;
}

function E_address1KeyUp(textBox) {
    text = textBox.value;
    address1 = document.getElementById("ContentPlaceHolder1_repeater_Add1_0");
    address1.innerText = text;
}

function E_address2KeyUp(textBox) {
    text = textBox.value;
    address2 = document.getElementById("ContentPlaceHolder1_repeater_Add2_0");
    address2.innerText = text;
}

function E_contactNumberKeyUp(textBox) {
    text = textBox.value;
    contact = document.getElementById("ContentPlaceHolder1_repeater_contact_0");
    contact.innerText = text;
}
