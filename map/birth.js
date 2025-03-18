function generateBirthMonths() {
    let birthMonths = {};

    // Initialize months 1-12
    for (let i = 1; i <= 12; i++) {
        birthMonths[i] = [];
    }

    // Generate birth months for 50 individuals
    for (let i = 1; i <= 50; i++) {
        let month = Math.floor(Math.random() * 12) + 1; // Random month (1-12)
        birthMonths[month].push(i); // Store person ID in that month
    }

    console.log("Individuals grouped by birth month:");
    console.log(birthMonths);
}

generateBirthMonths();
