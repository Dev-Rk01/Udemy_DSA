/************************************
 Question -> Get max sum of two(n=2, for this example) consicutive numbers of an array.
 i/p = [1,2,5,2,8,1,5] , 2
 o/p = 2 + 8 = 10
 -> Iterate through i/p
 -> sum two consicutive number and store it
 -> Move to the next two consucutive number and sum it
 -> Compare previous sum to this sum and store the max of both
 -> After complete iteration of arr you will get max sum of two 
 	consicutive number of an array. 
 ************************************/

public class MaxSubArraySum
{
	public int maxsum(int[] arr, n)
	{
		//Initialize the pointer and maxSum variable so that it will 
		//point consicutive element of an array
		int left = 0;
		int right = 1;
		int maxSum = 0;

		//Set the condition for loop iteration 
		while(right<arr.Length)
		{
			//maxSum will store the max of the given arguments
			maxSum = Math.max(maxSum, arr[left]+arr[right]);

			//move pointer the next consicutive window
			left++;
			right++;
		}
		//return the max result after iteration.
		return maxSum;
	}
}