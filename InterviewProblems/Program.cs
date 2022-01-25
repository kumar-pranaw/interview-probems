using System;

namespace InterviewProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseString reverseString = new ReverseString();
            Console.WriteLine(reverseString.ReverseTheString("Pranav Kumar Verma"));
            Console.WriteLine(reverseString.ReverseTheCharacter("Pranav Kumar Verma"));
            Console.ReadKey();
        }
    }

}
