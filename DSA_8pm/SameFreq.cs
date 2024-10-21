public static bool SameFrency(int num1, int num2)
{
	//Convert numbers to string to handle the digits
	string str1 = num1.toString();
	string str2 = num2.toString();

	//If the length wont match they cant have same frequency
	if(str1.Length != str2.Length)
	{
		return	false;
	}

	//Create a frequency dictionary for the digits of the first number
	Dictionary<char, int> freqCounter = new Dictionary<char, int>();

	foreach(char digit in str1)
	{
		//Increment the count of the digit
		if(freqCounter.ContainsKey(digit))
		{
			freqCounter[digit]++;
		}
		else
		{
			freqCounter[digit] = 1;
		}
	{


	//Now decrease thw counts while iterating through the second number
	foreach(char digit in str2)
	{
		if(!freqCounter.ContainsKey(digit) || freqCounter[digit] == 0)
		{
			return false;
		}
		freqCounter[digit]--;
	}

	return	true;

}