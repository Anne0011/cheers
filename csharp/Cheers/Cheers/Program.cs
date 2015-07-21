using System;

namespace Cheers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please input your name");
			string text = Console.ReadLine ();
			string greeting = ("days until your birthday:");


			Console.WriteLine ("Please input your Birthday (month:00 and day:00)");
			string date = Console.ReadLine ();
			DateTime dateOBJ = DateTime.Parse (date);


			var daysTillBday = (DateTime.Today.Subtract(dateOBJ).Days);

			if (daysTillBday == 0) 
			{
				greeting = ("Happy Birthday!!!!");
			}

			if (daysTillBday > 0)
			{
				daysTillBday = 365 - daysTillBday;
			}
			if (daysTillBday < 0) 
			{
				daysTillBday = daysTillBday * -1;
			}

			//Array[] letters = text.Split("");
			//System.Console.WriteLine("{0} words in text:", words.Length);

			foreach (char s in text)
			{
				System.Console.WriteLine("Give me a...  " + s);
			}
			Console.WriteLine (greeting + " " + daysTillBday);

			// Keep the console window open in debug mode.

			// Keep the console window open in debug mode.




		}
	}

}