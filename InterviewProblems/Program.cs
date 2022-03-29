using System;

namespace InterviewProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] arr = new [] { 5, 6,4, 5};

            int sum = 0;
            Array.ForEach(arr, delegate (int i) { sum += i; });
            Console.WriteLine($@"Sum of the {arr.Length} numbers is {sum}");

            //LoopingConstructs looping = new LoopingConstructs();
            //looping.SortAnArray();




            //looping.ReversedLoop();
            // looping.ForwardLoop();
            //looping.NestedLoop();
            //SortArray.SortAnArray();
            //ReverseString reverseString = new ReverseString();
            //Console.WriteLine(reverseString.ReverseTheString("Pranav Kumar Verma"));
            //Console.WriteLine(reverseString.ReverseTheCharacter("Pranav Kumar Verma"));
            Console.ReadKey();
        }
    }

    internal class LoopingConstructs
    {
        public virtual void SortAnArray()
        {
            Console.WriteLine("Parent");
        }
    }

    internal class Looping: LoopingConstructs
    {
        public override void SortAnArray()
        {
            Console.WriteLine("Child");
        }
    }

}
