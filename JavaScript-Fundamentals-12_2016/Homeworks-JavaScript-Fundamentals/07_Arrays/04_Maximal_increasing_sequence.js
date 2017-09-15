'use strict'

function solve(args) {

    let counter = 0,
        maxcounter = 0;

    for (let i = 0; i < args.length - 1; i++) {


        if (+args[i] < (+args[i + 1])) {
            counter += 1;
        } else {
            counter = 1;
        }
        if (counter > maxcounter) {
            maxcounter = counter;
        }

    }
    console.log(maxcounter);
}
solve(['8', '7', '3', '2', '3', '4', '2', '2', '4'])