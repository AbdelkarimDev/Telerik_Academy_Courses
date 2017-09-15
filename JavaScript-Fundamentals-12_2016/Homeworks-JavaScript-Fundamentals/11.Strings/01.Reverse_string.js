function solve(args) {
    let string = args[0];
    console.log(reverse(string));

    function reverse(s) {
        return s.split("").reverse().join("");
    }

}


solve(['sample wen']);
solve(['qwertytrewq']);