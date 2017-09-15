function solve(args) {
    let numberArray = args[1].split(' ').map(Number);

    function GetLarger(Array) {
        let len = Array.length;
        let count = 0;
        for (let i = 1; i < len - 1; i += 1) {
            if (Array[i] > Array[i - 1] && Array[i] > Array[i + 1]) {
                count += 1;
            }
        }
        return count;
    }
    return GetLarger(numberArray);
}


console.log(solve(['6', '-26 -25 -28 31 2 27']));