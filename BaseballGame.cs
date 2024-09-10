




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