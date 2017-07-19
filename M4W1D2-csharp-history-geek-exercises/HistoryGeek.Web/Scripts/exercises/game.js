$(document).ready(function () {
    if ($('#game') != undefined) {

        $(document).keydown(function (e) {
            switch (e.key) {
                case "ArrowLeft":
                    $(".gamecell.ship").prev().addClass("ship");
                    $(".gamecell.ship").next().removeClass("ship");

                    if ($(".ship").hasClass("iceberg") || $(".ship").hasClass("pirate")) {
                        $(".ship").removeClass();
                        alert("YOOOOOOOOU LOOOOOOOSEEEE!!");
                        $(".ship").removeClass();

                        $("#row_0 #row_0_column_0").addClass("ship");
                    }
                    if ($(".ship").hasClass("treasure")) {
                        $(".ship").removeClass();
                        alert("ERRRMA GERSHHH YOU WINNNN!!");
                        $(".ship").removeClass();
                        $("#row_0 #row_0_column_0").addClass("ship");
                        $("#row_9 #row_9_column_9").addClass("treasure");

                    }

                    break;
                case "ArrowUp":
                    var index = $(".ship").index();
                    $(".gamecell.ship").parent().prev().children().eq(index).addClass("ship");
                    $(".gamecell.ship").parent().next().children().eq(index).removeClass("ship");

                    if ($(".ship").hasClass("iceberg") || $(".ship").hasClass("pirate")) {
                        $(".ship").removeClass();
                        alert("YOOOOOOOOU LOOOOOOOSEEEE!!");
                        $(".ship").removeClass();
                        $("#row_0 #row_0_column_0").addClass("ship");
                    }
                    if ($(".ship").hasClass("treasure")) {
                        $(".ship").removeClass();
                        alert("ERRRMA GERSHHH YOU WINNNN!!");
                        $(".ship").removeClass();
                        $("#row_0 #row_0_column_0").addClass("ship");
                        $("#row_9 #row_9_column_9").addClass("treasure");
                    }
                    break;
                case "ArrowRight":
                    $(".gamecell.ship").next().addClass("ship");
                    $(".gamecell.ship").prev().removeClass("ship");

                    if ($(".ship").hasClass("iceberg") || $(".ship").hasClass("pirate")) {
                        $(".ship").removeClass();
                        alert("YOOOOOOOOU LOOOOOOOSEEEE!!");
                        $(".ship").removeClass();
                        $("#row_0 #row_0_column_0").addClass("ship");

                    }
                    if ($(".ship").hasClass("treasure")) {
                        $(".ship").removeClass();
                        alert("ERRRMA GERSHHH YOU WINNNN!!");
                        $(".ship").removeClass();
                        $("#row_0 #row_0_column_0").addClass("ship");
                        $("#row_9 #row_9_column_9").addClass("treasure");
                    }
                    break;
                case "ArrowDown":
                    var ship = $(".ship");
                    var index = $(".ship").index();
                    $(".gamecell.ship").parent().next().children().eq(index).addClass("ship");
                    $(".gamecell.ship").parent().prev().children().eq(index).removeClass("ship");
                    ship.removeClass("ship");

                    if ($(".ship").hasClass("iceberg") || $(".ship").hasClass("pirate")) {
                        $(".ship").removeClass();
                        alert("YOOOOOOOOU LOOOOOOOSEEEE!!");
                        $(".ship").removeClass();
                        $("#row_0 #row_0_column_0").addClass("ship");
                    }
                    if ($(".ship").hasClass("treasure")) {
                        $(".ship").removeClass();
                        alert("ERRRMA GERSHHH YOU WINNNN!!");
                        $(".ship").removeClass();
                        $("#row_0 #row_0_column_0").addClass("ship");
                        $("#row_9 #row_9_column_9").addClass("treasure");
                    }
                    break;

            }

            return false;
        });
    }
});