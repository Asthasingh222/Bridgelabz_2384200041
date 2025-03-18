function findSecondLargestSmallest(){
    let arr =[];

    // Generate 10 random 3-digit numbers
    for(let i=0;i<10;i++){
        arr.push(Math.floor(Math.random()*900)+ 100);
    }
    console.log("Generated Array:",arr);

    // Sort the array in ascending order
    arr.sort((a, b) => a - b);
    console.log("Sorted Array:", arr);

    console.log("2nd Smallest:", arr[1]);
    console.log("2nd Largest:", arr[arr.length - 2]);
    
}

findSecondLargestSmallest();
