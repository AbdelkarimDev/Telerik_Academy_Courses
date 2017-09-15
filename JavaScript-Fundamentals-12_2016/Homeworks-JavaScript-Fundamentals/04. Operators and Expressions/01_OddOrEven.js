'use strict'


function solve(args) {

    var inputNumber = +args[0];

    console.log(inputNumber % 2 === 0 ? 'even ' + inputNumber : 'odd ' + inputNumber);
}

solve(['5']);