using System.Diagnostics;

// Chris Cascioli
// 11/7/28
// Demo of exceptions and exception handling with try/catch

namespace ExceptionDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Starting program");

			// --- Cause an exception on purpose ---
			try
			{
				int zero = 0;
				int x = 10 / zero;
				Console.WriteLine("After the division");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Detected problem: " + ex.Message);
			}

			// --- More complex example of try/catch ---
			Console.WriteLine();
			Console.Write("Enter a number: ");
			string input = Console.ReadLine()!;

			try
			{
				int result = int.Parse(input);
			}
			catch (FormatException e) // Most specific 
			{
				Console.WriteLine("Problem parsing: " + e.Message);
			}
			catch (OverflowException e)
			{
				Console.WriteLine("Close but not right: " + e.Message);
			}
			catch (Exception e)  // Most general
			{
				Console.WriteLine("Any other error!");
			}
			Console.WriteLine();

			// --- Testing the speed of ifs vs. try/catch ---

			// Make a stopwatch for testing
			Stopwatch sw = new Stopwatch();

			Console.WriteLine("Press enter to run first loop...");
			Console.ReadLine();

			sw.Start();
			int r = 0;
			int z = 0;
			for (int i = 0; i < 99; i++)
			{
				// Do some math and run an if statement
				r++;
				if (z != 0)
				{
					int calc = r / z;
				}
				else
				{

				}
			}
			sw.Stop();
			Console.WriteLine("First loop took: " + sw.Elapsed.TotalMilliseconds);
			sw.Reset();

			Console.WriteLine("Press enter to run second loop...");
			Console.ReadLine();

			sw.Start();

			for (int i = 0; i < 99; i++)
			{
				r++;
				try
				{
					int calc = r / z;
				}
				catch (DivideByZeroException e)
				{
				}
			}

			sw.Stop();
			Console.WriteLine("Second loop took: " + sw.Elapsed.TotalMilliseconds);

			// --- Testing our own exception throwing ---
			Console.WriteLine();
			try
			{
				int total1 = AddASCIIValues("Bob");
				int total2 = AddASCIIValues("");
				int total3 = AddASCIIValues(null);
			}
			catch (Exception e)
			{
				Console.WriteLine("Problem adding values: " + e.Message);
			}

			Console.WriteLine("Ending program");
		}


		/// <summary>
		/// Adds up ascii values of a string
		/// </summary>
		/// <param name="input">String to add up</param>
		/// <returns>Total of all ascii values</returns>
		/// <exception cref="ArgumentNullException">When input is null</exception>
		public static int AddASCIIValues(string input)
		{
			// Check for invalid input
			if (input == null)
			{
				// We have a problem!  Cannot continue
				throw new ArgumentNullException("Cannot add ascii values - input is null");
			}

			// Start off with zero
			int total = 0;

			// Add up all character values
			// (implicitly casting to integers)
			for (int i = 0; i < input.Length; i++)
			{
				total += input[i];
			}

			// Return at the end
			return total;
		}

	}
}
