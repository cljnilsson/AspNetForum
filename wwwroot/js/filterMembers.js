function sortBy(rank) {
    var all;
    switch (rank) {
        case "Rank":
            all = $(".memberWrapper");
            var allRanks = $(".memberWrapper > .rankIdentify");
            break;
        case "Posts":
            all = $(".memberWrapper");
            all.sort(function (a, b) {
                var aText = $(a).find(".postIdentify").text();
                var i1 = Number(aText.replace("Posts: ", ""));
                var bText = $(b).find(".postIdentify").text();
                var i2 = Number(bText.replace("Posts: ", ""));
                return i2 - i1;
            });
            for (var _i = 0, all_1 = all; _i < all_1.length; _i++) {
                var e = all_1[_i];
                console.log($(e).find(".postIdentify").text());
            }
            all.remove();
            $(all).appendTo($("#memberAppend").parent());
            break;
        case "Newest":
            break;
    }
}
function isChecked(element) {
    return $(element).is(':checked');
}
$('#rank').on('change', function () {
    if (isChecked(this)) {
        sortBy("Rank");
    }
});
$('#post').on('change', function () {
    if (isChecked(this)) {
        sortBy("Posts");
    }
});
