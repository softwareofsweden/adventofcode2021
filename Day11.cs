using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day11
    {
        public static int Flash(int[,] grid, int x, int y)
        {
            if (grid[x, y] == 999)
                return 0;
            var flashes = 1;
            grid[x, y] = 999;
            for (int yy = y - 1; yy < y + 2; yy++)
                for (int xx = x - 1; xx < x + 2; xx++)
                    if (xx >= 0 && xx <= 9 && yy >= 0 && yy <= 9)
                        if (grid[xx, yy] != 999)
                        {
                            grid[xx, yy]++;
                            if (grid[xx, yy] > 9)
                                flashes += Flash(grid, xx, yy);
                        }
            return flashes;
        }

        public static int SolveP1()
        {
            var flashes = 0;
            var lines = System.IO.File.ReadAllLines("Input\\Day11.txt");
            int[,] grid = new int[10, 10];
            for (int y = 0; y < 10; y++)
                for (int x = 0; x < 10; x++)
                    grid[x, y] = int.Parse(lines[y][x].ToString());
            for (int i = 0; i < 100; i++)
            {
                for (int y = 0; y < 10; y++)
                    for (int x = 0; x < 10; x++)
                        grid[x, y]++;
                for (int y = 0; y < 10; y++)
                    for (int x = 0; x < 10; x++)
                        if (grid[x, y] > 9)
                            flashes += Flash(grid, x, y);
                for (int y = 0; y < 10; y++)
                    for (int x = 0; x < 10; x++)
                        if (grid[x, y] > 9)
                            grid[x, y] = 0;
            }
            return flashes;
        }

        public static long SolveP2()
        {
            var flashes = 0;
            var lines = System.IO.File.ReadAllLines("Input\\Day11.txt");
            int[,] grid = new int[10, 10];
            for (int y = 0; y < 10; y++)
                for (int x = 0; x < 10; x++)
                    grid[x, y] = int.Parse(lines[y][x].ToString());
            var step = 0;
            while (true)
            {
                step++;
                var flashesBefore = flashes;
                for (int y = 0; y < 10; y++)
                    for (int x = 0; x < 10; x++)
                        grid[x, y]++;
                for (int y = 0; y < 10; y++)
                    for (int x = 0; x < 10; x++)
                        if (grid[x, y] > 9)
                            flashes += Flash(grid, x, y);
                for (int y = 0; y < 10; y++)
                    for (int x = 0; x < 10; x++)
                        if (grid[x, y] > 9)
                            grid[x, y] = 0;
                if (flashes - flashesBefore == 100)
                    return step;
            }
        }
    }
}
