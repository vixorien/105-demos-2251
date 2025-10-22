// Chris Cascioli
// 10/22/25
// Example of a "parent" class that can be
// used to derive new ("child") classes

namespace InheritanceDemo
{
    internal class Vehicle
    {
        // Fields
        protected string make;
        protected string model;
        protected double mileage;

        // Properties
        /// <summary>
        /// Gets the make of the vehicle
        /// </summary>
        public string Make { get { return make; } }

        /// <summary>
        /// Gets the model of the vehicle
        /// </summary>
        public string Model { get { return model; } }

        /// <summary>
        /// Gets the mileage of the vehicle
        /// </summary>
        public double Mileage { get { return mileage; } }

        // Constructor

        /// <summary>
        /// Creates a new vehicle with zero mileage
        /// </summary>
        /// <param name="make">Maker</param>
        /// <param name="model">Specific model</param>
        public Vehicle(string make, string model)
        {
            Console.WriteLine("VEHICLE constructor");

            this.make = make;
            this.model = model;
            this.mileage = 0;
        }

        // Methods

        /// <summary>
        /// Simulates moving a set distance
        /// </summary>
        /// <param name="distance">Distance to move</param>
        public void Drive(double distance)
        {
            // Update the mileage
            mileage += Math.Abs(distance);

            // Print a message
            Console.WriteLine($"{make} {model} drives {distance}");
        }
    }
}
