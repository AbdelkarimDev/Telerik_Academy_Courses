'use strict'


function solve(args) {

    var a = +args[0],
        b = +args[1],
        c = +args[2];

    var d = b * b - 4 * a * c;
    if (d > 0) {

        var xFirst = ((-b) - Math.sqrt(d)) / (2 * a);
        var xSecond = ((-b) + Math.sqrt(d)) / (2 * a);
        console.log("x1=" + xFirst.toFixed(2) + "; x2=" + xSecond.toFixed(2));
    } else if (d == 0) {
        var xFirst = ((-b) - Math.sqrt(d)) / (2 * a);
        console.log("x1=x2=" + xFirst.toFixed(2));
    } else {
        console.log("no real roots");
    }

}

solve(['-0.5', '4', '-8'])