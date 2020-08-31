var map = new Map();
function getUsers(parent) {
    return $(parent).find("small").not(".text-muted");
}
$("document").ready(function () {
    var threads = $(".thread").toArray();
    for (var _i = 0, threads_1 = threads; _i < threads_1.length; _i++) {
        var t = threads_1[_i];
        var users = getUsers(t).toArray();
        for (var _a = 0, users_1 = users; _a < users_1.length; _a++) {
            var u = users_1[_a];
            var color = $(u).css("color");
            console.log(color);
            map.set(u, color);
        }
    }
    $(".thread").hover(function () {
        getUsers(this).css("color", "white");
    }, function () {
        var all = getUsers(this).toArray();
        for (var _i = 0, all_1 = all; _i < all_1.length; _i++) {
            var u = all_1[_i];
            $(u).css("color", map.get(u));
        }
    });
});
