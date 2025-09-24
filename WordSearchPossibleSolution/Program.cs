// Chris Cascioli
// 9/24/25
// Example of previous PE (word search)

namespace WordSearchPossibleSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a 2D array of characters
            // Note: Yours should prompt the user for sizes
            char[,] puzzle = new char[15, 10]; // Height (rows), Width (columns)

            // Fill it with random data
            Random rng = new Random();
            for (int row = 0; row < puzzle.GetLength(0); row++)
            {
                for (int col = 0; col < puzzle.GetLength(1); col++)
                {
                    // Remember that the upper bound on .Next() is not inclusive!
                    puzzle[row, col] = (char)rng.Next(97, 123);
                }
            }

            // Print out the entire array
            for (int row = 0; row < puzzle.GetLength(0); row++)
            {
                for (int col = 0; col < puzzle.GetLength(1); col++)
                {
                    Console.Write(puzzle[row, col] + " ");
                }
                Console.WriteLine();
            }

            // Prompt the user for a word to look for
            Console.WriteLine();
            Console.Write("Enter a word to look for: ");
            string search = Console.ReadLine()!;

            Console.WriteLine(SearchHorizontal(puzzle, search));
        }

        /// <summary>
        /// Searches a 2D array of characters for the specified search string
        /// </summary>
        /// <param name="puzzle">Array to search</param>
        /// <param name="search">String to look for</param>
        /// <returns>True if string appears horizontally in array, false otherwise</returns>
        public static bool SearchHorizontal(char[,] puzzle, string search)
        {
            for (int row = 0; row < puzzle.GetLength(0); row++)
            {
                for (int col = 0; col < puzzle.GetLength(1); col++)
                {
                    // Go through the string and test 
                    // each character as we go
                    int i = 0;
                    while (
                        i < search.Length && 
                        col + i < puzzle.GetLength(1) &&
                        puzzle[row, col + i] == search[i])
                    {
                        i++;
                    }

                    // Did we make it all the way through?
                    if (i == search.Length)
                    {
                        return true;
                    }
                }
            }

            // Not found
            return false;
        }
    }
}
