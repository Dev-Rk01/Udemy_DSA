public static int FindLongestSubstring(string str)
{
	if(string.IsNullOrEmpty(str)) return 0;

	Dictionary<char, int> seen = new Dictionary<char, int>();
	int maxLength = 0;
	int start = 0;

	for (int end = 0; end < str.Length; end++)
	{
		char currentChar = str[end];

		if(seen.ContainsKey(currentChar))
		{
			start = seen[currentChar] + 1;
		}

		seen[currentChar] = end;

		maxLength = Math.Max(maxLength, end - start + 1);
	}
	return maxLength;
}