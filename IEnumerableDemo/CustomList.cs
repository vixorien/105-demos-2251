// Chris Cascioli
// 11/17/25
// Example of a custom list implementing IEnumerable<T>

using System.Collections;

namespace IEnumerableDemo
{
	internal class CustomList<T> : IEnumerable<T>
	{
		// Fields
		private T[] data;

		// Properties

		/// <summary>
		/// Gets the count data in the list
		/// </summary>
		public int Count { get; private set; }

		/// <summary>
		/// Gets the size of the internal array
		/// </summary>
		public int Capacity { get { return data.Length; } }

		/// <summary>
		/// Gets or sets the data at index.
		/// 
		/// NOTE: SHOULD REALLY DO ERROR CHECKING!
		/// </summary>
		/// <param name="index">Index into list</param>
		/// <returns>Data at index</returns>
		public T this[int index]
		{
			get { return data[index]; }
			set { data[index] = value; }
		}

		public IEnumerator<T> GetEnumerator()
		{
			return new CustomListEnumerator<T>(this);
		}

		/// <summary>
		/// Gets the generic enumerator
		/// </summary>
		/// <returns>An enumerator for a custom list</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		// Constructor

		/// <summary>
		/// Creates a new list of capacity 4
		/// </summary>
		public CustomList()
		{
			data = new T[4];
			Count = 0;
		}

		// Methods

		/// <summary>
		/// Adds an item at the end of the list
		/// </summary>
		/// <param name="item">Data to add</param>
		public void Add(T item)
		{
			ResizeIfNecessary();

			data[Count] = item;
			Count++;
		}

		/// <summary>
		/// Resizes internal array if full
		/// </summary>
		private void ResizeIfNecessary()
		{
			if (Capacity > Count)
				return;

			T[] bigger = new T[Capacity * 2];
			for (int i = 0; i < Count; i++)
				bigger[i] = data[i];

			data = bigger;
		}

	}
}
