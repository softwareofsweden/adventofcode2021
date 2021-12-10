using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day10
    {
        public static int SolveP1()
        {
            var score = 0;
            var lines = System.IO.File.ReadAllLines("Input\\Day10.txt");
            char[] openingChars = new char[] { '(', '[', '{', '<' };
            char[] closingChars = new char[] { ')', ']', '}', '>' };
            int[] scores = new int[] { 3, 57, 1197, 25137 };
            foreach (var line in lines)
            {
                var opened = new Stack<char>();
                for (int i = 0; i < line.Length; i++)
                {
                    if (closingChars.Contains(line[i]))
                    {
                        var closeIdx = Array.IndexOf(closingChars, line[i]);
                        var openIdx = Array.IndexOf(openingChars, opened.Pop());
                        if (closeIdx != openIdx)
                        {
                            score += scores[closeIdx];
                            break;
                        }
                    }
                    else
                        opened.Push(line[i]);
                }
            }
            return score;
        }

        public static long SolveP2()
        {
            var allScores = new List<long>();
            var lines = System.IO.File.ReadAllLines("Input\\Day10.txt");
            char[] openingChars = new char[] { '(', '[', '{', '<' };
            char[] closingChars = new char[] { ')', ']', '}', '>' };
            foreach (var line in lines)
            {
                var isCorrupt = false;
                var opened = new Stack<char>();
                for (int i = 0; i < line.Length; i++)
                {
                    if (closingChars.Contains(line[i]))
                    {
                        if (Array.IndexOf(closingChars, line[i]) != Array.IndexOf(openingChars, opened.Pop()))
                        {
                            isCorrupt = true;
                            break;
                        }
                    }
                    else
                        opened.Push(line[i]);
                }
                if (!isCorrupt)
                {
                    long score = 0;
                    while (opened.TryPop(out char c))
                        score = (score * 5) + Array.IndexOf(openingChars, c) + 1;
                    allScores.Add(score);
                }
            }
            allScores.Sort();
            return allScores[(int)Math.Floor(allScores.Count / 2d) ];
        }
    }
}
