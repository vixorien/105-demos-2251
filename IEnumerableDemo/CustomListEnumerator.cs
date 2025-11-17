

using System.Collections;

namespace IEnumerableDemo
{
	internal class CustomListEnumerator<T> : IEnumerator<T>
	{
		// Fields
		private CustomList<T> list;
		private int position;

		/// <summary>
		/// Creates a new enumerator for a custom list
		/// </summary>
		/// <param name="list">List to walk through</param>
		public CustomListEnumerator(CustomList<T> list)
		{
			this.list = list;
			position = -1;
		}

		/// <summary>
		/// Gets the current item in the list
		/// </summary>
		public T Current { get { return list[position]; } }

		/// <summary>
		/// Gets the current item in the list (just calls
		/// the generic version)
		/// </summary>
		object IEnumerator.Current => Current!;

		public void Dispose() { }

		public bool MoveNext()
		{
			position++;
			return position < list.Count;
		}

		public void Reset()
		{
			position = -1;
		}
	}
}
