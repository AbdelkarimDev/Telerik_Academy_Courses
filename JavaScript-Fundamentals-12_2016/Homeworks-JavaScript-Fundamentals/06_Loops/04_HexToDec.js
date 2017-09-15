function solve(args) {

    var number = args[0];
    var result = +0;

    for (var digit in number) {
        var digitValue = "";
        if (!isNaN(number[digit])) {
            digitValue = +number[digit];
        } else {
            digitValue = number.charCodeAt(digit) - "A".charCodeAt(0) + 10;
        }

        result = 16 * result + digitValue;
    }

    console.log(result);
}


solve(['1AE3'])