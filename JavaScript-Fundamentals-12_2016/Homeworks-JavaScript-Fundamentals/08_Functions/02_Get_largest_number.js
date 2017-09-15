function solve(args) {
    let numbersArray = args[0].split(' ').map(Number);
    let a = numbersArray[0],
        b = numbersArray[1],
        c = numbersArray[2],
        maxOfThree = 0;

    function GetMax(x, y) {
        let max;
        x = +x;
        y = +y;
        max = x;

        if (y > max) {
            max = y;
        }
        return max;
    }

    if (GetMax(a, b) > c) {
        return GetMax(a, b);
    } else {
        return c;
    }

}

console.log(solve(['7 19 19']));