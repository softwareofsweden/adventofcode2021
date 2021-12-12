using System;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day   Expected      {0}{1}", "Output".PadRight(20), "Duration");
            Console.WriteLine("--------------------------------------------------");
            var start = DateTime.Now;
            Console.WriteLine(" 1.a  1752          {0}{1}", Day01.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 1.b  1781          {0}{1}", Day01.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 2.a  1427868       {0}{1}", Day02.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 2.b  1568138742    {0}{1}", Day02.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 3.a  1307354       {0}{1}", Day03.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 3.b  482500        {0}{1}", Day03.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 4.a  45031         {0}{1}", Day04.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 4.b  2568          {0}{1}", Day04.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 5.a  7142          {0}{1}", Day05.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 5.b  20012         {0}{1}", Day05.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 6.a  390923        {0}{1}", Day06.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 6.b  1749945484935 {0}{1}", Day06.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 7.a  353800        {0}{1}", Day07.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 7.b  98119739      {0}{1}", Day07.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 8.a  303           {0}{1}", Day08.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 8.b  961734        {0}{1}", Day08.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 9.a  514           {0}{1}", Day09.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine(" 9.b  1103130       {0}{1}", Day09.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine("10.a  436497        {0}{1}", Day10.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine("10.b  2377613374    {0}{1}", Day10.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine("11.a  1615          {0}{1}", Day11.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine("11.b  249           {0}{1}", Day11.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            start = DateTime.Now;
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
