namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 99;
            Increment(val);
            Console.WriteLine(val);

            int num1 = GetUserInt();
            Console.WriteLine("You entered " + num1);

            int num2 = GetUserInt();
            Console.WriteLine("You entered " + num2);

            int num3 = GetUserInt();
            Console.WriteLine("You entered " + num3);

            int age = GetUserInt("Enter your age: ");
            Console.WriteLine($"You are {age * 365} days old");

            int money = GetUserInt("Enter money: ");
            Console.WriteLine("You have $" + money);


        }

        /// <summary>
        /// Uses a default prompt and gets 
        /// the user's input
        /// </summary>
        /// <returns>The user's integer</returns>
        static int GetUserInt()
        {
            return GetUserInt("Enter a number: ");
        }

        /// <summary>
        /// Uses the specified prompt and
        /// gets the user's input
        /// </summary>
        /// <param name="prompt">Printed before input</param>
        /// <returns>The user's integer</returns>
        static int GetUserInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine()!);
        }

        // === Method & variable scope ===

        static void Increment(int i)
        {
            i += 10;
        }

        // === Examples of method overloading ===
        static void Example() { }
        static void Example(int a) { }
        static void Example(int a, int b) { }
        static void Example(int a, string name) { }
        static void Example(string name, int a) { }

        // The following are invalid because their signatures
        // match existing overloads above
        //static void Example(int age, string sentence) { }
        //static void Example(int horse, int cheese) { }
    }
}
