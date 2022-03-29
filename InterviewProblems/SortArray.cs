using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems
{
    internal static class SortArray
    {
        public static void SortAnArray()
        {
            int[] numbers = { 1, 2, 2, 9, 1, 2, 5, 5, 5, 5, 2 };
            int k = 3;

            Dictionary<int, int> numberFrequencies = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (numberFrequencies.ContainsKey(number))
                {
                    numberFrequencies[number] += 1;
                }
                else
                {
                    numberFrequencies.Add(number, 1);
                }
            }


            var mostFrequentNumbers = numberFrequencies.OrderByDescending(numberFrequency => numberFrequency.Value)
                                                       .Take(k)
                                                       .Select(numberFrequency => numberFrequency.Key);


            foreach (int mostFrequentNumber in mostFrequentNumbers)
            {
                Console.WriteLine(mostFrequentNumber);
            }
        }
    }
}
