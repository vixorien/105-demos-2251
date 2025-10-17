// Chris Cascioli
// 10/17/25
// Example class to showcase properties (which are
// C#'s version of "getters" and "setters")

namespace PropertiesDemo
{
    internal class Car
    {
        // Fields
        private string make;
        private string model;
        private string color;
        private double mileage;

        // Properties

        /// <summary>
        /// Gets or sets the owner
        /// 
        /// An example of an "auto-implemented property"
        /// which has no explicit "backing field"
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Gets the make of the car
        /// </summary>
        public string Make
        {
            get { return make; }
            private set { make = value; } // Override the access modifier
        }

        /// <summary>
        /// Gets the model of the car
        /// </summary>
        public string Model
        {
            get { return model; }
            private set { model = value; }
        }

        /// <summary>
        /// Gets or sets the mileage of the car
        /// if it is greater than the current value
        /// </summary>
        public double Mileage
        {
            get { return mileage; }
            set {
                // Extra error checking
                if (value > mileage)
                {
                    mileage = value;
                }
            }
        }

        /// <summary>
        /// Gets whether or not the car
        /// has ever been driven
        /// </summary>
        public bool HasBeenDriven
        {
            get { return mileage > 0; }
        }

        /// <summary>
        /// Gets or sets the color
        /// 
        /// An example of an "expression-bodied" property
        /// which has slightly shorter syntax.
        /// </summary>
        public string Color 
        { 
            get => color; 
            set => color = value; 
        }

        // Constructor
        /// <summary>
        /// Creates a custom car
        /// </summary>
        /// <param name="make">The maker of the car</param>
        /// <param name="model">The model</param>
        /// <param name="color">The paint color</param>
        public Car(string make, string model, string color)
        {
            Make = make;
            Model = model;
            this.Color = color;
            Mileage = 0; // We can use properties inside the class
        }

        // Methods

        /// <summary>
        /// Prints car stats
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{Color} {Make} {Model} has {Mileage} miles.");
        }
    }
}
