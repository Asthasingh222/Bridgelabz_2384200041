const prompt = require('prompt-sync')();

// Problem 1: Single digit to word using switch-case
let num = parseInt(prompt("Enter a single digit number: "));
switch (num) {
    case 0: console.log("Zero"); break;
    case 1: console.log("One"); break;
    case 2: console.log("Two"); break;
    case 3: console.log("Three"); break;
    case 4: console.log("Four"); break;
    case 5: console.log("Five"); break;
    case 6: console.log("Six"); break;
    case 7: console.log("Seven"); break;
    case 8: console.log("Eight"); break;
    case 9: console.log("Nine"); break;
    default: console.log("Invalid Input");
}

// Problem 2: Number to weekday using switch-case
let weekNum = parseInt(prompt("Enter a number (1-7) for weekday: "));
switch (weekNum) {
    case 1: console.log("Sunday"); break;
    case 2: console.log("Monday"); break;
    case 3: console.log("Tuesday"); break;
    case 4: console.log("Wednesday"); break;
    case 5: console.log("Thursday"); break;
    case 6: console.log("Friday"); break;
    case 7: console.log("Saturday"); break;
    default: console.log("Invalid Input");
}

// Problem 3: Place value representation using switch-case
let placeValue = parseInt(prompt("Enter place value (1, 10, 100, 1000): "));
switch (placeValue) {
    case 1: console.log("Unit"); break;
    case 10: console.log("Ten"); break;
    case 100: console.log("Hundred"); break;
    case 1000: console.log("Thousand"); break;
    default: console.log("Invalid Input");
}

// Problem 4: Unit conversion using switch-case
console.log("Choose conversion:");
console.log("1. Feet to Inch\n2. Feet to Meter\n3. Inch to Feet\n4. Meter to Feet");
let choice = parseInt(prompt("Enter choice (1-4): "));
let value = parseFloat(prompt("Enter value to convert: "));
let result;
switch (choice) {
    case 1: result = value * 12; console.log(`${value} Feet = ${result} Inches`); break;
    case 2: result = value * 0.3048; console.log(`${value} Feet = ${result} Meters`); break;
    case 3: result = value / 12; console.log(`${value} Inches = ${result} Feet`); break;
    case 4: result = value / 0.3048; console.log(`${value} Meters = ${result} Feet`); break;
    default: console.log("Invalid Choice");
}