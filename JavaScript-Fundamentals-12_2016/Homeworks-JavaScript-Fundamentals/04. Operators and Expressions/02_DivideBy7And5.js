'use strict'


function solve(args) {

    var inputNumber = +args[0];

    console.log(inputNumber % 5 === 0 && inputNumber % 7 === 0 ? 'true ' + inputNumber : 'false ' + inputNumber);
}

solve(['35']);