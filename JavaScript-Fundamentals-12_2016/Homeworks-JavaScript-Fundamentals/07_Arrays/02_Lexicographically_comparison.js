'use strict'

function solve(args) {

    let str1 = args[0],
        str2 = args[1],
        char, longer;


    if (str1 < str2) {
        longer = str2;
    } else {
        longer = str1;
    }

    for (char = 0; char < longer.length; char += 1) {
        if (str1[char] < str2[char]) {
            return "<";
        } else if (str1[char] > str2[char]) {
            return ">";
        }
    }
    return "=";
}


solve(['aaab', 'aaaa'])