$(window).on("scroll", function () {
    if ($(window).scrollTop() > 15) {
        $(".container").addClass("on-scroll");
    } else {
        $(".container").removeClass("on-scroll");
    }
});

const tween = KUTE.fromTo(
    '#blobOne',
    { path: '#blobOne' },
    { path: '#blobTwo' },
    { repeat: 999, duration: 3000, yoyo: true }
).start();