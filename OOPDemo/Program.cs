// Chris Cascioli
// 10/3/25
// Example of OOP

namespace OOPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make a car
            Car myFirstCar = new Car("VW", "Jetta", "Blue");
            myFirstCar.Drive(3);
            myFirstCar.Drive(7);
            myFirstCar.Drive(400);
            myFirstCar.Print();

            Car secondCar = new Car("Honda", "Fit", "Black");
            secondCar.Drive(-7);
            secondCar.Print();
        }
    }

}
