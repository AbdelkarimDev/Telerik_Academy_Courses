function solve(args) {
    str = args[0];
    const regex = /[<>]/g;

    let strArray = str.split(regex);
    let newarray = "";

    // console.log(strArray);

    for (var j = 1; j < strArray.length; j += 2) {

        if (strArray[j].search(/(^lowcase)/) === 0) {
            strArray[j + 1] = strArray[j + 1].toLowerCase()

        } else if (strArray[j].search(/(^upcase)/) === 0) {
            strArray[j + 1] = strArray[j + 1].toUpperCase()
        }
    }

    for (var index = 0; index < strArray.length; index += 2) {
        newarray += strArray[index]
    }
    console.log(newarray);
}
solve(['We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.']);