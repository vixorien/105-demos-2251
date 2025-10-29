// Chris Cascioli
// 10/29/25
// Demo of abstract classes and methods

namespace AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make a list of all potential shapes
            List<Shape> allShapes = new List<Shape>();
            allShapes.Add(new Circle(1.0));
			allShapes.Add(new Circle(5.0));
			allShapes.Add(new Circle(1234.0));

            // Loop and print areas
            foreach (Shape s in allShapes)
            {
				Console.WriteLine($"Shape {s.Name} has area {s.CalculateArea()}");
            }
		}
    }
}
