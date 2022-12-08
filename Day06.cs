using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day06
    {
        public static int SolveP1()
        {
            var fish = System.IO.File.ReadAllText("Input\\Day06.txt").Split(',').Select(x => int.Parse(x)).ToList();
            for (int i = 0; i < 80; i++)
            {
                var newFish = new List<int>();
                for (int j = 0; j < fish.Count; j++)
                {
                    fish[j]--;
                    if (fish[j] == -1)
                    {
                        fish[j] = 6;
                        newFish.Add(8);
                    }
                }
                fish.AddRange(newFish);
            }
            return fish.Count;
        }

        public static long SolveP2()
        {
            var fish = System.IO.File.ReadAllText("Input\\Day06.txt").Split(',').Select(x => int.Parse(x));
            var fishCountByAge = new long[10];
            for (int i = 0; i < 10; i++)
                fishCountByAge[i] = fish.Where(x => x == i).Count();
            for (int i = 0; i < 256; i++)
            {
                fishCountByAge[9] = fishCountByAge[0];
                fishCountByAge[7] += fishCountByAge[0];
                for (int j = 0; j < 9; j++)
                    fishCountByAge[j] = fishCountByAge[j + 1];
            }
            fishCountByAge[9] = 0;
            return fishCountByAge.Sum();
        }
    }
}
