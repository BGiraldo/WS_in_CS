function callService() {

    var nombre = $("#txtNombre").val();

    $.ajax({
        url: "http://localhost:1656/WebService.asmx/HelloWorld",
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