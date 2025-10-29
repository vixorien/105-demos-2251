// Chris Cascioli
// 10/29/25
// Demo of enums

namespace EnumDemo
{
    /// <summary>
    /// Days of the week starting with Sunday
    /// </summary>
    enum Day
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    /// <summary>
    /// Example of an enum used as a "bit flag" or "bit field"
    /// </summary>
    enum PizzaToppings
    {
        Sausage = 1,
        Chicken = 2,
        Pineapple = 4,
        Ham = 8,
        Peppers = 16
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Using existing enums
            Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("I'm red!");

            // Enums are data types
            ConsoleColor myColor = ConsoleColor.Green;
            Console.ForegroundColor = myColor;
            if (myColor == ConsoleColor.Green)
            {
                Console.WriteLine("I'm green!");
            }
            else if (myColor == ConsoleColor.Yellow)
            {
				Console.WriteLine("Ow my eyes");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine();

            // ---
            // Using a custom enum
            Day today = Day.Wednesday;
            if (today == Day.Wednesday)
            {
                Console.WriteLine("It is Wednesday my dudes");
            }
            else if (today <= Day.Friday && today != Day.Sunday)
            {
				Console.WriteLine("Almost the weekend?");
            }

            // Can I do math with enum values?
            today++;
            if (today == Day.Thursday)
            {
				Console.WriteLine("Time travel!");
            }

			// Printing an enum
			Console.WriteLine(today);

            // Testing bounds
            today = Day.Saturday; // Should be 6
            today++;
			Console.WriteLine(today);

            // Enums and switch statements are BFFs
            today = Day.Wednesday;
			switch (today)
			{
				case Day.Sunday: Console.WriteLine("Tomorrow's Monday :("); break;
				case Day.Monday: Console.WriteLine("The worst"); break;
                case Day.Tuesday: Console.WriteLine("Slightly better"); break;
                case Day.Wednesday: Console.WriteLine("Hump day"); break;
				case Day.Thursday: Console.WriteLine("Is it Thursday yet?"); break;
				case Day.Friday: Console.WriteLine("Finally!"); break;
				case Day.Saturday: Console.WriteLine("The best"); break;
			}
		}
	}
}
