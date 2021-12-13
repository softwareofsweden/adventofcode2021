using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day12
    {
        class Cave
        {
            public string Name { get; set; }

            public IList<Cave> Connections { get; set; }

            public Cave(string name)
            {
                Name = name;
                Connections = new List<Cave>();
            }

            public void AddConnection(Cave other)
            {
                if (!Connections.Contains(other))
                    Connections.Add(other);
            }

            public bool IsSmall
            {
                get
                {
                    return Name.ToLower() == Name;
                }
            }
        }

        static int Navigate(Cave cave, List<Cave> visited)
        {
            var total = 0;
            if (cave.Name == "end")
                return 1;
            if (cave.IsSmall && visited.Contains(cave))
                return 0;
            visited.Add(cave);
            foreach (var connectedCave in cave.Connections)
            {
                var newVisited = new List<Cave>();
                newVisited.AddRange(visited);
                total += Navigate(connectedCave, newVisited);
            }
            return total;
        }

        public static int SolveP1()
        {
            var lines = System.IO.File.ReadAllLines("Input\\Day12.txt");
            var caves = new List<Cave>();
            foreach (var line in lines)
            {
                var parts = line.Split('-');
                var caveName1 = parts[0];
                var caveName2 = parts[1];
                var cave1 = caves.FirstOrDefault(x => x.Name == caveName1);
                if (cave1 == null)
                {
                    cave1 = new Cave(caveName1);
                    caves.Add(cave1);
                }
                var cave2 = caves.FirstOrDefault(x => x.Name == caveName2);
                if (cave2 == null)
                {
                    cave2 = new Cave(caveName2);
                    caves.Add(cave2);
                }
                cave1.AddConnection(cave2);
                cave2.AddConnection(cave1);
                
            }
            return Navigate(caves.First(x => x.Name == "start"), new List<Cave>());
        }

        static int Navigate2(Cave cave, List<Cave> visited)
        {
            var total = 0;
            if (cave.Name == "end")
                return 1;
            if (cave.IsSmall)
            {
                var max = visited.Any(x => x.IsSmall && visited.Where(y => y == x).Count() > 1) ? 1 : 2;
                var maxVisits = (cave.Name == "start" || cave.Name == "end") ? 1 : max;
                if (visited.Where(x => x == cave).Count() > maxVisits - 1)
                    return 0;
            }
            visited.Add(cave);
            foreach (var connectedCave in cave.Connections)
            {
                var newVisited = new List<Cave>();
                newVisited.AddRange(visited);
                total += Navigate2(connectedCave, newVisited);
            }
            return total;
        }

        public static long SolveP2()
        {
            var lines = System.IO.File.ReadAllLines("Input\\Day12.txt");
            var caves = new List<Cave>();
            foreach (var line in lines)
            {
                var parts = line.Split('-');
                var caveName1 = parts[0];
                var caveName2 = parts[1];
                var cave1 = caves.FirstOrDefault(x => x.Name == caveName1);
                if (cave1 == null)
                {
                    cave1 = new Cave(caveName1);
                    caves.Add(cave1);
                }
                var cave2 = caves.FirstOrDefault(x => x.Name == caveName2);
                if (cave2 == null)
                {
                    cave2 = new Cave(caveName2);
                    caves.Add(cave2);
                }
                cave1.AddConnection(cave2);
                cave2.AddConnection(cave1);
            }
            return Navigate2(caves.First(x => x.Name == "start"), new List<Cave>());
        }
    }
}
