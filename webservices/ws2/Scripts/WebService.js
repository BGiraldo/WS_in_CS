function callService() {

    var nombre = $("#txtNombre").val();

    $.ajax({
        url: "http://localhost:1672/WebS1.asmx/HelloWorldo",
        type: "Post",
        data: "{'nombre':'"+nombre+"'}",
        contentType: "application/json",
        success: function (data) {
            $("#lblRespuesta").text(data.d);
        },
        error: function (a, b, c) {
            alert(a + "-" + b + "-" + c);
        }
    });
}