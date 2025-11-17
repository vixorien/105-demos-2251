// Chris Cascioli
// 11/17/25
// Example of a basic interface

namespace InterfaceDemo
{
	internal interface IDamageable
	{
		/// <summary>
		/// Gets the current damage marked on the object
		/// </summary>
		int CurrentDamage { get; }

		/// <summary>
		/// Adds damage to the object
		/// </summary>
		/// <param name="amount">Amount to add</param>
		void TakeDamage(int amount);
	}
}
