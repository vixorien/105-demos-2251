// Chris Cascioli
// 12/3/25
// Demo of file IO, both "ez mode" and using stream objects

using System.Collections.Concurrent;

namespace FileIODemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Set up file details
			string filepath = "../../../myFile.txt";
			string content = "First line\nNext line\nLast line";

			// Write data to file
			File.WriteAllText(filepath, content);

			// Read data from file
			string dataFromFile = File.ReadAllText(filepath);
			Console.WriteLine(dataFromFile);
			Console.WriteLine();

			// Denote that we're finished
			Console.WriteLine("EZ Mode done");
			Console.WriteLine();

			// Test out a finally block to see how it works
			Console.WriteLine("Testing finally block");
			TestingFinallyBlock();
			Console.WriteLine();

			// Now lets do a slight more interesting version
			WriteDataToStream(filepath);
			ReadDataFromStream(filepath);
			Console.WriteLine();

			Console.WriteLine("All done");
		}

		/// <summary>
		/// Writes a set of data to the specified file
		/// using a StreamWriter
		/// </summary>
		/// <param name="filepath">Path to file</param>
		static void WriteDataToStream(string filepath)
		{
			// Create in the function scope
			StreamWriter output = null;

			try
			{
				// Create the stream writer in the try scope
				output = new StreamWriter(filepath);

				// Write data
				output.WriteLine("A line of text in the file");
				output.WriteLine("2nd line");
				output.WriteLine("3rd line");
				output.WriteLine("More lines");
				output.WriteLine("The last line");
			}
			catch (Exception e)
			{
				Console.WriteLine("Problem writing to file: " + e.Message);
			}
			finally
			{
				// Close the file
				if (output != null)
					output.Close();
			}
		}

		/// <summary>
		/// Reads data from a file line by line
		/// </summary>
		/// <param name="filepath">The path to the file</param>
		static void ReadDataFromStream(string filepath)
		{
			// Create a stream reader
			StreamReader input = new StreamReader(filepath);

			// Read data
			string line = null!;
			while ((line = input.ReadLine()!) != null)
			{
				Console.WriteLine(line);
			}

			// Close file
			input.Close();
		}

		/// <summary>
		/// Quick test of a finally block
		/// </summary>
		static void TestingFinallyBlock()
		{
			try
			{
				Console.WriteLine("Try!!");
				return;
			}
			catch (Exception e)
			{
				Console.WriteLine("Catch!!");
			}
			finally
			{
				Console.WriteLine("Finally!!");
			}
		}
	}
}
