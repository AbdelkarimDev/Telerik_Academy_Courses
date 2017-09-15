function solve(args) {
    searched = args[0],
        str = args[1];

    let reg = new RegExp(searched, 'gi');
    let strArray = str.match(reg);
    console.log(strArray.length);
}
solve([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);