// Chris Cascioli
// 10/27/25
// Basic parent class

namespace PolymorphismDemo
{
	internal class Vehicle
	{
		/// <summary>
		/// Gets the name of the vehicle
		/// Example of an auto-implemented property.
		/// Notice the lack of explicit field
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// Creates a vehicle
		/// </summary>
		/// <param name="name">Name of the vehicle</param>
		public Vehicle(string name)
		{
			Name = name;
		}

		/// <summary>
		/// Simulates the vehicle driving
		/// </summary>
		public virtual void Drive()
		{
			Console.WriteLine($"VEHICLE {Name} is driving");
		}

		/// <summary>
		/// Override the built-in ToString()
		/// </summary>
		/// <returns>String representation</returns>
		public override string ToString()
		{
			return $"VEHICLE named {Name}.";
		}
	}
}
