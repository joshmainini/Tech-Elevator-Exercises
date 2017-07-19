/// <reference path="../jquery-3.1.1.js" />

$(document).ready(function () {

    $("#SameShipping").click(function () {

        $("#ShippingAddress1").val($("#BillingAddress1").val());
        $("#ShippingAddress2").val($("#BillingAddress2").val());
        $("#ShippingCity").val($("#BillingCity").val());
        $("#ShippingState").val($("#BillingState").val());
        $("#ShippingPostalCode").val($("#BillingPostalCode").val());

    });

    $("input[name='ShippingType']").click(function () {
        var cost = $(this).data('cost');
        $("#shipping .price").text(cost);
        var total = grandTotal($(this).data('cost'), $("#subtotal .price").text(), $("#tax .price").text());
        $("#grandtotal .price").text(total);

    });
    $("#btnRestart").click(function () {
        $(".ship").removeClass();
        $("#row_0 #row_0_column_0").addClass("ship");
    });

   
    function grandTotal(shipping, subtotal, tax) {
        var resultShip = shipping.substr(1);
        var resultSub = subtotal.substr(1);
        var resultTax = tax.substr(1);

        var newShip = parseFloat(resultShip);
        var newSub = parseFloat(resultSub);
        var newTax = parseFloat(resultTax);

        var result = newShip + newSub + newTax;

        return "$" + result.toFixed(2);
    };
});




