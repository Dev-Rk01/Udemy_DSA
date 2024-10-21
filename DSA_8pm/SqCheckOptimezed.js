function Same(arr1, arr2) {
    
    /*The function first checks if arr1 and arr2 have the same length. If they don't, 
      it immediately returns false because if their lengths are different, 
      it's impossible for all values in arr1 to have corresponding squared values in arr2*/
    if (arr1.length !== arr2.length) return false;

    /*Two empty objects are initialized: frequencyCounter1 for counting the frequency of 
      elements in arr1 and frequencyCounter2 for counting the frequency of elements in arr2.*/
    let freqCounter1 = {};
    let freqCounter2 = {};
    
    /*This loop goes through every value in arr1.
      For each value val, it checks if val exists in frequencyCounter1. 
      If it does, it increments the count by 1. If it doesn't, it initializes the count to 1.
      Example: If arr1 = [1, 2, 2, 3], frequencyCounter1 becomes: { 1: 1, 2: 2, 3: 1 }*/
    for (let val of arr1) {
        freqCounter1[val] = (freqCounter1[val] || 0) + 1;
    }

    /*Similarly, this loop goes through every value in arr2 and counts the 
      frequency of each element. Example: If arr2 = [1, 4, 4, 9], 
      frequencyCounter2 becomes: { 1: 1, 4: 2, 9: 1 } */
    for (let val of arr2) {
        freqCounter2[val] = (freqCounter2[val] || 0) + 1;
    }


    /*This loop checks if every element in arr1 has a corresponding squared value in arr2.
      key ** 2 is the square of each element in arr1. For example, if key = 2, key ** 2 = 4.
      The loop checks two conditions:  
      1.) Check if Squared Value Exists:
      2.) Check if Frequencies Match:*/
    
    for (let key in freqCounter1) {
        
     /*1.) Check if Squared Value Exists:
           This condition checks whether the squared value of key exists in 
           frequencyCounter2. If it doesn't, it returns false.*/
        if (!(key ** 2 in freqCounter2))
            return false;
        
     /*2.) Check if Frequencies Match:
           If the squared value exists, the next condition checks whether the 
           frequency of key ** 2 in arr2 matches the frequency of key in arr1. 
           If the frequencies don't match, it returns false.*/
        if (freqCounter2[key ** 2] !== freqCounter1[key])
            return false;
    }
    return true;
}
