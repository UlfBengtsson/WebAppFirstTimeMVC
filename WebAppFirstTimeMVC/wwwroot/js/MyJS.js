

function deleteCake(element,event) {
    console.log(event);
    console.log(element);
    event.preventDefault();

    var deleteUrl = event.target.href;

    $.get(deleteUrl,
        function (data, status) {
            alert("Data: " + data + "\nStatus: " + status);
            $("#" + data).remove();
        }
    );
}