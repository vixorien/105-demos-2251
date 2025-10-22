// Chris Cascioli
// 10/22/25
// Example of a derived (or "child") class

namespace InheritanceDemo
{
    internal class Car : Vehicle
    {
        // Fields
        private int doors;
        private bool sunroof;

        // Properties

        /// <summary>
        /// Gets the number of doors
        /// </summary>
        public int Doors { get { return doors; } }

        /// <summary>
        /// Gets whether or not there is a sunroof
        /// </summary>
        public bool Sunroof { get { return sunroof; } }

        // Constructor

        /// <summary>
        /// Creates a car with 4 wheels and no sunroof
        /// </summary>
        /// <param name="make">Maker</param>
        /// <param name="model">Specific model</param>
        public Car(string make, string model)
            : this(make, model, 4, false)
        {
            Console.WriteLine("CAR constructor (2 params)");
        }

        /// <summary>
        /// Makes a custom car
        /// </summary>
        /// <param name="make">Maker</param>
        /// <param name="model">Specific model</param>
        /// <param name="doors">Number of doors</param>
        /// <param name="sunroof">Does it have a sunroof?</param>
        public Car(string make, string model, int doors, bool sunroof) 
            : base(make, model)
        {
            Console.WriteLine("CAR constructor (4 params)");

            // Set up car data
            this.doors = doors;
            this.sunroof = sunroof;
        }

        // Methods

        /// <summary>
        /// Simulates opening the car's sunroof
        /// </summary>
        public void OpenSunroof()
        {
            if (sunroof)
            {
                Console.WriteLine("Sunroof has been opened");
            }
            else
            {
                Console.WriteLine("No sunroof!");
            }

        }
    }
}
