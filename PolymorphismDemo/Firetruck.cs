// Chris Cascioli
// 10/27/25
// Example of a polymorphic child class 

namespace PolymorphismDemo
{
	internal class Firetruck : Vehicle
	{
		/// <summary>
		/// Gets the water level of the truck
		/// </summary>
		public double WaterLevel { get; private set; }

		/// <summary>
		/// Creates a firetruck
		/// </summary>
		/// <param name="name">Name of the truck</param>
		public Firetruck(string name)
			: base(name)
		{
			WaterLevel = 1.0;
		}

		/// <summary>
		/// Overrides the parent version of Drive()
		/// with new functionality
		/// </summary>
		public override void Drive()
		{
			Console.WriteLine($"FIRETRUCK {Name} drives with the siren blaring");
		}

		/// <summary>
		/// Further override ToString() in a child class
		/// </summary>
		/// <returns>Firetruck specific details</returns>
		public override string ToString()
		{
			return base.ToString() + 
				$" This is a Firetruck with {WaterLevel * 100}% water left.";
		}

		/// <summary>
		/// Example of a method that is ONLY in
		/// the child class, not the parent
		/// </summary>
		public void ShootWater()
		{
			// Check for validity first
			if (WaterLevel < 0.1)
			{
				return;
			}

			// Shoot the water
			WaterLevel -= 0.1;
			Console.WriteLine($"Firetruck {Name} shoots water");
		}
	}
}
