Write a function called maxSubarraySum which accepts an array of integers 
and a number called n. The function should calculate the maximum sum of n 
consecutive elements in the array.

maxSubarraySum([1,2,5,2,8,1,5],2) // 10
maxSubarraySum([1,2,5,2,8,1,5],4) // 17
maxSubarraySum([4,2,1,6],1) // 6
maxSubarraySum([4,2,1,6,2],4) // 13
maxSubarraySum([],4) // null

function maxSubarraySum(arr, n){
    let max = 0;
    for(let i=0;i<arr.length;i++) {
        let temp = 0;
        for(let j=0;j<n;j++) {
            temp += arr[i+j];
        }
        if(temp>max) max=temp;
    }
    return max
}

//Optimized solution
function maxSubarraySum(arr, num){
  let maxSum = 0;
  let tempSum = 0;
  if (arr.length < num) return null;
  for (let i = 0; i < num; i++) {
    maxSum += arr[i];
  }
  tempSum = maxSum;
  for (let i = num; i < arr.length; i++) {
    tempSum = tempSum + arr[i] - arr[i - num];
    maxSum = Math.max(maxSum, tempSum);
  }
  return maxSum;
}

Write a function called maxSubarraySum which accepts an array of integers 
and a number called n. The function should calculate the maximum sum of n 
consecutive elements in the array.

maxSubarraySum([1,2,5,2,8,1,5],2) // 10
maxSubarraySum([1,2,5,2,8,1,5],4) // 17
maxSubarraySum([4,2,1,6],1) // 6
maxSubarraySum([4,2,1,6,2],4) // 13
maxSubarraySum([],4) // null

function maxSubarraySum(arr, num) {
    let tempSum = 0;
    let maxSum = 0;
    for(let i = 0; i < num; i++) {
        maxSum += arr[i];
    }
    tempSum = maxSum;
    for(let i = num; i < arr.length; i++) {
        tempSum = tempSum + arr[i] - arr[i - num];
        Math.max(tempSum, maxSum);
    }
}