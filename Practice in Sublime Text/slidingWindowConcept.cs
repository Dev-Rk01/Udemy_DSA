/****************************************************
 1.) Initialize two pointer (left,right) to define the window and use HashSet to store unique
 	 Character in the current window.
 2.) Slide right pointer across the string, checking if each chracter is unique.
 	  ->If the charcter is unique add it the HashSet and update the length of longest substring
	  ->If the duplicate chracter is found, slide the left forward, removing the chracter from
	  	the HashSet untill the duplite is gone.
 3.) Continue this process untill right pointer has travarsed the entire string.
 4.) Return the length of the logest substrin found.
 **************************************************/



public class SlidingWindow
{
	publicLengthOfLongestUniqueSubstring(string s)
	{
		//Store unique character in the current window
		HashSet<char> uniqueChars = new HashSet<char>();

		//Pointers for sliding window
		int left = 0;
		int maxLength = 0;

		//Iterate through the string using the right pointer
		for(int right = 0; right < s.Length; right++)
		{
			//If the character already in the set move the left pointer to remove the duplicates
			while(uniqueChars.Contains(s[right]))
			{
				uniqueChars.Remove(s[left]);
				left++; //Slide the by increment the left pointer
			}
			//Addd the current chracter to the set
			uniqueChars.Add(s[right]);

			//Update maxLength if we found longer unique subsring
			maxLength = Math.max(maxLength, right - left + 1);
		}

		//Return the length of the logest unique substring
		return maxLength;
	}
}


/*************************************************
 This solution utilizes the sliding window technique effictively, ensuring each character is 
 processed only once, resulting in the time complexty of O(n), where n is the length of the 
 input string.
 The use of the HashSet  allows for constant-time lookups and deletions, making the approach
 both optimal and simple to implement for finding the longest unique substring in any given string. 
*************************************************/