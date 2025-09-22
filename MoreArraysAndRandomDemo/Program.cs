namespace MoreArraysAndRandomDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // === Arrays of complex types ===
            int[] numbers = new int[8];
            string[] names = new string[5];

            // Accessing names[2] will cause
            // a null reference error before
            // any data is actually set
            // names[2].ToLower(); // PROBLEM!

            names[0] = "Jim";
            names[1] = "Pam";
            names[2] = "Jan";
            names[3] = "Bob";
            names[4] = "Tom";


            names[2] = names[2].ToLower();
            Console.WriteLine(names[2]);


            // === Multidimensional arrays ===

            // --- Jagged array ---
            // Create outer array first
            int[][] jaggedArray = new int[3][];

            // Explicitly creating the interior arrays
            jaggedArray[0] = new int[2];
            jaggedArray[1] = new int[5];
            jaggedArray[2] = new int[3];

            // Element access requires [][]
            Console.WriteLine("Element [2,1]: " + jaggedArray[2][1]);

            // --- True multidimensional arrays ---

            // Multidimensional arrays use [,]
            int[,] mdArray = new int[3,5];

            // Setting data
            mdArray[2, 3] = 55;
            mdArray[1, 4] = 99;

            // Check the length of this array
            Console.WriteLine("Length of [3,5]: " + mdArray.Length);
            Console.WriteLine("Length of 1st dimension: " + mdArray.GetLength(0));
            Console.WriteLine("Length of 2nd dimension: " + mdArray.GetLength(1));


            // Literal multidimensional array
            int[,] literalArray =
            {
                { 3, 4, 5 },
                { 8, 2, 4 }
            };

            // Foreach through a 2D array
            Console.WriteLine();
            Console.WriteLine("Foreach through 2D array");
            foreach (int value in literalArray)
            {
                Console.WriteLine(value);
            }

            // How many dimensions?
            int[,] two = new int[5, 5];
            int[,,] three = new int[3, 4, 5];
            int[,,,,,,,,,] wtf = new int[2,2,2,2,2,2,2,2,2,2];

            Console.WriteLine();


            // === Random numbers ===

            // Step one: Create a random number generator object
            // - The data type is "Random"
            // - The default seed is the system time (at the millisecond level)
            Random rng = new Random();

            // Overloads of .Next() method
            Console.WriteLine(rng.Next()); // Any non-negative int
            Console.WriteLine(rng.Next(50)); // 0 - 50 (exclusive upper bound)
            Console.WriteLine(rng.Next(-10, 6)); // -10 - 6 (exclusive upper bound)

            // Doubles also work
            double num = rng.NextDouble();
            Console.WriteLine("0.0 - 1.0: " + num);
            Console.WriteLine("0.0 - 5.0: " + (num * 5));

        }
    }
}
