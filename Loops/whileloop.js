const prompt = require('prompt-sync')();

// Problem 1: Table of powers of 2 till 256 is reached
let n = parseInt(prompt("Enter value of n: "));
let i = 0;
while (i <= n && Math.pow(2, i) <= 256) {
    console.log(`2^${i} = ${Math.pow(2, i)}`);
    i++;
}

// Problem 2: Magic Number
console.log("Think of a number between 1 and 100");
let low = 1, high = 100;
while (low < high) {
    let mid = Math.floor((low + high) / 2);
    let response = prompt(`Is your number greater than ${mid}? (yes/no): `).toLowerCase();
    if (response === "yes") {
        low = mid + 1;
    } else {
        high = mid;
    }
}
console.log(`Your magic number is: ${low}`);

// Problem 3: Flip Coin till 11 wins
let heads = 0, tails = 0;
while (heads < 11 && tails < 11) {
    let flip = Math.random() < 0.5 ? "Heads" : "Tails";
    if (flip === "Heads") heads++;
    else tails++;
    console.log(`Flip: ${flip} | Heads: ${heads}, Tails: ${tails}`);
}
console.log(heads === 11 ? "Heads wins!" : "Tails wins!");

// Problem 4: Gambling Simulation
let money = 100, bets = 0, wins = 0;
while (money > 0 && money < 200) {
    bets++;
    if (Math.random() < 0.5) {
        money++;
        wins++;
    } else {
        money--;
    }
}
console.log(`Game Over! Final Amount: Rs ${money}, Total Bets: ${bets}, Wins: ${wins}`);
