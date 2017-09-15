function solve(args) {

    len = args.length,
        lines = [];

    for (var i = 0; i < len - 3; i += 4) {
        lines.push(calculateDistance(+args[i], +args[i + 1], +args[i + 2], +args[i + 3]));
    }

    console.log(lines[0].toFixed(2));
    console.log(lines[1].toFixed(2));
    console.log(lines[2].toFixed(2));

    if (isTriangle()) {
        console.log('Triangle can be built')
    } else {
        console.log('Triangle can not be built');
    }

    function isTriangle() {
        return (lines[0] + lines[1] > lines[2] && lines[1] + lines[2] > lines[0] && lines[0] + lines[2] > lines[1]);
    }

    function calculateDistance(x1, y1, x2, y2) {
        return Math.sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    }

}
// solve([
//     '5', '6', '7', '8',
//     '1', '2', '3', '4',
//     '9', '10', '11', '12'
// ]);
solve([
    '7', '7', '2', '2',
    '5', '6', '2', '2',
    '95', '-14.5', '0', '-0.123'
]);