using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day03
    {
        public static int SolveP1()
        {
            var data = System.IO.File.ReadAllLines("Input\\Day03.txt");
            var gammaBits = "";
            var epsilonBits = "";
            for (int bit = 0; bit < data[0].Length; bit++)
            {
                gammaBits += data.Where(x => x[bit] == '0').Count() * 2 > data.Length ? '0' : '1';
                epsilonBits += gammaBits[bit] == '1' ? '0' : '1';
            }
            return Convert.ToInt32(gammaBits, 2) * Convert.ToInt32(epsilonBits, 2);
        }

        public static int SolveP2()
        {
            return 0;
        }
    }
}
