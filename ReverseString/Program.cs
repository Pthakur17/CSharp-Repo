using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString;
            Console.Write("Hello, enter a string :- ");
			testString = Console.ReadLine();
            var result = ReverseString.Reverse(testString);
            Console.WriteLine("Reverse of String :- " + result);
        }
    }

     //Reverse a string
    public static class ReverseString
    {
        public static string Reverse(string x)
        {
            string result = "";
            for (int i = x.Length - 1; i >= 0; i--)
                result += x[i];
            return result;
        }
    }
}
