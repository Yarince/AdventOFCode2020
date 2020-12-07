using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOFCode
{
    public class Day3
    {
        public void Execute1(List<string> input)
        {
            const int stepSize = 3;
            var map = input.Select(s => s.ToArray());

            var treeCounter = 0;
            var i = 0;
            foreach (var row in map)
            {
                i += stepSize;
                
                if (i >= row.Length) i %= stepSize;

                if (row[i] == '#')
                {
                    treeCounter++;
                    row[i] = 'X';
                }
                else
                {
                    row[i] = 'O';

                }
                
                
            }


            Console.Out.WriteLine("treeCounter = {0}", treeCounter);


            
            foreach (var row in map)
            {
                foreach (var item in row)
                {
                    Console.Out.Write(item);
                }
                Console.Out.WriteLine();
            }
        }
    }
}