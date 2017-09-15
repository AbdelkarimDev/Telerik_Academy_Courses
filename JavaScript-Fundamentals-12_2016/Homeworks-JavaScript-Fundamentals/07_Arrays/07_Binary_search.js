function solve(args) {
    let l,
        start = 0,
        lastindex,
        index,
        element = +args.pop();
    args.splice(0, 1);
    lastindex = args.length - 1;
    while (true) {
        index = (((lastindex - start) / 2) | 0) + start;
        if ((+args[lastindex] > element) && (+args[lastindex - 1] < element)) {
            index = -1;
            break;
        } else if (element > +args[index]) {
            start = index;
        } else if (element < +args[index]) {
            lastindex = index;
        } else {
            break;
        }
    }
    console.log(index);
}
solve(['10', '1', '2', '4', '8', '16', '31', '32', '64', '77', '99', '32'])