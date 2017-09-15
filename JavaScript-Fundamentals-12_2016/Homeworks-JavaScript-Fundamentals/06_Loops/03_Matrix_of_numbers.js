function solve(args) {

    var a = +args[0],
        result = "";


    for (var j = 0; j < a; j++) {

        for (var index = 1; index <= a; index++) {

            result += index + j + " ";
        }
        console.log(result);
        result = ""

    }

}

solve(['3'])