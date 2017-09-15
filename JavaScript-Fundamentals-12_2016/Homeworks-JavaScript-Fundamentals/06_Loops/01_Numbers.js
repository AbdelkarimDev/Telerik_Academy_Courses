function solve(args) {

    var a = +args[0],
        result = "";

    for (var index = 1; index <= a; index++) {

        result += index + " ";
    }
    console.log(result);
}

solve(['5'])