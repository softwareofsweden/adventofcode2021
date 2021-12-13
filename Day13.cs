using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day13
    {
        public static int SolveP1()
        {
            var lines = System.IO.File.ReadAllLines("Input\\Day13.txt");
            var dots = new List<string>();
            var instructions = new List<string>();
            var dotsSection = true;
            var maxx = 0;
            var maxy = 0;
            foreach (var line in lines)
            {
                if (line == "")
                    dotsSection = false;
                else
                {
                    if (dotsSection)
                    {
                        var coordinate = line.Split(',');
                        var x = int.Parse(coordinate[0]);
                        var y = int.Parse(coordinate[1]);
                        if (x > maxx)
                            maxx = x;
                        if (y > maxy)
                            maxy = y;
                        dots.Add(line);
                    }
                    else
                        instructions.Add(line);
                }
            }
            var w = maxx + 1;
            var h = maxy + 1;
            int[,] grid = new int[w, h];
            foreach (var dot in dots)
            {
                var coordinate = dot.Split(',');
                var x = int.Parse(coordinate[0]);
                var y = int.Parse(coordinate[1]);
                grid[x, y] = 1;
            }
            foreach (var instruction in instructions)
            {
                var parts = instruction.Split("along ")[1].Split('=');
                var dir = parts[0];
                var pos = int.Parse(parts[1]);
                if (dir == "y")
                {
                    var offset = 0;
                    for (int y = pos; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            grid[x, pos - offset] = grid[x, pos - offset] + grid[x, y];
                            grid[x, y] = 0;
                        }
                        offset++;
                    }
                }
                else
                {
                    var offset = 0;
                    for (int x = pos; x < w; x++)
                    {
                        for (int y = 0; y < h; y++)
                        {
                            grid[pos - offset, y] = grid[pos - offset, y] + grid[x, y];
                            grid[x, y] = 0;
                        }
                        offset++;
                    }
                }
                break;
            }
            var count = 0;
            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                    if (grid[x, y] > 0)
                        count++;
            return count;
        }

        public static long SolveP2()
        {
            var lines = System.IO.File.ReadAllLines("Input\\Day13.txt");
            var dots = new List<string>();
            var instructions = new List<string>();
            var dotsSection = true;
            var maxx = 0;
            var maxy = 0;
            foreach (var line in lines)
            {
                if (line == "")
                    dotsSection = false;
                else
                {
                    if (dotsSection)
                    {
                        var coordinate = line.Split(',');
                        var x = int.Parse(coordinate[0]);
                        var y = int.Parse(coordinate[1]);
                        if (x > maxx)
                            maxx = x;
                        if (y > maxy)
                            maxy = y;
                        dots.Add(line);
                    }
                    else
                        instructions.Add(line);
                }
            }
            var w = maxx + 1;
            var h = maxy + 1;
            int[,] grid = new int[w, h];
            foreach (var dot in dots)
            {
                var coordinate = dot.Split(',');
                var x = int.Parse(coordinate[0]);
                var y = int.Parse(coordinate[1]);
                grid[x, y] = 1;
            }
            foreach (var instruction in instructions)
            {
                var parts = instruction.Split("along ")[1].Split('=');
                var dir = parts[0];
                var pos = int.Parse(parts[1]);
                if (dir == "y")
                {
                    var offset = 0;
                    for (int y = pos; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            grid[x, pos - offset] = Math.Min(1, grid[x, pos - offset] + grid[x, y]);
                            grid[x, y] = 0;
                        }
                        offset++;
                    }
                }
                else
                {
                    var offset = 0;
                    for (int x = pos; x < w; x++)
                    {
                        for (int y = 0; y < h; y++)
                        {
                            grid[pos - offset, y] = Math.Min(1, grid[pos - offset, y] + grid[x, y]);
                            grid[x, y] = 0;
                        }
                        offset++;
                    }
                }
                var nw = 0;
                var nh = 0;
                for (int y = 0; y < h; y++)
                    for (int x = 0; x < w; x++)
                        if (grid[x, y] > 0)
                        {
                            if (x > nw)
                                nw = x;
                            if (y > nh)
                                nh = y;
                        }
                nw++;
                nh++;
                w = nw;
                h = nh;
            }
            Console.WriteLine("");
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                    Console.Write(grid[x, y] == 1 ? "[]" : "  ");
                Console.WriteLine("");
            }
            Console.WriteLine("");
            return 0;
        }
    }
}
