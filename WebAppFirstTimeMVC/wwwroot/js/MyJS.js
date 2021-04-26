

function deleteCake(element,event) {
    //console.log(event);
    //console.log(element);
    event.preventDefault();

    var deleteUrl = event.target.href;

    $.get(deleteUrl,
        function (data, status) {
            alert("Data: " + data + "\nStatus: " + status);
            $("#" + data).remove();
        }
    ).fail(function (jqXHR, textStatus, errorThrown) {
        console.log("jqXHR", jqXHR);
        console.log("textStatus", textStatus);
        console.log("errorThrown", errorThrown);
        if (jqXHR.status == 404) {
            alert("Cake not found.\nwas not able to delete.")
        }
        else {
            alert("Status: " + jqXHR.status);
        }
    });
}