using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day08
    {
        public static int SolveP1()
        {
            return String.Join("", System.IO.File.ReadAllLines("Input\\Day08.txt").Select(x => x.Split('|')[1])).Trim().Split(' ')
                .Where(x => new int[] { 2, 4, 3, 7 }.Contains(x.Length)).Count();
        }

        protected static int nbrSame(string s1, string s2)
        {
            var count = 0;
            if (s1.Length > s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                    if (s2.Contains(s1[i]))
                        count++;
            } else
            {
                for (int i = 0; i < s2.Length; i++)
                    if (s1.Contains(s2[i]))
                        count++;
            }
            return count;
        }

        public static int SolveP2()
        {
            var total = 0;
            foreach (var line in System.IO.File.ReadAllLines("Input\\Day08.txt"))
            {
                var parts = line.Split('|');
                var digits = new List<string>(parts[0].Trim().Split(' '));
                var output = parts[1].Trim().Split(' ');
                var pattern = new string[10];
                pattern[1] = digits.Where(x => x.Length == 2).First();
                pattern[4] = digits.Where(x => x.Length == 4).First();
                pattern[7] = digits.Where(x => x.Length == 3).First();
                pattern[8] = digits.Where(x => x.Length == 7).First();
                pattern[3] = digits.Where(x => x.Length == 5 && nbrSame(x, pattern[1]) == 2).First();
                digits.Remove(pattern[3]);
                pattern[9] = digits.Where(x => x.Length == 6 && nbrSame(x, pattern[3]) == 5).First();
                digits.Remove(pattern[9]);
                pattern[0] = digits.Where(x => x.Length == 6 && nbrSame(x, pattern[1]) == 2).First();
                digits.Remove(pattern[0]);
                pattern[6] = digits.Where(x => x.Length == 6).First();
                pattern[5] = digits.Where(x => x.Length == 5 && nbrSame(x, pattern[4]) == 3).First();
                digits.Remove(pattern[5]);
                pattern[2] = digits.First(x => x.Length == 5);
                var val = "";
                for (int i = 0; i < 4; i++)
                    val += pattern.ToList().FindIndex(x => x.Length == output[0].Length && nbrSame(x, output[0]) == output[0].Length).ToString();
                total += int.Parse(val);
            }
            return total;
        }
    }
}
