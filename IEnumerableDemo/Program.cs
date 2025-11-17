// Chris Cascioli
// 11/17/25
// Demo of implementing a built-in interface

namespace IEnumerableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("A");
			list.Add("B");
			list.Add("C");
			list.Add("D");
			list.Add("E");

            foreach(string s in list)
				Console.WriteLine(s);
		}
    }
}
