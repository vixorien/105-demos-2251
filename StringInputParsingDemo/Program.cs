// Chris Cascioli
// 9/8/25
// Examples of string methods, console input
// and parsing numbers from strings

namespace StringInputParsingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating several strings
            string name = "Chris";
            string food = "pizza";

            // Combine and print some strings
            Console.WriteLine(name);
            Console.WriteLine(name + food);
            Console.WriteLine(name + " ate some " + food + " last night");

            // String interpolation
            Console.WriteLine($"{name} ate some {food} last night");
            string save = $"{name} likes {food}";

            // Indexing into strings
            Console.WriteLine();
            string letters = "abcdef";

            Console.WriteLine("First letter is " + letters[0]);
            Console.WriteLine("Last letter is " + letters[5]);
            // Console.WriteLine("Uh oh " + letters[99]); // Won't work, will crash!

            // === String Methods ===
            Console.WriteLine();

            // String are IMMUTABLE!  We cannot change their
            // contents, so we must overwrite with new data
            name = name.ToUpper();
            Console.WriteLine("Name in upper case: " + name);
            name = name.ToLower();
            Console.WriteLine("Name in lower case: " + name);

            // Getting info about strings
            Console.WriteLine("Name starts with 'c'? " + name.StartsWith('c'));
            Console.WriteLine("Contains 'r'? " + name.Contains('r'));
            Console.WriteLine("Index of 'x': " + name.IndexOf('x'));

            Console.WriteLine("Length of string: " + name.Length);

            // Manipulating strings
            string sentence = "Today is Monday (unfortunately)";
            string day = sentence.Substring(9);
            string day2 = sentence.Substring(9, 6);
            Console.WriteLine(day);
            Console.WriteLine(day2);

            // === Special Characters ===
            Console.WriteLine();
            string twoLines = "Almost done?\nGetting there...";
            string tab = "First\t\t\tSecond";
            string tab2 = "Hi\t\t\tthere";
            string quotes = "I want \"quotes\" please";

            Console.WriteLine(twoLines);
            Console.WriteLine(tab);
            Console.WriteLine(tab2);
            Console.WriteLine(quotes);

            // === Numeric formatting ===
            Console.WriteLine();

            int num = 7654;
            Console.WriteLine(num);
            Console.WriteLine($"{num:C}");
            Console.WriteLine($"{num:N}");
            Console.WriteLine($"{num:N5}");

            // === Console Input ===
            Console.WriteLine();
            Console.Write("Enter your name: ");
            string input = Console.ReadLine()!;

            Console.Write("Enter your age: ");
            string ageString = Console.ReadLine()!;

            // === Parsing Numbers from Strings ===
            Console.WriteLine();

            // int age = (int)ageString; // Cannot CAST from string to int

            // Must call the parse method of the int data type
            int age = int.Parse(ageString);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Doubled is " + age * 2);

            
        }
    }
}
