function solve(args) {
    var numberArray = args[1].split(' ').map(Number);


    function GetLarger(Array) {
        var len = Array.length,
            count = 0,
            i;
        for (i = 1; i < len - 1; i += 1) {
            if (Array[i] > Array[i - 1] && Array[i] > Array[i + 1]) {
                return i;
            }
        }
        return -1;
    }
    return GetLarger(numberArray);
}


console.log(solve(['6', '-26 -25 -28 31 2 27']));