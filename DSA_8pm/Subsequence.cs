public static int minSubArray(int[] nums, int sum)
{
	int total = 0;
	int start = 0;
	int end = 0;
	int minLength = Infinity;

	while(end < nums.Length)
	{
		total += nums[end];

		while(total >= sum)
		{
			minLength = Math.min(minLength, end-start+1)
			total -= nums[start];
			start++;
		}
		end++;
	}
	 return minLength === Infinity ? 0 : minLength;
} 