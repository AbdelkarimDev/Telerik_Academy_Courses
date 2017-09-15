function solve(args) {
    'use strict';
    let umber = +args[0],
        isPrime;

    for (let i = umber; i >= 2; i -= 1) {
        isPrime = true;
        for (let j = 2; j < Math.sqrt(umber); j += 1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            console.log(i);
            break;
        }
    }
}
solve(['126'])