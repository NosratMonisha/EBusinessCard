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