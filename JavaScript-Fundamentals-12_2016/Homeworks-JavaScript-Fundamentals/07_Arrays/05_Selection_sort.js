'use strict'

function solve(args) {


    for (let i = 0; i < args.length; i += 1) {

        for (let k = 0; k < args.length; k += 1) {

            if (+args[k] > +args[i]) {
                let swap = args[i];
                args[i] = args[k];
                args[k] = swap;
            }
        }
    }

    for (let i = 0; i < args.length; i += 1) {

        for (let k = i + 1; k < args.length; k += 1) {

            if (+args[i] === +args[k]) {
                args.splice(k, 1)
                k -= 1;
            }
        }
    }
    for (let i = 0; i < args.length; i += 1) {
        console.log(args[i]);
    }
}

solve(['10', '20', '10', '20', '343', '-12', '10', '10', '27', '30', '10'])