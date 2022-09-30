using System;

//Uppgift 3.15

public class Program
{
	public static void Main()
	{
		// programmet frågar om hur många timmar vill hen hyra bilen och sedan räknar ut det hen får inte hyra bilen mer än 11 timmar om dagen.
		Console.WriteLine("hur många timmar tänker du hyra bilen ?");
		int timmar = int.Parse(Console.ReadLine());
		int h = 80;

		if (timmar <= 11)
		{
			Console.WriteLine(timmar * h + " kr");
			Console.WriteLine("det är så mycket du ska betala");
		}
		else if (timmar >= 12)
		{
			Console.WriteLine("Du får in hyra bilen mer än 11 timmar per dag.");
		}

	}

}

