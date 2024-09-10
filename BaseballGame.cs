/*************************************
 **Baseball Game**

You are keeping score for a baseball game with strange rules. The game consists of several rounds, where the scores of past rounds may affect future rounds' scores.

At the beginning of the game, you start with an empty record. You are given a list of strings `ops`, where `ops[i]` is the ith operation you must apply to the record and is one of the following:
   
1. An integer `x` - Record a new score of `x`.
2. `"+"` - Record a new score that is the sum of the previous two scores. It is guaranteed there will always be two previous scores.
3. `"D"` - Record a new score that is double the previous score. It is guaranteed there will always be a previous score.
4. `"C"` - Invalidate the previous score, removing it from the record. It is guaranteed there will always be a previous score.

Return the sum of all the scores on the record.


**Example 1:**

- Input: `ops = ["5", "2", "C", "D", "+"]`
- Output: `30`

**Explanation:**

- `"5"` - Add 5 to the record. Record is now `[5]`.
- `"2"` - Add 2 to the record. Record is now `[5, 2]`.
- `"C"` - Invalidate and remove the previous score. Record is now `[5]`.
- `"D"` - Add 2 * 5 = 10 to the record. Record is now `[5, 10]`.
- `"+"` - Add 5 + 10 = 15 to the record. Record is now `[5, 10, 15]`.

The total sum is `5 + 10 + 15 = 30`.

---

**Example 2:**

- Input: `ops = ["5", "-2", "4", "C", "D", "9", "+", "+"]`
- Output: `27`



Problem Solving Plan:
 1. Understand the problem :
 	-> We need simulate a game where operations are applied to maintain a record of scores.

 	Operations include:
 	 -> Adding a number to the record.
 	 -> Summing the last two record.
 	 -> Doubling the last two score.
 	 -> Removing the last score.

 	We need to return the sum of the valid scores after applying all operations.

 2. Choose a Data Structure:
 	 -> A stack (or List<int> in C#) is appropriate since we frequentl need to access, add 
 	    or remove the last score.

 3. Plan of Action.
 	 -> Initialize an empty list (stack) to store the scores.
 	 -> Iterate through each opretaion:
 	 	 - if it's a number, parse it and add it to the stack.
 	 	 - if it's "+", sum the last two scores and and it to the stack.
 	 	 - if it's "D", double the last score and add it to the stack.
 	 	 - if it's "C", remove the last score.

 	 -> At the end of the iteration , return the sum of all scores in the stack.

 4. Edge Cases: 
 	 -> The input will always be valid as per the problem statement (there will always be at
 	 	least two previous scores for "+", and at least one score for "D" and "C").

**************************************/








public class BaseballGame
{
	// This method calculates the final score based the operations provided.
	public int CalPoints(string[] ops)
	{
		// Initialize a list to act as a stack to store valid scores.
		List<int> stack = new List<int>();

		// Iterate through each operation in the ops array.
		foreach(string in ops)
		{
			// if the operation is "+",sum the last two scores and add the result.
			if(op=="+")
			{
				int lastValue = stack[stack.count-1]; // Get the last score.
				int secondLastValue = stack[stack.count-2]; // Get the second last score.
				stack.Add(lastValue + secondLastValue); // Add the sum of last two scores.
			}

			// if the operation is "D", double the last score amnd add it.
			else if(op=="D")
			{
				int lastValue = stack[stack.count-1]; //Get the last score.
				stack.Add(2 * lastValue); //Double the last score and it to the stock.
			}

			//if the opration is "C", remove th elast score.
			if(op=="C")
			{
				int lastIndex = stack.count-1; // Get the last index.
				stack.RemoveAt(lastIndex) // Remove the last score from the stack.
			}

			// Otherwise, it is number so parse it and the it to the stack.
			else
			{
				stack.Add(int.parse(op)); // Convert string to int and add it to the stack.
			}
		}

		// Calculate the sum of all the scores in the stack.
		int total = 0;
		foreach(int score in stack)
		{
			total += score; // Accumulate the sum of valid scores.
		}

		//Return the total sum of scores.
		return total;
	}
}


/**************************************
Final Comments on Code:
	1. Efficiency: The code efficiently processes each operation in O(n) time complexity, 
	     where n is the number of operations. It uses a stack-like structure to manage the 
	     scores, ensuring constant time operations for adding, removing, or accessing the 
	     last score.
	2. Readability: The code is structured and commented clearly. Each step is easy to 
	     follow, with comments explaining the logic behind each operation and the purpose 
	     of each method.
	3. Edge Case Handling: The input is assumed to be valid as per the problem description, 
	     so no additional edge case handling (like empty input or invalid operations) is required.
	4. Scalability: This approach will scale well for larger inputs, as the primary operations 
	     (add, remove, sum) remain efficient with larger datasets.
	5. Possible Improvements: This solution is well-suited for the problem and doesn't need 
	     any further optimization unless specific additional constraints 
	     (like memory limits) are imposed.

**************************************/