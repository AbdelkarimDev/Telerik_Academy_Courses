function solveFinal(args) {
    let regExTag = new RegExp('<a href="(.*?)">(.*?)</a>', "g");

    let newText = args[0].replace(regExTag, function (none, href, content) {

        return '[' + content + '](' + href + ')';
    });

    console.log(newText);
}