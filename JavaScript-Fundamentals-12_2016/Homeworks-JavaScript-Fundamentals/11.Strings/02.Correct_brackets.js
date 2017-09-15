function solve(args) {
    const regex1 = /\)/g;
    const regex2 = /\(/g;
    const str = args[0];
    
    let str1 = str.split(regex1);
    let str2 = str.split(regex2);
    console.log(str1.length === str2.length ? 'Correct' : 'Incorrect');
   
}
solve(['((a+b)/5-d)']);
solve([')(a+b))']);