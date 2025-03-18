function rollDieUntilLimit() {
    let count = { 1: 0, 2: 0, 3: 0, 4: 0, 5: 0, 6: 0 };
    let maxRoll = 10;

    while (true) {
        let roll = Math.floor(Math.random() * 6) + 1; // Random number from 1-6
        count[roll]++;

        // Stop when any number reaches 10 times
        if (count[roll] === maxRoll) break;
    }

    console.log("Final counts:", count);

    // Find max and min occurring numbers
    let maxNum = null, minNum = null;
    let maxCount = -Infinity, minCount = Infinity;
    
    for (let [num, freq] of Object.entries(count)) {
        if (freq > maxCount) {
            maxCount = freq;
            maxNum = num;
        }
        if (freq < minCount) {
            minCount = freq;
            minNum = num;
        }
    }

    console.log(`Number that appeared most: ${maxNum} (${count[maxNum]} times)`);
    console.log(`Number that appeared least: ${minNum} (${count[minNum]} times)`);
}

rollDieUntilLimit();
