/// <reference path="../jquery-3.1.1.js" />
$(document).ready(function () {

    $("#BillingPostalCode").on("blur", function (event) {
        var zip = $("#BillingPostalCode").val();
        var subtotal = $("#subtotal span").text().substr(1);
        var urlString = "http://localhost:60980/api/getTax?billingZipCode=" + zip + "&subtotal=" + subtotal;
        $.ajax({
            url: urlString,
            dataType: "json"
        }).done(function (url) {
            console.log(url);
            if (url != undefined) {

                var tax = "$" + url;
                $("#tax span").text(tax);
            }
        });
    });

});