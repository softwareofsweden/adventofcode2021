using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day02
    {
        public static int SolveP1()
        {
            var instructions = System.IO.File.ReadAllLines("Input\\Day02.txt");
            var h = 0;
            var d = 0;
            for (int i = 0; i < instructions.Length; i++)
            {
                var p = instructions[i].Split(' ');
                switch (p[0]) {
                    case "forward":
                        h += int.Parse(p[1]);
                        break;
                    case "up":
                        d -= int.Parse(p[1]);
                        break;
                    case "down":
                        d += int.Parse(p[1]);
                        break;
                }
            }
            return h * d;
        }

        public static int SolveP2()
        {
            var instructions = System.IO.File.ReadAllLines("Input\\Day02.txt");
            var a = 0;
            var h = 0;
            var d = 0;
            for (int i = 0; i < instructions.Length; i++)
            {
                var p = instructions[i].Split(' ');
                switch (p[0])
                {
                    case "forward":
                        h += int.Parse(p[1]);
                        d += a * int.Parse(p[1]);
                        break;
                    case "up":
                        a -= int.Parse(p[1]);
                        break;
                    case "down":
                        a += int.Parse(p[1]);
                        break;
                }
            }
            return h * d;
        }
    }
}
