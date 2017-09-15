'use strict'


function solve(args) {

    var a = +args[0];
    var b = +args[1];


    if (a > b) {
        var c = a;
        a = b;
        b = c;

    } else {

    }


    console.log(a + ' ' + b);
}

solve(['3', '4']);