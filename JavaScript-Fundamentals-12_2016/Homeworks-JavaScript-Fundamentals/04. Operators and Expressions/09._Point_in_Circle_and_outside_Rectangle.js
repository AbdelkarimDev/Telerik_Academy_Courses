'use strict'


function solve(args) {

    var coordinateX = +args[0];
    var coordinateY = +args[1];
    var circleradius = 1.5;
    var circleX = 1;
    var circleY = 1;
    var rectangleTop = 1;
    var rectangleLeft = -1;
    var rectangleWidth = 6;
    var rectangelHeight = 2;
    var rectangleDown = rectangleTop - rectangelHeight;
    var rectangleRight = rectangleLeft + rectangleWidth;
    var ispointincircle = circleradius * circleradius >= ((coordinateX - circleX) * (coordinateX - circleX) + (coordinateY - circleY) * (coordinateY - circleX));
    var ispoinrectangle = (rectangleLeft <= coordinateX && coordinateX <= rectangleRight) && (rectangleDown <= coordinateY && coordinateY <= rectangleTop);

    if (ispointincircle) {
        if (ispoinrectangle) {
            console.log("inside circle inside rectangle");
        } else {
            console.log("inside circle outside rectangle");
        }
    } else {
        if (ispoinrectangle) {
            console.log("outside circle inside rectangle");

        } else {
            console.log("outside circle outside rectangle");
        }
    }

}

solve(['2.5', '1']);