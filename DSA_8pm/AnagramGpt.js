function validAnagram(s1, s2){
  s1 = s1.toLowerCase().replace(/\s+/g,"");
  s2 = s2.toLowerCase().replace(/\s+/g,"");
  if (s1.length !== s2.length) return false;
  const countFreq = {};
  for (let c of s1) {countFreq[c] = countFreq[c] ? countFreq[c] + 1 : 1;}
  
  for(let c of s2) {
      if(countFreq[c] && countFreq[c]>0) countFreq[c]--;
      else return false;
  }
  return true;
}
