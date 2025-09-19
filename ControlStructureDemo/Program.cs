// Chris Cascioli
// 9/10/25
// Demo of control structures (like ifs, switches and loops),
// as well as console colors and some new operators

namespace ControlStructureDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // === Console Colors ===
            Console.WriteLine("Basic output");

            // Changing the foreground (text) color
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Some red text");
            Console.WriteLine("And more");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Gross");

            // What about background colors?
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Oh wow this is also gross");

            // This will clear the whole console to the current
            // background color
            //Console.Clear();

            // Reset to defaults
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();

            // === Operators ===

            // Relational
            bool obv = 5 > 2;
            bool nope = 22 == 17;

            // Boolean operators
            bool not = !true; // This is a unary operator

            bool tat = true && true;
            bool taf = true && false;
            bool tot = true || true;
            bool tof = true || false;

            bool singleAnd = true & true;
            bool singleOr = false | true;

            // So why do the && and || operators exist?
            // - They "short circuit" and can stop evaluating
            //   once they have enough info for a definitive
            //   answer
            if (false && PrintAndReturnFalse())
            {
                Console.WriteLine("Yay!");
            }

            // === Conditional statements ===

            // If statements
            bool test = true && false;
            if (test)
            {

            }

            // Get user input and check it
            Console.Write("Enter your D&D class: ");
            string charClass = Console.ReadLine()!;

            // Input sanitization
            charClass = charClass.Trim().ToLower();

            int extraDice = 0;
            if (charClass == "rogue")
            {
                extraDice = 2;
                Console.WriteLine("Stabby stabby");
            }
            else if (charClass == "wizard")
            {
                Console.WriteLine("Fireball!");
            }
            else if (charClass == "monk")
            {
                Console.WriteLine("Pop pop!");
            }
            else
            {
                Console.WriteLine("Not available");
            }

            Console.WriteLine(extraDice);


            // Switch statement
            switch (charClass)
            {
                case "paladin": Console.WriteLine("Aura is active!"); break;
                case "cleric": Console.WriteLine("Healing!"); break;
                case "artificer": Console.WriteLine("Shoot"); break;
                case "barbarian": Console.WriteLine("RAGE!"); break;

                // Explicit fall through
                // - Only allowed with "empty" cases
                case "warlock":
                case "ranger":
                case "fighter":
                    Console.WriteLine("Coming soon!");
                    break;

                default:
                    Console.WriteLine("Not yet implemented");
                    break;
            }

            // === Loops ===

            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            // Do/while loops always execute
            // their bodies at least once
            string name;
            do
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine()!;
            }
            while (name.Length == 0);


            // Basic for loop
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Non-standard for loop
            for (string nameExample = "";
                nameExample.Length == 0;
                nameExample = Console.ReadLine()!)
            {
                Console.Write("Enter your name: ");
            }

            // === Controlling loop execution ===

            // Break allows us to end a loop early
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

                if (i == 5)
                {
                    break;
                }
            }
            Console.WriteLine();

            // Continue keyword allows us to "skip"
            // part of an iteration
            // - Jumps back to the "top" of the loop
            //   and continues with the NEXT iteration
            for (int i = 10; i < 20; i++)
            {
                if (i == 15)
                {
                    continue;
                }

                Console.WriteLine(i);
            }


            // === Best Practices ===

            string state = "NY";
            int age = 14;

            if (state == "NY" && age >= 16)
            {
                // NO!  Don't do this!
                // NO NO NO NO NO 
            }
            else
            {
                Console.WriteLine("Not old enough");
            }

            // Be explicit about your loop ending conditions
            // - Put them in the loop definition
            string input = "";
            while (input != "quit")
            {
                Console.Write("Enter your command: ");
                input = Console.ReadLine()!;

                // Process input here
                if (input == "talk") { }
                else if (input == "move") { }
                else if (input == "attack") { }

            }

        }

        static bool PrintAndReturnFalse()
        {
            Console.WriteLine("I am in the function!");
            return false;
        }
    }
}
