// Chris Cascioli
// 10/6/25
// Example of several more OOP concepts
// (static, constructor chaining and optional params)

namespace StaticAndConstructorChainingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an enemy and display them
            Enemy e1 = new Enemy();
            Enemy e2 = new Enemy(2, 2, 'W');
            Enemy e3 = new Enemy(6, 4, 'O', ConsoleColor.Green);

            e1.Display();
            e2.Display(ConsoleColor.Red);
            e3.Display();

            // Print enemy count using a static method
            Console.WriteLine();
            Console.WriteLine("Total enemies: " + Enemy.GetEnemyCount());


        }
    }
}
