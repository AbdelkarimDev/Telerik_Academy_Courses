var person = {
    name: 'Pesho',
    age: 20,
    height: 170,
    address: 'mladost'
};

console.log(person.hasOwnProperty('name'));
console.log('email' in person);
console.log(hasProperty(person, 'age'));

function hasProperty(obj, toSearch) {
    for (var prop in obj) {
        if (prop === toSearch) {
            return true;
        }
    }
    return false;
}