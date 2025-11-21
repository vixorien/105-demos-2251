// Chris Cascioli
// 11/21/25
// Example of creating and using a Dictionary in C#

namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create some dictionaries
            Dictionary<string, string> dict = new Dictionary<string, string>();
            Dictionary<char, string> charMap = new Dictionary<char, string>();
            Dictionary<int, string> kindaLikeAnArray = new Dictionary<int, string>();
            Dictionary<bool, string> small = new Dictionary<bool, string>();

            // Add some data to the dictionary
            dict.Add("Bob", "123-4567");
            dict.Add("Jim", "999-9999");
			dict.Add("Tom", "222-1234");
			dict.Add("John", "999-9999"); // Duplicate values are fine!
			dict.Add("Larry", "987-6543");
            //dict.Add("Larry", "444-4444"); // Keys must be unique!


            // Alternate syntax for adding or updating data
            dict["Pam"] = "999-1234";
            dict["Pam"] = "222-2222";

			// Getting data back out
			Console.WriteLine("Bob's number: " + dict["Bob"]);
			Console.WriteLine("Pam's number: " + dict["Pam"]);

            // What if the data doesn't exist?
            // Use .ContainsKey() to determine key validity very quickly!
            // - This is NOT just a linear search
            if (dict.ContainsKey("Jan"))
            {
                Console.WriteLine("Jan's number: " + dict["Jan"]);
            }
            else
            {
				Console.WriteLine("No jan");
            }

            // TryGetValue looks for a key and, if it exists,
            // gives back the associated value
            string janNumber;
            if (dict.TryGetValue("Jan", out janNumber!))
            {
                Console.WriteLine("Jan's number: " + janNumber);
            }
            else
            {
				Console.WriteLine("Still no jan");
            }

            // Removing data requires the key
            dict.Remove("Larry");
            dict.Remove("Steve"); // Data not there?  returns false


		}
    }
}
