$().ready(function () {
    var webSocket = null;

    $("#disconnect").click(function () {
        if (webSocket.readyState === webSOcket.Open) {
            webSocket.close();
        }
    });

    $("#connect").click(function () {
        webSocket = new WebSocket("ws://" + window.location.hostname + ":12344/api/notifications");

        webSocket.onopen = function () {
            $("#status").text("Connected!");
        };

        webSocket.onerror = function (evt) {
            $("#status").text(evt.message);
        };

        webSocket.onmessage = function (evt) {
            $("notifications").text(evt.data);
        };
        webSocket.onclose = function () {
            $("#status").text("Disconnected");
        };
    });
});