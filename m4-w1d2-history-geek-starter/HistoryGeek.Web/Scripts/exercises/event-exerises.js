/// <reference path="../jquery-3.1.1.js" />

$(document).ready(function () {
    $("input[name='SameShipping']").on("change", function (event) {
        if (this.checked) {
            $("#billing-info input[name='ShippingAddress1'").val($("#billing-info input[name='BillingAddress1'").val());
            $("#billing-info input[name='ShippingAddress2'").val($("#billing-info input[name='BillingAddress2'").val());
            $("#billing-info input[name='ShippingCity'").val($("#billing-info input[name='BillingCity'").val());
            $("#billing-info input[name='ShippingState'").val($("#billing-info input[name='BillingState'").val());
            $("#billing-info input[name='ShippingPostalCode'").val($("#billing-info input[name='BillingPostalCode'").val());
        }
    });

    $("#shipping-info input[type='radio']").change(function (event) {
        var shippingRate = $("#shipping-info input[type='radio']:checked").next().text().split(" ")[2];
        $("#shipping span").text(shippingRate);
        var total = 0;
        total += +shippingRate.substring(1, shippingRate.length);
        total += +$("#subtotal span").text().substring(1, $("#subtotal span").text().length);
        $("#grandtotal span").text(total);
    });

    $("#btnRestart").click(function (e) {
        $("#gameboard tr td.gamecell.ship").removeClass("ship");
        $("#row_0_column_0").addClass("ship");
        
    });


    $(document).keydown(function (event) {
        var rowLength = $("#gameboard tr").length;
        var columnLength = $("#gameboard tr td").length / rowLength;
        var shipId = $("#gameboard tr td.gamecell.ship").attr("id").split('_');

        switch (event.which) {
            case 37: // left
                var newShipId = +shipId[3] - 1;
                if (newShipId >= 0 && shipId[1] >= 0) {
                    if (!($("#row_" + shipId[1] + "_column_" + newShipId).hasClass("iceberg") || $("#row_" + shipId[1] + "_column_" + newShipId).hasClass("pirate"))) {

                        $("#gameboard tr td.gamecell.ship").removeClass("ship");
                        $("#row_" + shipId[1] + "_column_" + newShipId).addClass("ship");
                    }
                }

                break;

            case 38: // up
                var newShipId = +shipId[1] - 1;
                if (newShipId >= 0 && shipId[3] >= 0) {
                    if (!($("#row_" + newShipId + "_column_" + shipId[3]).hasClass("iceberg") || $("#row_" + newShipId + "_column_" + shipId[3]).hasClass("pirate"))) {

                        $("#gameboard tr td.gamecell.ship").removeClass("ship");
                        $("#row_" + newShipId + "_column_" + shipId[3]).addClass("ship");
                    }
                }
                break;

            case 39: // right
                var newShipId = +shipId[3] + 1;
                if (newShipId < rowLength && shipId[1] < columnLength) {
                    if (!($("#row_" + shipId[1] + "_column_" + newShipId).hasClass("iceberg") || $("#row_" + shipId[1] + "_column_" + newShipId).hasClass("pirate"))) {
                        $("#gameboard tr td.gamecell.ship").removeClass("ship");
                        $("#row_" + shipId[1] + "_column_" + newShipId).addClass("ship");
                    }
                }
                break;

            case 40: // down
                var newShipId = +shipId[1] + 1;
                if (newShipId < rowLength && shipId[3] < columnLength) {
                    if (!($("#row_" + newShipId + "_column_" + shipId[3]).hasClass("iceberg") || $("#row_" + newShipId + "_column_" + shipId[3]).hasClass("pirate"))) {
                        $("#gameboard tr td.gamecell.ship").removeClass("ship");
                        $("#row_" + newShipId + "_column_" + shipId[3]).addClass("ship");
                    }
                }
                break;

            default: return; // exit this handler for other keys
        }
        event.preventDefault();
    });
});




