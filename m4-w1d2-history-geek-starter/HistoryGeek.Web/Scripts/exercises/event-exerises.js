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
        $("#grandtotal span").text(shippingRate.substring(1, shippingRate.length) + $("#subtotal span").text());
        

    });
});




