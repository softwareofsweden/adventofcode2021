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
            var data = System.IO.File.ReadAllLines("Input\\Day03.txt");
            var oxygen = data;
            var currentBit = 0;
            while (oxygen.Length > 1)
            {
                var toKeep = oxygen.Where(x => x[currentBit] == '0').Count() * 2 > oxygen.Length ? '0' : '1';
                oxygen = oxygen.Where(x => x[currentBit] == toKeep).ToArray();
                currentBit++;
            }
            var co2 = data;
            currentBit = 0;
            while (co2.Length > 1)
            {
                var toKeep = co2.Where(x => x[currentBit] == '1').Count() * 2 < co2.Length ? '1' : '0';
                co2 = co2.Where(x => x[currentBit] == toKeep).ToArray();
                currentBit++;
            }
            return Convert.ToInt32(oxygen[0], 2) * Convert.ToInt32(co2[0], 2);
        }
    }
}
