public class maxConsicutiveSum
{
	public static int GetMaxSumOfNum(int[] arr, int n)
	{
		if(arr.Length < n)
		{
			throw new ArgumentException($"Array must have at least {n} ");
		}

		//calculate the sum of 1st n consicutive number

		int maxSum = 0
		for(int i; i<n; i++)
		{
			maxSum += arr[i];
		}

		int currentSum = maxSum;

		for(int i = n; i < arr.Length; i++)
		{
			currentSum = currentSum - arr[i-n] + arr[i]

			maxSum = Math.Max(maxSum,currentSum);
		}

		return maxSum;
	}
}