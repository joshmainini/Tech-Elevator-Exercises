/// <reference path="../jquery-3.1.1.js" />
//Locate all <div> elements and add the 'president' class.
function presentialDivs() {
    $("#btnPresident").click(function () {
        $("div").addClass("president");
    });
};

//Locate George Washington and add the 'founding-father' class
function georgeWashington() {
    $("#btnFoundingFather").click(function () {
        $("#george-washington").addClass("founding-father");
    });
}

//Locate all Republican presidents and add the 'red' class.
function republicanPresidents() {
    $("#btnRepublicans").click(function () {
        $(".Republican").addClass("red");
    });
}

//Locate all Democrat presidents and add the 'blue' class.
function democratPresidents() {
    $("#btnDemocrats").click(function () {
        $(".Democratic").addClass("blue");
    });
}

//Locate all Federalist presidents and add the 'gold' class.
function otherPresidents() {
    $("#btnOther").click(function () {
        $(".Federalist, .Nonpartisan, .Democratic-Republican, .Whig, .National ").addClass("gold");
    });
}

//Locate all presidents named 'James' and add the 'james' class.
function presidentsNamedJames() {
    $("#btnJames").click(function () {
        $('[id^=james-]').addClass("james");
    });
}

//Locate each president serving at the beginning of each century and add the 'beginningOfCentury' class.
function turnOfTheCenturyPresidents() {
    $("#btnBeginningOfCentury").click(function () {
        $("h2").next().addClass("beginningOfCentury");
    });
}

//Locate each president serving at the end of the century and add the 'endOfCentury' class.
function endOfTheCenturyPresidents() {
    
    $("#btnEndOfCentury").click(function () {
        $("h2").prev().addClass("endOfCentury");
    });
}

//Locate all presidents serving in the 1900s who appear on currency and add the 'appearOnCurrency' class.
function currencyPresidents() {
    
    $("#btnAppearOnCurrency").click(function () {
        $("h2:contains('1900s')").nextUntil("h2", ".currency").addClass("appearOnCurrency");
    });
}