function solve(args) {
    let numbersArray = args[1].split(' ').map(Number),
        number = +args[2],
        count = 0;


    for (let i = 0; i < numbersArray.length; i += 1) {
        if (numbersArray[i] === number) {
            count += 1;
        }
    }

    return count;

}


console.log(solve(['8', '28 6 21 6 -7856 73 73 -56', '73']));