'use strict'


function solve(args) {

    var min = Math.min(),
        max = Math.max(),
        sum = 0,
        avg = 0;


    for (var index = 0; index < args.length; index++) {
        if (min > +args[index]) {
            min = +args[index];
        }
        if (max < +args[index]) {
            max = +args[index];
        }
        sum += +args[index];

    }
    avg = sum / args.length;

    console.log('min=' + min.toFixed(2))
    console.log('max=' + max.toFixed(2))
    console.log('sum=' + sum.toFixed(2))
    console.log('avg=' + avg.toFixed(2))
}

solve(['2', '5', '1'])