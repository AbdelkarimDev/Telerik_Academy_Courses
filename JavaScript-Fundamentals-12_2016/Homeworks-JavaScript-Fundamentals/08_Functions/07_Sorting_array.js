function solve(args) {
    let numberArray = args[1].split(' ').map(Number);

    console.log(numberArray.sort((x, y) => x - y).join(" "));

}

solve(['6', '36 10 1 34 28 38 31 27 30 20']);