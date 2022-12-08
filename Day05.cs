using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day05
    {
        class Point : IEquatable<Point>
        {
            public int X { get; init; }
            public int Y { get; init; }

            public Point()
            {
            }

            public Point(string value)
            {
                var coordinates = value.Split(',');
                X = int.Parse(coordinates[0]);
                Y = int.Parse(coordinates[1]);
            }

            public bool Equals(Point other)
            {
                return this.X == other.X && this.Y == other.Y;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(this.X, this.Y);
            }

            public override bool Equals(object obj)
            {
                return Equals(obj as Point);
            }
        }

        class Line
        {
            public Point P1 { get; }
            public Point P2 { get; }
            public bool IsStraight { get; }
            
            public Line(string value)
            {
                var points = value.Split(" -> ");
                P1 = new Point(points[0]);
                P2 = new Point(points[1]);
                IsStraight = P1.X == P2.X || P1.Y == P2.Y;
            }

            public IEnumerable<Point> GetPoints()
            {
                var result = new List<Point>();
                var steps = Math.Max(Math.Abs(P1.X - P2.X) + 1, Math.Abs(P1.Y - P2.Y) + 1);
                var dx = P1.X == P2.X ? 0 : P1.X < P2.X ? 1 : -1;
                var dy = P1.Y == P2.Y ? 0 : P1.Y < P2.Y ? 1 : -1;
                for (int i = 0; i < steps; i++)
                    result.Add(new Point() { X = P1.X + (dx * i), Y = P1.Y + (dy * i) });
                return result;
            }
        }

        public static int SolveP1()
        {
            var data = System.IO.File.ReadAllLines("Input\\Day05.txt");
            var lines = data.Select(x => new Line(x)).ToArray();
            var pointsOverlap = new Dictionary<Point, int>();
            foreach (var line in lines.Where(x => x.IsStraight))
                foreach(var point in line.GetPoints())
                    if (pointsOverlap.ContainsKey(point))
                        pointsOverlap[point]++;
                    else
                        pointsOverlap[point] = 1;
            return pointsOverlap.Values.Where(x => x > 1).Count();
        }

        public static int SolveP2()
        {
            var data = System.IO.File.ReadAllLines("Input\\Day05.txt");
            var lines = data.Select(x => new Line(x)).ToArray();
            var pointsOverlap = new Dictionary<Point, int>();
            foreach (var line in lines)
                foreach (var point in line.GetPoints())
                    if (pointsOverlap.ContainsKey(point))
                        pointsOverlap[point]++;
                    else
                        pointsOverlap[point] = 1;
            return pointsOverlap.Values.Where(x => x > 1).Count();
        }
    }
}
