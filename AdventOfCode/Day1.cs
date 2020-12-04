using System;
using System.Collections.Generic;

namespace AdventOFCode
{
    class Day1
    {
        public void Execute1(List<int> input)
        {
            foreach (var a in input)
            {
                foreach (var b in input)
                {
                    if (a + b == 2020)
                    {
                        Console.Out.WriteLine("result1 = {0}", a * b);
                        return;
                    }
                }
            }
        }

        public void Execute2(List<int> input)
        {
            foreach (var a in input)
            {
                foreach (var b in input)
                {
                    foreach (var c in input)
                    {
                        if (a + b + c == 2020)
                        {
                            Console.Out.WriteLine("result2 = {0}", a * b * c);
                            return;
                        }
                    }
                }
            }
        }
    }
}