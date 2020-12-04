using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOFCode
{
    public static class ReadInput
    {
        public static List<int> ReadInt(string file)
        {
            var scores = new List<int>();
            var reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                if (int.TryParse(reader.ReadLine(), out var score) && score != 0)
                    scores.Add(score);
            }

            return scores;
        }
        
        public static List<string> ReadStr(string file)
        {
            return File.ReadLines(file).ToList();
        }
    }
}