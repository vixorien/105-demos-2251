// Chris Cascioli
// 10/29/25
// Demo of an abstract base class

namespace AbstractDemo
{
	/// <summary>
	/// Abstract classes...
	///  - Can (and must) be inherited
	///  - Can NOT be instantiated
	/// </summary>
	internal abstract class Shape
	{
		// Fields
		private string name;

		// Properties
		public string Name {
			get { return name; } 
			private set { name = value; } 
		}

		/// <summary>
		/// Sets up a shape
		/// </summary>
		/// <param name="name">Name of the shape</param>
		public Shape(string name)
		{
			this.name = name;
		}

		/// <summary>
		/// Abstract methods have NO method body
		/// - They are just a signature/declaration
		/// </summary>
		/// <returns>Area of a shape</returns>
		public abstract double CalculateArea();

		/// <summary>
		/// Abstract classes can also have regular methods
		/// </summary>
		public void Print()
		{
			Console.WriteLine("This is fine!");
		}
	}
}
