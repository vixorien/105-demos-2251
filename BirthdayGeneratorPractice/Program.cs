// Chris Cascioli
// 9/29/25
// Example implementation of practice problem

namespace BirthdayGeneratorPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt & generate
            Console.Write("How many birthdays? ");
            int count = int.Parse(Console.ReadLine()!);

            int[] birthdays = GenerateBirthdays(count);

            // Print each month total
            Console.WriteLine("Jan: " + TotalBirthdays(birthdays, 0));
            Console.WriteLine("Feb: " + TotalBirthdays(birthdays, 1));
            Console.WriteLine("Mar: " + TotalBirthdays(birthdays, 2));
            Console.WriteLine("Apr: " + TotalBirthdays(birthdays, 3));
            Console.WriteLine("May: " + TotalBirthdays(birthdays, 4));
            Console.WriteLine("Jun: " + TotalBirthdays(birthdays, 5));
            Console.WriteLine("Jul: " + TotalBirthdays(birthdays, 6));
            Console.WriteLine("Aug: " + TotalBirthdays(birthdays, 7));
            Console.WriteLine("Sep: " + TotalBirthdays(birthdays, 8));
            Console.WriteLine("Oct: " + TotalBirthdays(birthdays, 9));
            Console.WriteLine("Nov: " + TotalBirthdays(birthdays, 10));
            Console.WriteLine("Dec: " + TotalBirthdays(birthdays, 11));

            // Testing
            int total = 0;
            total += TotalBirthdays(birthdays, 0);
            total += TotalBirthdays(birthdays, 1);
            total += TotalBirthdays(birthdays, 2);
            total += TotalBirthdays(birthdays, 3);
            total += TotalBirthdays(birthdays, 4);
            total += TotalBirthdays(birthdays, 5);
            total += TotalBirthdays(birthdays, 6);
            total += TotalBirthdays(birthdays, 7);
            total += TotalBirthdays(birthdays, 8);
            total += TotalBirthdays(birthdays, 9);
            total += TotalBirthdays(birthdays, 10);
            total += TotalBirthdays(birthdays, 11);
            Console.WriteLine("Total: " + total);
        }

        /// <summary>
        /// Generates a number of random birthdays
        /// </summary>
        /// <param name="numberToGenerate">How many birthdays to generate</param>
        /// <returns>Array of random birthday counts</returns>
        static int[] GenerateBirthdays(int numberToGenerate)
        {
            // Make the array
            int[] birthdays = new int[365];

            // Randomly generate birthdays
            Random rng = new Random();
            for (int i = 0; i < numberToGenerate; i++)
            {
                birthdays[rng.Next(365)]++;
            }

            return birthdays;
        }

        /// <summary>
        /// Totals up all birthdays in the given month
        /// </summary>
        /// <param name="birthdays">Array of birthday counts</param>
        /// <param name="month">Index of month</param>
        /// <returns>Total birthdays in given month</returns>
        static int TotalBirthdays(int[] birthdays, int month)
        {
            // How many days in each month?
            int[] daysInMonths = { 
                31, // Jan
                28, // Feb
                31, // March
                30, // April
                31, // May
                30, // June
                31, // July
                31, // August
                30, // Sept
                31, // Oct
                30, // Nov
                31 // Dec
            };

            // Start of month is all previous months added up
            int startOfMonth = 0;
            for (int i = 0; i < month; i++)
                startOfMonth += daysInMonths[i];

            // End of month is start + number of days
            int endOfMonth = startOfMonth + daysInMonths[month];

            // Total and return
            int total = 0;
            for (int i = startOfMonth; i < endOfMonth; i++)
            {
                total += birthdays[i];
            }
            return total;
        }
    }
}
