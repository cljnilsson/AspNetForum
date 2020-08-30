$(document).ready(function () {
    $("#updateavatar").on("change", function () {
        var name = $('input[type=file]').val();
        console.log(name);
    });
});
