using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day09
    {
        public static int SolveP1()
        {
            var sum = 0;
            var grid = System.IO.File.ReadAllLines("Input\\Day09.txt");
            var w = grid[0].Length;
            var h = grid.Count();
            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                    if ((x - 1 < 0 || (x - 1 >= 0 && grid[y][x] < grid[y][x - 1])) &&
                        (x + 1 >= w || (x + 1 < w && grid[y][x] < grid[y][x + 1])) &&
                        (y - 1 < 0 || (y - 1 >= 0 && grid[y][x] < grid[y - 1][x])) &&
                        (y + 1 >= h || (y + 1 < h && grid[y][x] < grid[y + 1][x])))
                        sum += int.Parse(grid[y][x].ToString()) + 1;
            return sum;
        }

        protected static int basinSize(List<int> chk, string[] grid, int w, int h, int x, int y)
        {
            if (x < 0 || x >= w || y < 0 || y >= h)
                return 0;
            var offset = y * w + x;
            if (chk.Contains(offset))
                return 0;
            chk.Add(offset);
            var val = int.Parse(grid[y][x].ToString());
            return val == 9 ? 0 : 1 + basinSize(chk, grid, w, h, x - 1, y) + basinSize(chk, grid, w, h, x + 1, y) + 
                basinSize(chk, grid, w, h, x, y + 1) + basinSize(chk, grid, w, h, x, y - 1);
        }

        public static int SolveP2()
        {
            var grid = System.IO.File.ReadAllLines("Input\\Day09.txt");
            var w = grid[0].Length;
            var h = grid.Length;
            var basinSizes = new List<int>();
            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                    if ((x - 1 < 0 || (x - 1 >= 0 && grid[y][x] < grid[y][x - 1])) &&
                        (x + 1 >= w || (x + 1 < w && grid[y][x] < grid[y][x + 1])) &&
                        (y - 1 < 0 || (y - 1 >= 0 && grid[y][x] < grid[y - 1][x])) &&
                        (y + 1 >= h || (y + 1 < h && grid[y][x] < grid[y + 1][x])))
                        basinSizes.Add(basinSize(new List<int>(), grid, w, h, x, y));
            basinSizes.Sort();
            basinSizes.Reverse();
            return basinSizes[0] * basinSizes[1] * basinSizes[2];
        }
    }
}
