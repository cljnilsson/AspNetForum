let map = new Map();

function getUsers(parent) {
	return $(parent).find("small").not(".text-muted");
}

$("document").ready(() => {
	let threads = $(".thread").toArray();
	for(let t of threads) {
		let users = getUsers(t).toArray();
		for(let u of users) {
			let color = $(u).css("color");
			console.log(color);
			map.set(u, color);
		}
	}

	$(".thread").hover(function() {
		getUsers(this).css("color", "white");
	}, function() {
		let all = getUsers(this).toArray();
		for(let u of all) {
			$(u).css("color", map.get(u));
		}
	});
});