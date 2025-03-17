const prompt = require('prompt-sync')();

// Problem 1: Find min and max from 5 random 3-digit numbers
let numbers = Array.from({ length: 5 }, () => Math.floor(Math.random() * 900) + 100);
let min = numbers[0], max = numbers[0];
for (let i = 1; i < numbers.length; i++) {
    if (numbers[i] < min) min = numbers[i];
    if (numbers[i] > max) max = numbers[i];
}
console.log("Numbers:", numbers);
console.log("Min:", min, "Max:", max);

// Problem 2: Check if day and month are in range
let day = parseInt(prompt("Enter day: "));
let month = parseInt(prompt("Enter month: "));
if ((month === 3 && day >= 20) || (month > 3 && month < 6) || (month === 6 && day <= 20)) {
    console.log(true);
} else {
    console.log(false);
}

// Problem 3: Leap year check
let year = parseInt(prompt("Enter year: "));
if (year % 4 === 0) {
    if (year % 100 === 0) {
        if (year % 400 === 0) {
            console.log("Leap Year");
        } else {
            console.log("Not a Leap Year");
        }
    } else {
        console.log("Leap Year");
    }
} else {
    console.log("Not a Leap Year");
}

// Problem 4: Coin flip simulation
let coinFlip = Math.random();
if (coinFlip < 0.5) {
    console.log("Heads");
} else {
    console.log("Tails");
}

// Problem 5: Single digit to word
let num = parseInt(prompt("Enter a single digit number: "));
if (num === 0) console.log("Zero");
else if (num === 1) console.log("One");
else if (num === 2) console.log("Two");
else if (num === 3) console.log("Three");
else if (num === 4) console.log("Four");
else if (num === 5) console.log("Five");
else if (num === 6) console.log("Six");
else if (num === 7) console.log("Seven");
else if (num === 8) console.log("Eight");
else if (num === 9) console.log("Nine");
else console.log("Invalid Input");

// Problem 6: Number to weekday
let weekNum = parseInt(prompt("Enter a number (1-7) for weekday: "));
if (weekNum === 1) console.log("Sunday");
else if (weekNum === 2) console.log("Monday");
else if (weekNum === 3) console.log("Tuesday");
else if (weekNum === 4) console.log("Wednesday");
else if (weekNum === 5) console.log("Thursday");
else if (weekNum === 6) console.log("Friday");
else if (weekNum === 7) console.log("Saturday");
else console.log("Invalid Input");

// Problem 7: Place value representation
let placeValue = parseInt(prompt("Enter place value (1, 10, 100, 1000): "));
if (placeValue === 1) console.log("Unit");
else if (placeValue === 10) console.log("Ten");
else if (placeValue === 100) console.log("Hundred");
else if (placeValue === 1000) console.log("Thousand");
else console.log("Invalid Input");

// Problem 8: Arithmetic operations
let a = parseInt(prompt("Enter value for a: "));
let b = parseInt(prompt("Enter value for b: "));
let c = parseInt(prompt("Enter value for c: "));
let res1 = a + b * c;
let res2 = a % b + c;
let res3 = c + a / b;
let res4 = a * b + c;
let maxRes = res1, minRes = res1;
if (res2 > maxRes) maxRes = res2;
if (res3 > maxRes) maxRes = res3;
if (res4 > maxRes) maxRes = res4;
if (res2 < minRes) minRes = res2;
if (res3 < minRes) minRes = res3;
if (res4 < minRes) minRes = res4;
console.log("Results:", [res1, res2, res3, res4]);
console.log("Max:", maxRes, "Min:", minRes);