function solve(args) {
    let i, j, youngest, person = {},
        arrayPeople = [];

    for (i = 0, len = args.length; i < len; i += 3) {
        person = createPerson(args[i], args[i + 1], +args[i + 2]);
        arrayPeople.push(person);
    }
    let sortedArray = arrayPeople.sort((x, y) => x.age > y.age);

    youngest = sortedArray[0];

    console.log(youngest.firstname + ' ' + youngest.lastname);

    function createPerson(first, last, age) {
        return {
            firstname: first,
            lastname: last,
            age: age
        };
    }
}

solve(['Gosho', 'Petrov', '32', 'Bay', 'Ivan', '81', 'John', 'Doe', '42']);
solve(['Penka', 'Hristova', '61', 'System', 'Failiure', '88', 'Bat', 'Man', '16', 'Malko', 'Kote', '72']);