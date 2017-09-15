'use strict'


function solve(args) {

    var coordinateX = +args[0];
    var coordinateY = +args[1];
    var circleradius = 2;
    var circleX = 0;
    var circleY = 0;

    var point = Math.sqrt((coordinateX - circleX) * (coordinateX - circleX) + (coordinateY - circleY) * (coordinateY - circleX));

    if (coordinateX * coordinateX + coordinateY * coordinateY <= circleradius * circleradius)

    {
        console.log('yes' + ' ' + point.toFixed(2));

    } else {
        console.log('no' + ' ' + point.toFixed(2));
    }

}

solve(['1.5', '-1']);