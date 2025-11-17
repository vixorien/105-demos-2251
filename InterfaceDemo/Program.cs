// Chris Cascioli
// 11/17/25
// Demo of an interface being implemented in a class

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make some players
            Player p1 = new Player("Bob");
            IDamageable p2 = new Player("Pam");

            // Store them in a common structure
            List<IDamageable> targets = new List<IDamageable>();
            targets.Add(p1);
            targets.Add(p2);

            // Loop and deal damage
            foreach (IDamageable target in targets)
                target.TakeDamage(3);

			// Print out damage
			Console.WriteLine($"Player 1 has {p1.CurrentDamage} damage");
			Console.WriteLine($"Player 2 has {p2.CurrentDamage} damage");
		}
    }
}
