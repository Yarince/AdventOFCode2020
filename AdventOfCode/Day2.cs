using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOFCode
{
    public class Day2
    {
        public void Execute1(List<string> input)
        {
            const string pattern = @"([0-9]+)(?>-)([0-9]+) ([a-zA-Z])(?>: )([a-zA-Z]+)";
            var corrrect = 0;
            foreach (var passwordInput in input)
            {
                var match = Regex.Matches(passwordInput, pattern)[0];
                int.TryParse(match.Groups[1].Value, out var min);
                int.TryParse(match.Groups[2].Value, out var max);
                char.TryParse(match.Groups[3].Value, out var character);
                var password = match.Groups[4].Value;

                var present = password.Count(c => c == character);

                if (present >= min && present <= max) corrrect++;
            }

            Console.Out.WriteLine("corrrect = {0}", corrrect);
        }

        public void Execute2(List<string> input)
        {
            const string pattern = @"([0-9]+)(?>-)([0-9]+) ([a-zA-Z])(?>: )([a-zA-Z]+)";
            var corrrect = 0;
            foreach (var passwordInput in input)
            {
                var match = Regex.Matches(passwordInput, pattern)[0];
                int.TryParse(match.Groups[1].Value, out var a);
                int.TryParse(match.Groups[2].Value, out var b);
                char.TryParse(match.Groups[3].Value, out var character);
                var password = match.Groups[4].Value;

                var aEntry = password[a-1];
                var bEntry = password[b-1];

                if (aEntry == character && bEntry != character ||
                    aEntry != character && bEntry == character)
                    corrrect++;
            }

            Console.Out.WriteLine("corrrect = {0}", corrrect);
        }
    }
}