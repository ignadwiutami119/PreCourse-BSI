using System;

namespace PreCourse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Get your name by using Console.ReadLine()
            // Example output: "Hello, my name is Salamander.",
            // depends on user input.
            String obj = Console.ReadLine();
            string nama1 = callname(obj);
            Console.WriteLine("Hello my name is {0}", obj);
        }
        public static string callname(string str) {
            return str;
        }
    }
}
