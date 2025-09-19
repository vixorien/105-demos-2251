// Chris Cascioli
// 9/15/25
// Determines which letter in a string is
// closest to the end of the alphabet

namespace LastLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sentence: ");
            Console.WriteLine(LastLetter(Console.ReadLine()!));
        }

        /// <summary>
        /// Determines which letter in a string is
        /// closest to the end of the alphabet
        /// </summary>
        /// <param name="sentence">String to check</param>
        /// <returns>
        /// Letter closest to the end of the alphabet,
        /// or '?' if the string is empty
        /// </returns>
        static char LastLetter(string sentence)
        {
            // Make sure there is any work to do
            if (sentence.Length == 0)
            {
                return '?';
            }

            // Align all character to the same case
            sentence = sentence.ToLower();

            // Best answer so far
            char last = sentence[0];
            for (int i = 0; i < sentence.Length; i++)
            {
                // Is this a better answer?
                if (sentence[i] > last)
                {
                    last = sentence[i];
                }
            }
            return last;
        }
    }
}
