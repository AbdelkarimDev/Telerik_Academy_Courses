'use strict'


function solve(args) {

    var inputNumber = +args[0];
    var number = Math.floor(inputNumber / 100);




    console.log(number % 10 === 7 ? 'true' : 'false ' + number % 10);
}

solve(['3705']);
solve(['37343']);