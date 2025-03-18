function primeFactors(n) {
    let factors = [];

    // Divide by 2 until n is odd
    while (n % 2 === 0) {
        factors.push(2);
        n /= 2;
    }

    // Check odd numbers from 3 onwards
    for (let i = 3; i <= n; i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n /= i;
        }
    }

    console.log("Prime Factors:", factors);
}

let num = 56; // Change this number to test
primeFactors(num);
