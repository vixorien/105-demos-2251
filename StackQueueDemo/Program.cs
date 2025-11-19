// Chris Cascioli
// 11/19/25
// Stack and queue demo

namespace StackQueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a generic stack
            Stack<string> stack = new Stack<string>();

            // Add some data
            stack.Push("A");
			stack.Push("B");
			stack.Push("C");
			stack.Push("D");

			// Print out the top element
			Console.WriteLine("Top of stack: " + stack.Peek());
			Console.WriteLine();

			// Remove and print
			Console.WriteLine("Removing: " + stack.Pop());
			Console.WriteLine("Top of stack: " + stack.Peek());
			Console.WriteLine();

			// -----

			Queue<string> names = new Queue<string>();

			names.Enqueue("Bob");
			names.Enqueue("Pam");
			names.Enqueue("Jim");

			Console.WriteLine("Front of the queue: " + names.Peek());
			Console.WriteLine();

			Console.WriteLine("Removing: " + names.Dequeue());
			Console.WriteLine("Front of the queue: " + names.Peek());

		}
    }
}
