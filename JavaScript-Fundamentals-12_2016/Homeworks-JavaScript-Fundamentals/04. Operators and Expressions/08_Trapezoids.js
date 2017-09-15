'use strict'


function solve(args) {

    var sideA = +args[0];
    var sideB = +args[1];
    var height = +args[2];

    var area = (sideA + sideB) * height / 2;

    console.log(area.toFixed(7));
}

solve(['2', '1', '33']);