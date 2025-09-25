namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays are great but have limitations
            int[] array = new int[5];
            // array.Length = 10; // Cannot change length

            // Would be nice to have a data structure
            // that is like an array, but "better"
            // - Does not need an explicit size to start
            // - Can hold "any" amount of data
            // - Has some useful helper methods
            // - Still allows array-like element access: [ ]
            List<int> numberList = new List<int>();
            List<string> nameList = new List<string>();

            // Print info about the list
            ListDetails(numberList);

            // Adding new elements can be done with
            // the .Add() or .Insert() methods
            numberList.Add(17);

            ListDetails(numberList);

            // Add some more data
            numberList.Add(22);
            numberList.Add(-4);
            numberList.Add(55);
            numberList.Add(99);

            ListDetails(numberList);

            // We can .Insert() data between elements
            numberList.Insert(2, 66);
            numberList.Insert(0, -900);
            numberList.Add(1234);
            numberList.Add(5678);

            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }

            ListDetails(numberList);

            // Individual element access
            numberList[0] = 5;
            Console.WriteLine("Data at [0]: " + numberList[0]);

            // Cannot access elements outside of [0,Count-1]
            // numberList[12] = 54321;

            // Removing data
            bool removed = numberList.Remove(7);
            numberList.RemoveAt(0); // Removes whatever is at index 2
            numberList.RemoveAt(2); // Removes whatever is at index 2
            ListDetails(numberList);

            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }

            // Other useful helper methods
            bool isItThere = numberList.Contains(56);
            int index = numberList.IndexOf(56);

        }

        /// <summary>
        /// Print some info about the list
        /// </summary>
        /// <param name="list">List to print</param>
        static void ListDetails(List<int> list)
        {
            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine("Capacity: " + list.Capacity);
            Console.WriteLine();
        }
    }
}
