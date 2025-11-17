// Chris Cascioli
// 11/17/25
// Example of a class that implements an interface

namespace InterfaceDemo
{
	internal class Player : IDamageable
	{
		// Fields
		private int damage;

		// Properties
		public int CurrentDamage { get { return damage; } }
		public string Name { get; private set; }

		// Constructor

		/// <summary>
		/// Creates a new player
		/// </summary>
		/// <param name="name">Unique ID</param>
		public Player(string name)
		{
			Name = name;
			damage = 0;
		}

		// Methods

		/// <summary>
		/// Increases damage on player
		/// </summary>
		/// <param name="amount">Incoming damage amount</param>
		public void TakeDamage(int amount)
		{
			damage += amount;
		}
	}
}
