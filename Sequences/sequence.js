// 1. Get a Single Digit Random Number (0-9)
let singleDigit = Math.floor(Math.random() * 10);
console.log("Single Digit:", singleDigit);

// 2. Get a Dice Number (1-6)
let diceNumber = Math.floor(Math.random() * 6) + 1;
console.log("Dice Number:", diceNumber);

// 3. Add Two Random Dice Numbers
let dice1 = Math.floor(Math.random() * 6) + 1;
let dice2 = Math.floor(Math.random() * 6) + 1;
let sum = dice1 + dice2;
console.log(`Dice 1: ${dice1}, Dice 2: ${dice2}, Sum: ${sum}`);

// 4. Generate 5 Random 2-Digit Numbers, Find Sum and Average
let numbers = [];
let totalSum = 0;
for (let i = 0; i < 5; i++) {
    let num = Math.floor(Math.random() * 90) + 10; // Random 2-digit number (10-99)
    numbers.push(num);
    totalSum += num;
}
let average = totalSum / 5;
console.log("Numbers:", numbers);
console.log("Sum:", totalSum);
console.log("Average:", average.toFixed(2));

// 5. Unit Conversion
// (a) Convert 42 inches to feet (1 ft = 12 in)
let inches = 42;
let feet = inches / 12;
console.log(`${inches} inches = ${feet.toFixed(2)} feet`);

// (b) Convert Rectangular Plot (60ft x 40ft) to Meters (1 ft = 0.3048 m)
let lengthFeet = 60, widthFeet = 40;
let lengthMeters = lengthFeet * 0.3048;
let widthMeters = widthFeet * 0.3048;
console.log(`Rectangular Plot: ${lengthMeters.toFixed(2)}m x ${widthMeters.toFixed(2)}m`);

// (c) Calculate the Area of 25 Such Plots in Acres (1 acre = 4046.86 m²)
let areaMeters = lengthMeters * widthMeters;
let totalAreaMeters = areaMeters * 25;
let areaAcres = totalAreaMeters / 4046.86;
console.log(`Total area of 25 plots in acres: ${areaAcres.toFixed(4)}`);
