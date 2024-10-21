public static bool averagePair(int[] arr, int avg)
{
	int start = 0;
	int end = arr.Length -1;
	decimal currentAvg = 0;

	while(start < end)
	{
		currentAvg = (arr[start]+arr[end])/2
		if(currentAvg==avg) return true;
		else if(currentAvg>avg) end--;
		else start++;
	}
	return false;
}