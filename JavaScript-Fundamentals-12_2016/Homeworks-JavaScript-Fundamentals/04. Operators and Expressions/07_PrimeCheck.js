function solve(args) {

    var inputNumber = +args[0];
    var isPrime = true;

    for (var i = 2; i <= Math.sqrt(inputNumber); i += 1) {
        if (inputNumber % i === 0) {
            isPrime = false;
            break;
        }
    }
    if (inputNumber === 1 || inputNumber < 1) {
        isPrime = false;
    }
    console.log(isPrime);

}

solve(['28']);