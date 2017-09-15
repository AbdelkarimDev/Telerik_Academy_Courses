function solve(args) {
    str = args[0];

    String.prototype.Escape = function() {
        let escapedStr = String(this)
            .replace(/\s/g, '&nbsp;');

        return escapedStr;
    }

    console.log(str.Escape())
}

solve(['This text contains 4 spaces!!']);