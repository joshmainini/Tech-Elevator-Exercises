function sumDouble(number1, number2) {
    if (number1 == number2) {
        return (number1 + number2) * 2;
    }
    else {
        return number1 + number2;
    }
}
function hasTeen(num1, num2, num3) {
    var result = false;
    var nums = [num1, num2, num3];
    nums.forEach(function (num) {
        if ((num >= 13) && (num <= 19)) {
            return result = true;
        }

    });
    return result;
}
function lastDigit(num1, num2) {
    if ((num1 % 10) == (num2 % 10)) {
        return true;
    }
    else {
        return false;
    }
}
function seeColor(word) {
    if (word.indexOf("blue") === 0) {
        word = "blue";
        return word;
    }
    else if (word.indexOf("red") == 0) {
        word = "red";
        return word;
    }
    else {
        word = "";
        return word;
    }
}
function middleThree(word) {
    var result = word.substr(Math.floor(word.length/2)-1, 3);
    return result;
}
function frontAgain(word) {
    if (word.substr(0, 2) == word.substr(word.length - 2)) {
        return true;
    }
    else {
        return false;
    }
}
function alarmClock(weekDay, isVacation) {
    if (isVacation) {
        switch (weekDay) {
            case 1:
                return "10:00"
                break;
            case 2:
                return "10:00"
                break;
            case 3:
                return "10:00"
                break;
            case 4:
                return "10:00"
            case 5:
                return "10:00"
                break;
            case 6:
                return "off"
                break;
            case 0:
                return "off"
                break;
            default:
                return "No alarm"
                break;
        }
    }
    else {
        switch (weekDay) {
            case 1:
                return "7:00"
                break;
            case 2:
                return "7:00"
                break;
            case 3:
                return "7:00"
                break;
            case 4:
                return "7:00"
            case 5:
                return "7:00"
                break;
            case 6:
                return "10:00"
                break;
            case 0:
                return "10:00"
                break;
            default:
                return "No Alarm"
                break;
        }
    }
}
    
function makeMiddle(array) {

    var midArr = [];

    if (array.length >= 2) {
        if (array.length % 2 == 0) {
            var half = array.length / 2;
            midArr[0] = array[half - 1];
            midArr[1] = array[half];
            return midArr;
        }
        else {
            return midArr;
        }
    }
    else {
        return midArr;
    }
}
function oddOnly(array) {
    var resultArray = [];
    for (var i = 0; i < array.length; i++) {
        if (array[i] % 2 != 0) {
            resultArray.push(array[i]);
        }
    }
    return resultArray;
}
function weave(array1, array2) {
    var resultArray = [];
    if (array1.length > array2.length) {
        for (var i = 0; i < array1.length; i++) {
            resultArray.push(array1[i]);
            if (array2[i] != null) {
                resultArray.push(array2[i]);
            }
          
        }
    }
    else {
        for (var i = 0; i < array2.length; i++) {
            if (array1[i] != null) {
                resultArray.push(array1[i]);
            }
            resultArray.push(array2[i]);
        }
    }
    return resultArray;
}
function cigarParty(cigarNum, isWeekend) {
    if (isWeekend && cigarNum >= 40) {
        return true;
    }
    else if (cigarNum >= 40 && cigarNum <= 60) {
        return true;
    }
    else {
        return false;
    }
}
function stringSplosion(word) {
    var result = "";
    for (var i = 0; i < word.length + 1; i++) {
        result = result + word.substr(0, i);
    }
    return result;
}
function fizzBuzz(num) {
    var result;
    if ((num % 3 == 0) && (num % 5 == 0)) {
        result = "FizzBuzz";
    }
    else if (num % 3 == 0) {
        result = "Fizz";
    }
    else if (num % 5 == 0) {
        result = "Buzz";
    }
    else {
        result = num;
    }
    return result;
}
function countValues(array) {
    var resultArray = []
    for (var i = 0; i < array.length; i++)
    {
        if (resultArray[array[i]] == null) {
            resultArray[array[i]] = 1;
        }
        else {
           var tempArray = resultArray[array[i]];

            resultArray[array[i]] = tempArray + 1;
        }
    }
    return resultArray;
}
function reverseArray(array) {
    var resultArray = [];
    var index = array.length -1; 
    var i = 0;

    while(index > -1)
    {

        resultArray[i] = array[index]
        index--;
        i++;
   }
    return resultArray;
}
function blackJack(num1, num2) {
    var result = 0;
    if ((num1 > 21) && (num2 > 21)) {
        return result;
    }
    else if (num1 > 21) {
        result = num2;
    }
    else if (num2 > 21) {
        result = num1;
    }
    else if ((21 - num1) > (21 - num2)) {
        result = num1;
    }
    else {
        result = num2;
    }
    return result;
}