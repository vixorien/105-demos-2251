namespace ArrayAndForeachDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basic integers
            int x = 10;
            int y = 23;

            // Declaration and initialization of arrays
            int[] numbers = new int[5];
            double[] prices = new double[10];
            bool[] answers = new bool[3];
            string[] names = new string[10];

            // Setting initial values
            numbers[0] = 99;
            numbers[1] = 85;
            numbers[2] = 72;
            numbers[3] = 101;
            numbers[4] = -6;

            // Shortcut for array initialization with
            // literal values
            int[] scores = { 52, 48, 67, 99, 14 };

            Console.WriteLine();

            // === Print array details ===
            Console.WriteLine("Array: " + numbers);
            Console.WriteLine("First element: " + numbers[0]);
            Console.WriteLine("Second element: " + numbers[1]);
            Console.WriteLine("Size of array: " + numbers.Length);

            // Print the elements
            // Using a for loop
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            // Using a foreach loop
            // - Iterating through a "collection" of data
            // - Iterates (loops) exactly once FOR EACH element
            foreach (int val in numbers)
            {
                Console.WriteLine(val);
            }

            // === Use some methods with arrays ===
            Console.WriteLine();
            Console.WriteLine("Index of 55: " + IndexOf(numbers, 55));
            Console.WriteLine("Index of 101: " + IndexOf(numbers, 101));
            Console.WriteLine("Any negatives? " + AnyNegatives(numbers));
        }

        /// <summary>
        /// Searches an array for a particular value and returns its index
        /// </summary>
        /// <param name="array">Array to search</param>
        /// <param name="search">Value to find</param>
        /// <returns>Index of value, or -1 if not found</returns>
        static int IndexOf(int[] array, int search)
        {
            // Look through the array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == search)
                {
                    return i;
                }
            }

            // No search value found
            return -1;
        }

        /// <summary>
        /// Looks for any negative values in the array
        /// </summary>
        /// <param name="array">Array to search</param>
        /// <returns>tTrue if at least one value is negative, false otherwise</returns>
        static bool AnyNegatives(int[] array)
        {
            // Look through the array
            foreach(int val in array)
            {
                if (val < 0)
                {
                    return true;
                }
            }

            // No negatives found
            return false;
        }

    }
}
