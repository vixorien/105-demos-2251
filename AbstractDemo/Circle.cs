// Chris Cascioli
// 10/29/25
// Demo of child class of an abstract parent

namespace AbstractDemo
{
	internal class Circle : Shape
	{
		// Fields
		private double radius;

		/// <summary>
		/// Gets or sets the radius (example of expression-bodied members)
		/// </summary>
		public double Radius { get => radius; set => radius = value; }

		/// <summary>
		/// Sets up a circle
		/// </summary>
		/// <param name="radius">Distance from center to edge</param>
		public Circle(double radius)
			: base("Circle")
		{
			this.radius = radius;
		}

		/// <summary>
		/// Calculates the area of this circle
		/// </summary>
		/// <returns>Pi * rad * rad</returns>
		public override double CalculateArea()
		{
			return Math.PI * radius * radius;
		}
	}
}
