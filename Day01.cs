using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day01
    {
        public static int SolveP1()
        {
            var numbers = System.IO.File.ReadAllLines("Input\\Day01.txt").Select(x => int.Parse(x)).ToArray();
            var result = 0;
            for (int i = 1; i < numbers.Length; i++)
                if (numbers[i] > numbers[i - 1])
                    result++;
            return result;
        }

        public static int SolveP2()
        {
            var numbers = System.IO.File.ReadAllLines("Input\\Day01.txt").Select(x => int.Parse(x)).ToArray();
            var result = 0;
            for (int i = 1; i < numbers.Length; i++)
                if (i + 2 < numbers.Length)
                    if (numbers[i] + numbers[i + 1] + numbers[i + 2] > numbers[i - 1] + numbers[i] + numbers[i + 1])
                        result++;
            return result;
        }
    }
}
