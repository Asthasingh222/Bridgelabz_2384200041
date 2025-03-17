const prompt = require('prompt-sync')();

// Problem 1: Temperature Conversion using Case
function convertTemperature() {
    console.log("1: Celsius to Fahrenheit\n2: Fahrenheit to Celsius");
    let choice = parseInt(prompt("Enter choice (1/2): "));
    switch (choice) {
        case 1:
            let degC = parseFloat(prompt("Enter temperature in Celsius: "));
            if (degC >= 0 && degC <= 100) {
                console.log(`Temperature in Fahrenheit: ${(degC * 9/5) + 32}`);
            } else {
                console.log("Invalid input. Temperature out of range.");
            }
            break;
        case 2:
            let degF = parseFloat(prompt("Enter temperature in Fahrenheit: "));
            if (degF >= 32 && degF <= 212) {
                console.log(`Temperature in Celsius: ${(degF - 32) * 5/9}`);
            } else {
                console.log("Invalid input. Temperature out of range.");
            }
            break;
        default:
            console.log("Invalid choice.");
    }
}

// Problem 2: Check if two numbers are Palindromes
function isPalindrome(num) {
    let original = num.toString();
    let reversed = original.split('').reverse().join('');
    return original === reversed;
}

// Problem 3: Prime and Palindrome Prime Check
function isPrime(num) {
    if (num < 2) return false;
    for (let i = 2; i * i <= num; i++) {
        if (num % i === 0) return false;
    }
    return true;
}

function checkPrimeAndPalindrome() {
    let num = parseInt(prompt("Enter a number: "));
    if (isPrime(num)) {
        console.log(`${num} is a prime number.`);
        let palindromeNum = parseInt(num.toString().split('').reverse().join(''));
        if (isPrime(palindromeNum)) {
            console.log(`The palindrome ${palindromeNum} is also a prime number.`);
        } else {
            console.log(`The palindrome ${palindromeNum} is not a prime number.`);
        }
    } else {
        console.log(`${num} is not a prime number.`);
    }
}

// Function Calls
testCases = [121, 131, 123]
testCases.forEach(num => console.log(`Is ${num} a palindrome? ${isPalindrome(num)}`));
convertTemperature();
checkPrimeAndPalindrome();
