const prompt = require('prompt-sync')();

// Problem 1: Table of powers of 2
let n = parseInt(prompt("Enter value of n: "));
for (let i = 0; i <= n; i++) {
    console.log(`2^${i} = ${Math.pow(2, i)}`);
}

// Problem 2: Nth Harmonic Number
let harmonic = 0;
n = parseInt(prompt("Enter value of n: "));
for (let i = 1; i <= n; i++) {
    harmonic += 1 / i;
}
console.log(`${n}th Harmonic Number: ${harmonic}`);

// Problem 3: Prime number check
let num = parseInt(prompt("Enter a number: "));
let isPrime = num > 1;
for (let i = 2; i * i <= num; i++) {
    if (num % i === 0) {
        isPrime = false;
        break;
    }
}
console.log(isPrime ? "Prime Number" : "Not a Prime Number");

// Problem 4: Prime numbers in a range
let start = parseInt(prompt("Enter start of range: "));
let end = parseInt(prompt("Enter end of range: "));
console.log("Prime numbers in range:");
for (let num = start; num <= end; num++) {
    let isPrime = num > 1;
    for (let i = 2; i * i <= num; i++) {
        if (num % i === 0) {
            isPrime = false;
            break;
        }
    }
    if (isPrime) console.log(num);
}

// Problem 5: Factorial calculation
num = parseInt(prompt("Enter a number: "));
let factorial = 1;
for (let i = 1; i <= num; i++) {
    factorial *= i;
}
console.log(`${num}! = ${factorial}`);

// Problem 6: Prime factorization
let N = parseInt(prompt("Enter a number: "));
console.log("Prime factors:");
for (let i = 2; i * i <= N; i++) {
    while (N % i === 0) {
        console.log(i);
        N /= i;
    }
}
if (N > 1) console.log(N);