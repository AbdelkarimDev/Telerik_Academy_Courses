/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function solve() {
    return function findPrimes(fromNumber, toNumber) {
        fromNumber = +fromNumber;
        toNumber = +toNumber;

        if (isNaN(fromNumber) || isNaN(toNumber)) {
            throw 'ERROR: Input must be a Number';
        }

        let primes = [];

        for (let k = fromNumber; k <= toNumber; k += 1) {
            if (isPrime(k)) {
                primes.push(k);
            }
        }
        return primes;

        function isPrime(number) {
            let maxDiv = Math.round(Math.sqrt(toNumber));

            if (number < 2) {
                return false;
            }
            if (number === 2) {
                return true;
            }

            for (let i = 2; i <= maxDiv; i += 1) {
                if (number % i === 0) {
                    return false;
                }
            }
            return true;
        }
    }
}

console.log(solve()(6, 65));

module.exports = solve;