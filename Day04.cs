using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Day04
    {
        public static int SolveP1()
        {
            var data = System.IO.File.ReadAllLines("Input\\Day04.txt");
            var numbers = new Stack<int>(data[0].Split(',').Select(x => int.Parse(x)).Reverse().ToArray());
            var boards = new List<int[]>();
            for (int i = 2; i < data.Length; i += 6)
                boards.Add(String.Join(" ", data.Skip(i).Take(5)).Replace("  ", " ").Trim().Split(' ').Select(x => int.Parse(x)).ToArray());
            while (true)
            {
                var number = numbers.Pop();
                foreach (var board in boards)
                    for (int i = 0; i < 25; i++)
                        if (board[i] == number)
                        {
                            board[i] = 999;
                            var col = i % 5;
                            var row = (int)Math.Floor(i / 5f);
                            var colSum = board[col] + board[col + 5] + board[col + 10] + board[col + 15] + board[col + 20];
                            var rowSum = board[row * 5] + board[row * 5 + 1] + board[row * 5 + 2] + board[row * 5 + 3] + board[row * 5 + 4];
                            if (colSum == 999 * 5 || rowSum == 999 * 5)
                                return board.Where(x => x != 999).Sum() * number;
                            break;
                        }
            }
        }

        public static int SolveP2()
        {
            var data = System.IO.File.ReadAllLines("Input\\Day04.txt");
            var numbers = new Stack<int>(data[0].Split(',').Select(x => int.Parse(x)).Reverse().ToArray());
            var boards = new List<int[]>();
            for (int i = 2; i < data.Length; i += 6)
                boards.Add(String.Join(" ", data.Skip(i).Take(5)).Replace("  ", " ").Trim().Split(' ').Select(x => int.Parse(x)).ToArray());
            var boardsWon = new List<int>();
            var lastScore = 0;
            while (numbers.Count > 0)
            {
                var number = numbers.Pop();
                var boardIndex = -1;
                foreach (var board in boards)
                {
                    boardIndex++;
                    if (boardsWon.Contains(boardIndex))
                        continue;
                    for (int i = 0; i < 25; i++)
                        if (board[i] == number)
                        {
                            board[i] = 999;
                            var col = i % 5;
                            var row = (int)Math.Floor(i / 5f);
                            var colSum = board[col] + board[col + 5] + board[col + 10] + board[col + 15] + board[col + 20];
                            var rowSum = board[row * 5] + board[row * 5 + 1] + board[row * 5 + 2] + board[row * 5 + 3] + board[row * 5 + 4];
                            if (colSum == 999 * 5 || rowSum == 999 * 5)
                            {
                                lastScore = board.Where(x => x != 999).Sum() * number;
                                boardsWon.Add(boardIndex);
                            }
                            break;
                        }
                }
            }
            return lastScore;
        }
    }
}
