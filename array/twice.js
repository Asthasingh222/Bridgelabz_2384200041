function findRepeatedDigits() {
    let repeatedNumbers = [];

    for (let i = 10; i <= 100; i++) {
        let str = i.toString();
        if (str[0] === str[1]) {
            repeatedNumbers.push(i);
        }
    }

    console.log("Repeated Digit Numbers:", repeatedNumbers);
}

findRepeatedDigits();
