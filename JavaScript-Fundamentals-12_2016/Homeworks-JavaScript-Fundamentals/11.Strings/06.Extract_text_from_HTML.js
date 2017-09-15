function solveRegex(args) {
    let output = '',
        match = /<.*?>/ig;

    for (let line of args) {
        output += line.replace(match, '').trim();
    }

    console.log(output);

    // for (var j = 1; j < strArray.length; j += 2) {

    //     if (strArray[j].search(/(^lowcase)/) === 0) {
    //         strArray[j + 1] = strArray[j + 1].toLowerCase()

    //     } else if (strArray[j].search(/(^upcase)/) === 0) {
    //         strArray[j + 1] = strArray[j + 1].toUpperCase()
    //     }
    // }

    // for (var index = 0; index < strArray.length; index += 2) {
    //     newarray += strArray[index]
    // }
    // console.log(newarray);
}

solve([
    '<html>',
    '  <head>',
    '    <title>Sample site</title>',
    '  </head>',
    '  <body>',
    '    <div>text',
    '      <div>more text</div>',
    '      and more...',
    '    </div>',
    '    in body',
    '  </body>',
    '</html>'
]);