function countValues(input) {
    var count = {};
    for (var i = 0; i < input.length; i++) {
        if (isNaN(count[input[i]])) {
            count[input[i]] = 0;
        }
        count[input[i]] += 1;
    }
    return count;
}