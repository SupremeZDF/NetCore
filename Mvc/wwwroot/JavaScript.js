var query = window.location.search.substring(1);
var querys = query.split("&")
console.log(window.location.search);
console.log(window.location);
for (var i = 0; i < querys.length; i++) {
    var oo = querys[i].split("=");
    if (oo[0] == "callBack") {
        var gg = "";

        $.ajax({
            type: "get",
            dataType: "text",
            contentType: "application/json",
            url: "http://localhost:50845/api/Jsonp/GetJson",
            success: function (data) {
                gg = data;
                console.log(oo[1] + "(" + data + ")");
                eval(oo[1] + "(" + data + ")");
            }
        })
        //alert(oo[1]);
    }
}
console.log(query);
function uuu(data) {
    alert(JSON.stringify(data));
}

