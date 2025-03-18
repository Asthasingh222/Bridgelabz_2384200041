function findSecondLargestSmallest(){
    let arr =[];

    // Generate 10 random 3-digit numbers
    for(let i=0;i<10;i++){
        arr.push(Math.floor(Math.random()*900)+ 100);
    }
    console.log("Generated Array:",arr);

    let larget =-Infinity ,secondLargest =-Infinity;
    let smallest =Infinity ,secondSmallest =Infinity;

    for(let num of arr){
        if(num>larget){
            secondLargest =larget;
            larget =num;
        }
        else if(num>secondLargest && num!=larget){
            secondLargest =num;
        }

        if (num < smallest) {
            secondSmallest = smallest;
            smallest = num;
        } else if (num < secondSmallest && num !== smallest) {
            secondSmallest = num;
        }
    }

    console.log("2nd Largest:", secondLargest);
    console.log("2nd Smallest:", secondSmallest);
    
}

findSecondLargestSmallest();
