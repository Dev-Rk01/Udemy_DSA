function(arr1, arr1)
{
    if(arr1.length !== arr2.length) return false;
    let freqCount1 = {};
    let freqCount2 = {};
    for(let val in arr1) {freqCount1[val] = (freqCount1[val] || 0) + 1;}
    for(let val in arr2) {freqCount2[val] = (freqCount1[val] || 0) + 1;}
    for(let key in freqCount1) 
    {
        if(!(key**2 in freqCount2)) return false;
        if (freqCount2[key**2]!=freqCount1[key]) return false;
    }
    return true;
}