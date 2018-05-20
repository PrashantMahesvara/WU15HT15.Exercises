var xmlHttpRequest = null;
if (window.XMLHttpRequest) {
    xmlHttpRequest = new XMLHttpRequest();
} else {
    xmlHttpRequest = new ActiveXObject("Microsoft.XMLHTTP");
}

xmlHttpRequest.open("GET", "http://localhost:55024/API/Products", true);
xmlHttpRequest.send();

xmlHttpRequest.onreadystatechange = function () {
    if (xmlHttpRequest.readyState === 4 && xmlHttpRequest.status === 200) {

        var data = xmlHttpRequest.responseText;
        processText(data);
        formatData(data);
    }
}

function processText(data) {
    var div = document.getElementById("text");
    div.innerHTML = data;
}

function formatData(data) {
    var items = JSON.parse(data);
    var template = "<ul>";
    for (var index = 0; index < items.length; index++) {
        var item = items[index];
        template += "<li>" + item.name + " ( " + item.price + " )</li>";
    }
    template += "</ul>";

    var div = document.getElementById("json");
    div.innerHTML = template;
}