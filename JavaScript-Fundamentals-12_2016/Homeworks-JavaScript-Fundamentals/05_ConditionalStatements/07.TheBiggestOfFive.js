
function solve(args) {

    var maxNumber = +args[0];

    for (var i = 1; i < 5; i += 1) {
        if (maxNumber < +args[i]) {
            maxNumber = +args[i];
        }
    }

    return maxNumber;
}