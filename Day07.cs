using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day07
    {
        public static int SolveP1()
        {
            int minFuel = -1;
            var positions = System.IO.File.ReadAllText("Input\\Day07.txt").Split(',').Select(x => int.Parse(x)).ToList();
            for (int i = 0; i < positions.Max(); i++)
            {
                int fuel = 0;
                for (int j = 0; j < positions.Count; j++)
                    fuel += Math.Abs(i - positions[j]);
                if (minFuel == -1 || fuel < minFuel)
                    minFuel = fuel;
            }
            return minFuel;
        }

        public static int SolveP2()
        {
            int minFuel = -1;
            var positions = System.IO.File.ReadAllText("Input\\Day07.txt").Split(',').Select(x => int.Parse(x)).ToList();
            for (int i = 0; i < positions.Max(); i++)
            {
                int fuel = 0;
                for (int j = 0; j < positions.Count; j++)
                {
                    int steps = Math.Abs(i - positions[j]);
                    fuel += steps * (steps + 1) / 2;
                }
                if (minFuel == -1 || fuel < minFuel)
                    minFuel = fuel;
            }
            return minFuel;
        }

    }
}
