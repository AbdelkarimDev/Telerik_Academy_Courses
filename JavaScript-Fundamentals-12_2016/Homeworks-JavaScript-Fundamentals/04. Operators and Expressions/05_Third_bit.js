'use strict'


function solve(args) {

    var inputNumber = +args[0];
    var mask = 1 << 3;


    console.log((inputNumber & mask) >> 3);
}

solve(['1024']);