function iqTest(string) {
    var array = string.split(" ");
    var evenCount = 0;
    var oddCount = 0;
    var result;
    for (var i = 0; i < array.length; i++) {
        if (array[i] % 2 == 0) {
            evenCount++;
        }
        else if (array[i] % 2 != 0) {
            oddCount++;
        }
    }
    if (oddCount > evenCount) {
        if (evenCount > 0) {
            for (var i = 0; i < array.length; i++) {
                if (array[i] % 2 == 0) {
                    result = i + 1;
                }
            }
        }
        else {
            result = 0;
        }
    }
    else if (evenCount > oddCount) {
        if (oddCount > 0) {
            for (var i = 0; i < array.length; i++) {
                if (array[i] % 2 != 0) {
                    result = i + 1;
                }
            }

        }
        else {
            result = 0;
        }
    }
    else {
        result = 0;
    }
    return result;
}
function titleCase(title, minorWords) {

    var wordsArray = minorWords.split(" ");
    var titleArray = title.split(" ");
    var result = "";

    for (var i = 0; i < titleArray.length; i++) {
        if (i == 0) {
            
        }
        if (wordsArray.indexOf(titleArray[i]) != -1) {

            titleArray[i] = titleArray[i].toLowerCase();
        }
    }

    

}
    