namespace NumeralSystemsAndCastingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to have a delimiter in your literal values
            // Underscores in numeric literals are IGNORED!
            int ex0 = 12345;
            int ex1 = 12_345;
            int ex2 = 123_45; // Same
            int ex3 = 1_2_3_4_5; // Ugly, but the same

            // Print to verify
            Console.WriteLine(ex0);
            Console.WriteLine(ex1);
            Console.WriteLine(ex2);
            Console.WriteLine(ex3);

            // Binary literals?
            int notBinary = 01101001;
            int bin1 = 0b01101001;
            Console.WriteLine("Binary result: " + bin1);

            // Printing actual binary?
            Console.WriteLine("Actual binary: {0:b}", bin1);

            // --- Casting ---
            
            // Implicit
            short small = 22;
            int medium = small; // This is an IMPLICIT cast

            Console.WriteLine(small);
            Console.WriteLine(medium);

            // Explicit
            short small2 = (short)medium;

            // really big number cast to a short?
            int big = 1234567;
            short cast = (short)big;
            Console.WriteLine("Result of cast from int to short: " + cast);
        }
    }
}
