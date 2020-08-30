$( document ).ready(function() {
    $("#updateavatar").on("change", () => {
		let name = $('input[type=file]').val();
		console.log(name);

		
	});
});