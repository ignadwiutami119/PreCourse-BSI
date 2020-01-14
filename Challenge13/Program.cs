using System;

namespace PreCourse
{
    public class CountWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count("Hello")); // Output: 1
            Console.WriteLine(Count("Hello World")); // Output: 2
            Console.WriteLine(Count("Lorem ipsum dolor sit amet")); // Output: 5
        }

        public static int Count(string value)
        {
            // Make this method to be able counting words

            return value.Split(' ').Length;
        }
    }
}
