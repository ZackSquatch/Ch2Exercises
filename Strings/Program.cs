using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversations.'";
            string searchTerm;

            Console.WriteLine(firstSentence);
            Console.WriteLine("Enter search term: ");

            searchTerm = Console.ReadLine().ToLower();

            bool found = firstSentence.ToLower().Contains(searchTerm);

            Console.WriteLine(found);

            int foundIndex = firstSentence.ToLower().IndexOf(searchTerm);

            Console.WriteLine(foundIndex);
            Console.WriteLine(searchTerm.Length);
            Console.WriteLine(firstSentence.Remove(foundIndex, searchTerm.Length));
        }
    }
}
