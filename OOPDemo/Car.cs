// Chris Cascioli
// 10/3/25
// Example of a complex data type stored in a class

namespace OOPDemo
{
    internal class Car
    {
        // The variables of a class are known as "fields"
        private string make;
        private string model;
        private string color;
        private double mileage;

        /// <summary>
        /// Creates a car with the specified values
        /// </summary>
        /// <param name="make">Car maker</param>
        /// <param name="model">Specific model</param>
        /// <param name="color">Paint color</param>
        public Car(string make, string model, string color)
        {
            this.make = make;
            this.model = model;
            this.color = color;

            mileage = 0.0;
        }

        /// <summary>
        /// Prints car stats
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{color} {make} {model} has {mileage} miles.");
        }

        /// <summary>
        /// Simulates the car driving
        /// </summary>
        /// <param name="distance">How far to go</param>
        public void Drive(double distance)
        {
            // Adjust the distance to account for negative values
            mileage += Math.Abs(distance);

            // Report the results
            Console.WriteLine($"{model} drives {distance} miles.  Total is {mileage}.");
        }
    }
}
