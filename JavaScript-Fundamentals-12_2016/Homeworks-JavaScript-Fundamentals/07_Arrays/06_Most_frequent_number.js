'use strict'

function solve(args) {

    let counter = 0,
        index = 0,
        maxcounter = 0;

    for (let i = 0; i < args.length - 1; i++) {
        counter = 1;
        for (var k = i + 1; k < args.length; k++) {

            if (+args[i] === +args[k]) {
                counter += 1;

                if (counter > maxcounter) {
                    maxcounter = counter;
                    index = args[i];

                }
            }
        }
    }
    console.log(`${index} (${maxcounter} times)`);
}
solve(['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3'])