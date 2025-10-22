// Chris Cascioli
// 10/22/25
// Demo of inheritance

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test a simple vehicle
            Vehicle v = new Vehicle("VW", "Jetta");
            v.Drive(5);
            Console.WriteLine($"Vehicle has {v.Mileage} miles");
            Console.WriteLine();

            // Create a more specific object (a car)
            Car c = new Car("Honda", "Fit", 5, true);
            c.Drive(10);
            Console.WriteLine($"Car has {v.Mileage} miles");
            Console.WriteLine();

            // Create a second car to test constructor chaining
            Car c2 = new Car("Subaru", "Forester");
        }
    }
}
