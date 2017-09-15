function solve(args) {

    let a = +args[0],
        result = "";

    for (let index = 0; index < a; index++) {

        result = index * 5;
        console.log(result);
    }

}

solve(['5'])