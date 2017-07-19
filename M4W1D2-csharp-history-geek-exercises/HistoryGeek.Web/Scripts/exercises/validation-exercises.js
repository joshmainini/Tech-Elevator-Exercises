/// <reference path="../jquery-3.1.1.js" />
/// <reference path="../jquery.validate.js" />

$(document).ready(function () {

    // Validate takes an object, not a function
    // Objects in javascript use { .. } notation and are the same as key / value pairs
    $("#form0").validate({

        debug: false,
        rules: {
            EmailAddress: {
                required: true, 
                email: true,                        
            },
            Password: {
                required: true,         
                minlength: 8,          
                strongpassword: true    
            },
            verifyPassword: {
                equalTo: "#Password"  
                
            },

        },
        messages: {
            EmailAddress: {
                required: "Email Address is required."
            },
            Password: {
                required: "Password is required.",
                minlength: "Password must be at least 8 characters."
            }

        },
        errorClass: "errorSummary",
        validClass: "field-validation-error"

    
    });
    $("#checkout").validate({
        
        debug: true,
        rules: {
            //card info
            NameOnCard: {
                required: true
            },
            CreditCardNumber: {
                required: true,
             
            },
            ExpirationDate: {
                Date: true
            },
            //billing and shipping info
            BillingAddress1: {
                required: true
            },
            ShippingAddress1: {
                required: true
            },
            BillingCity: {
                required: true
            },
            ShippingCity: {
                required: true
            },
            ShippingState: {
                required: true
            },
            BillingState: {
                required: true
            },
            ShippingPostalCode: {
                required: true
            },
            BillingPostalCode: {
                required: true
            },
            //shipping preference
            ShippingType: {
                required: true,
                maxlength: 1
            },

            
        },
        messages: {
            NameOnCard: {
                required: "Name if the cardholder is required."
            },
            ExperationDate: {
                date: "Please enter a valid date."
            },
              CreditCardNumber: {
                required: "Card number is required.",
              
            },


        },
        errorClass: "errorSummary",
        validClass: "field-validation-error"


        
    });

});


$.validator.addMethod("strongpassword", function (value, index) {
    return value.match(/[A-Z]/) && value.match(/[a-z]/) && value.match(/\d/);  //check for one capital letter, one lower case letter, one num
}, "Please enter a strong password (one capital, one lower case, and one number");




