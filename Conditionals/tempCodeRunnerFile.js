const prompt = require('prompt-sync')(); // Install with `npm install prompt-sync`

// 1. Find Minimum and Maximum of 5 Random 3-Digit Numbers
let numbers = [];
for (let i = 0; i < 5; i++) {
    numbers.push(Math.floor(Math.random() * 900) + 100); // Random 3-digit (100-999)
}
console.log("Numbers:", numbers);
console.log("Minimum:", Math.min(...numbers));
console.log("Maximum:", Math.max(...numbers));

// 2. Check if the Date is Between March 20 and June 20
let day = parseInt(prompt("Enter day: "));
let month = parseInt(prompt("Enter month: "));
let isBetween = (month === 3 && day >= 20) || (month === 6 && day <= 20) || (month > 3 && month < 6);
console.log("Is date in range (March 20 - June 20)?", isBetween);

// 3. Check Leap Year
let year = parseInt(prompt("Enter a 4-digit year: "));
let isLeap = (year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0);
console.log(year, "is a Leap Year?", isLeap);

// 4. Simulate Coin Flip
let coin = Math.random() < 0.5 ? "Heads" : "Tails";
console.log("Coin Flip Result:", coin);

// 5. Read a Single Digit and Print in Words
let digit = parseInt(prompt("Enter a single digit (0-9): "));
let words = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"];
console.log("Number in Words:", words[digit] || "Invalid Input");

// 6. Read a Number and Display Weekday
let dayNumber = parseInt(prompt("Enter a number (1-7) for weekday: "));
let weekdays = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
console.log("Weekday:", weekdays[dayNumber - 1] || "Invalid Input");

// 7. Read 1, 10, 100, 1000, etc. and Display Place Value
let placeValue = parseInt(prompt("Enter a number (1, 10, 100, 1000, etc.): "));
let units = {1: "Unit", 10: "Ten", 100: "Hundred", 1000: "Thousand", 10000: "Ten Thousand"};
console.log("Place Value:", units[placeValue] || "Invalid Input");

// 8. Arithmetic Operations on 3 Numbers
let a = parseInt(prompt("Enter value for a: "));
let b = parseInt(prompt("Enter value for b: "));
let c = parseInt(prompt("Enter value for c: "));

let results = [
    a + b * c,
    a % b + c,
    c + a / b,
    a * b + c
];
console.log("Arithmetic Results:", results);
console.log("Maximum Value:", Math.max(...results));
console.log("Minimum Value:", Math.min(...results));
