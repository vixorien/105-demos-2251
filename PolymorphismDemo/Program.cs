// Chris Cascioli
// 10/27/25
// Example of polymorpism, overriding virtual methods and ToString()

namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create some basic objects
            Vehicle v1 = new Vehicle("basic vehicle");
            Firetruck ft1 = new Firetruck("basic firetruck");

            // Test these methods
            v1.Drive();
            ft1.Drive();
            ft1.ShootWater();
			Console.WriteLine();

            // POLYMORPHISM - Create a child object
            // but store it in a parent variable
            Vehicle v_ft = new Firetruck("polymorphic");
            v_ft.Drive();
            // v_ft.ShootWater(); // Not all vehicle can shoot water

            // Can we cast back to the more specific type?
            Firetruck ft = (Firetruck)v_ft;
            ft.ShootWater();

			Console.WriteLine();

            // Make a list of different objects
            List<Vehicle> allVehicles = new List<Vehicle>();
            allVehicles.Add(new Vehicle("v1"));
			allVehicles.Add(new Firetruck("ft1"));
			allVehicles.Add(new Vehicle("v2"));
			allVehicles.Add(new Firetruck("ft2"));

            // Loop and make each one drive
            foreach (Vehicle v in allVehicles)
            {
                // Make this vehicle drive
				Console.WriteLine();
                v.Drive();

                // If this is definitely a firetruck...
                if (v is Firetruck)
                {
                    // Attempt to cast to a firetruck
                    Firetruck tempFT = (Firetruck)v;
                    tempFT.ShootWater();
                }
            }

            // Examples of ToString()
			Console.WriteLine();
			Console.WriteLine(v1);
			Console.WriteLine(v1.ToString());
			Console.WriteLine(ft.ToString());
		}
    }
}
