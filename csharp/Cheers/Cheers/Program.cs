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

			int difference = 0;

			DateTime lastDay = new DateTime(2015, 12 ,31);
			if (DateTime.today < DateTime.Parse(bday)) { 
				difference = DateTime.Parse(bday).DayOfYear - DateTime.Today;
			}else{
				difference = lastDay.DayOfYear - DateTime.Today.DayOfYear + DateTime.Parse(bday).DayOfYear;
			}
			console.WriteLine(“Your Birthday is in {0} days” , difference);

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