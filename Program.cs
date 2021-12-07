using System;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now;
            Console.WriteLine("Day   Expected      {0}{1}", "Output".PadRight(20), "Duration");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" 1.a  1752          {0}{1}", Day01.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 1.b  1781          {0}{1}", Day01.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 2.a  1427868       {0}{1}", Day02.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 2.b  1568138742    {0}{1}", Day02.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 3.a  1307354       {0}{1}", Day03.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 3.b  482500        {0}{1}", Day03.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 4.a  45031         {0}{1}", Day04.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 4.b  2568          {0}{1}", Day04.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 5.a  7142          {0}{1}", Day05.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 5.b  20012         {0}{1}", Day05.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 6.a  390923        {0}{1}", Day06.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 6.b  1749945484935 {0}{1}", Day06.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 7.a  353800        {0}{1}", Day07.SolveP1().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine(" 7.b  98119739      {0}{1}", Day07.SolveP2().ToString().PadRight(20), (DateTime.Now - start).Milliseconds);
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
