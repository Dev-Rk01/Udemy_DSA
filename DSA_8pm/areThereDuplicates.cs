 public static bool areThereDuplicates(params object[] args)
 {
 	//Create a HashSet tostore a element
 	HashSet<object> freqCounter = new HasSet<object>();

 	//Loop through each argument
 	foreach(var value in args)
 	{
 		// If the value is already in the set, there's a duplicate
 		if(freqCounter.Contains(value))
 		{
 			return true;
 		}

 		// Otherwise, add it to the set
 		freqCounter.Add(value);
 	}

 	// No duplicates found
 	return	false;
 }

 public static bool areThereDuplicatesOpt(params object[] args)
 {
 	//sort the argument array (convert to string for comprasion purposes)
 	var sortedArgs = args.Select(arg => arg.ToString()).OrderBy(arg => arg).ToArray();

 	//compare each element to its next one
 	for(int i=0; i<sortedArgs.Length-1; i++)
 	{
 		if(sortedArgs[i]==sortedArgs[i+1]) return true //duplicate found
 	}
 	return false //No duplicate found
 }