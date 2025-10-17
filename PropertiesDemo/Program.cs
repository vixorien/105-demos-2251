// Chris Cascioli
// 10/17/25
// Demo of properties for encapsulation

namespace PropertiesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a test object
            Car firstCar = new Car("VW", "Jetta", "Blue");
            firstCar.Print();

            // Set the mileage using the property
            firstCar.Mileage = 10;

            // Get the mileage using the property
            Console.WriteLine("Mileage: " + firstCar.Mileage);

            // Do "shortcut" operators work?
            firstCar.Mileage++;
            firstCar.Mileage += 5;

            // Get the mileage
            Console.WriteLine("Mileage: " + firstCar.Mileage);

            // Get the make
            Console.WriteLine("Maker: " + firstCar.Make);
            //firstCar.Make = "Toyota";

            // Change the owner
            firstCar.Owner = "Bob";
            Console.WriteLine("Who owns the car? " + firstCar.Owner);
        }
    }
}
