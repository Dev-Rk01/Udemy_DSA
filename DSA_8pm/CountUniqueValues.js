Q.)countUniqueValues
Implement a function called countUniqueValues, which accepts a sorted array,
and counts the unique values in the array. There can be negative numbers in the array,
but it will always be sorted.

countUniqueValues([1,1,1,1,1,2]) // 2
countUniqueValues([1,2,3,4,4,4,7,7,12,12,13]) // 7
countUniqueValues([]) // 0
countUniqueValues([-2,-1,-1,0,1]) // 4


function countUniqueValues(arr) {
    let freq = {};
    let count = 0;
    for(let val of arr) freq[val] = freq[val] ? freq[val] + 1 : 1 ;
    for(let key in freq) count++ ;
    return count;
}


[1,2,3,4,4,4,7,7,12,12,13]
function countUniqueValues(arr){
  let count = 1;
  let start = 0;
  let next  = 1;
 
 if(arr.length===0) return 0
    
  while(next < arr.length)
  {      
      if(arr[start] != arr[next])
      {
          count++;
          start = next;
      }
      next++;
  }
  return count;
}


function countUniqueValues(arr){
    if(arr.length === 0) return 0;
    var i = 0;
    for(var j = 1; j < arr.length; j++){
        if(arr[i] !== arr[j]){
            i++;
            arr[i] = arr[j]
        }
    }
    return i + 1;
}


