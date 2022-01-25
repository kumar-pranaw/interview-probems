using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems
{
    internal class LoopingConstruct
    {
        public void ReversedLoop()
        {
            string[] vs = { "pranav", "kumar", "verma" };

            for (int i = vs.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(vs[i]);
            }
        }

        public void ForwardLoop()
        {
            string[] vs = { "pranav", "kumar", "verma" };

            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);
            }
        }

        public void NestedLoop()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }
        }


    }
}
