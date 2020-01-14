using System;

namespace PreCourse
{
    public class Uppercase
    {
        static void Main(string[] args)
        {
            // Create a progam that be able to
            // transform all string into uppercase.

            // >> dotnet run okeoke
            
            Console.Write(cekUpper("abcde"));
        }

       public static string cekUpper(string kata) {
            return kata.ToUpper();
        }
    }
}
