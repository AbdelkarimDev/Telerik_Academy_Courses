function solve(args) {
    let lines = args.length,
        linesArray = [];
    let a = 0;
    for (let i = 0; i < lines - 3; i += 4) {
        linesArray.push({
            firstX: +args[i],
            firstY: +args[i + 1],
            secondX: +args[i + 2],
            secondY: +args[i + 3],
        });

    }
    let sumLength = [];
    for (let i = 0; i < linesArray.length; i += 1) {
        let a = linesArray[i].firstX - linesArray[i].secondX;
        let b = linesArray[i].firstY - linesArray[i].secondY;
        sumLength[i] = Math.sqrt(a * a + b * b);

    }
    console.log(sumLength[0].toFixed(2));
    console.log(sumLength[1].toFixed(2));
    console.log(sumLength[2].toFixed(2));

    if (isTriangle()) {
        console.log('Triangle can be built')
    } else {
        console.log('Triangle can not be built');
    }

    function isTriangle() {
        return (sumLength[0] + sumLength[1] > sumLength[2] && sumLength[1] + sumLength[2] > sumLength[0] && sumLength[0] + sumLength[2] > sumLength[1]);
    }

}
solve([
    '7', '7', '2', '2',
    '5', '6', '2', '2',
    '95', '-14.5', '0', '-0.123'
]);