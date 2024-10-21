		public static string ReversedString(string str)
		{
			string reversedString = "";

			for(int i = str.Length - 1; i >= 0; i--)
			{
				reversedString += str[i];
			}
			return reversedString;
		}

		//javaScript
		function ReversedString (str)
		{
			let reversedString = "";

			for(i = str.length-1; i--)
			{
				reversedString += str[i];
			}
			return reversedString;
		}