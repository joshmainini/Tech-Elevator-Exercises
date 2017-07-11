function iqTest(array) {
    var evenCount = 0;
    var oddCount = 0;
    for (var i = 0; i < array.length; i++) {
        if (array[i] % 2 == 0) {
            evenCount++;
        }
        else if (array[i] % 2 != 0) {
            oddCount++;
        }
    }
    if (oddCount > evenCount) {
        for (var i = 0; i < array.length; i++) {
            if (array[i] % 2 == 0) {
                return i + 1;
            }
        }
    }
    else if(evenCount > oddCount) {
        for (var i = 0; i < array.length; i++) {
            if (array[i] % 2 != 0) {
                return i + 1;
            }
        }
    }
    else {
        return 0;
    }
}