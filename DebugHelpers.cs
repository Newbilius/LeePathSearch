using System;
using System.Linq;

namespace LeePathSearchAlgorithm
{
    public static class DebugHelpers
    {
        public static void PrintToConsole2DArray(int[,] array)
        {
            var width = array.GetLength(0);
            var height = array.GetLength(1);
            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                    Console.Write($"{array[x, y],3}\t");
                Console.WriteLine();
            }
        }

        public static void PrintToConsole2DCoordinates(int[,] array)
        {
            var width = array.GetLength(0);
            var height = array.GetLength(1);
            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                    Console.Write($"{x}x{y}\t");
                Console.WriteLine();
            }
        }

        public static void PrintPath(int[,] array,
        PathSearchLee.Point[] path,
        PathSearchLee.Point start,
        PathSearchLee.Point end)
        {
            var width = array.GetLength(0);
            var height = array.GetLength(1);
            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    if (x == start.X && y == start.Y)
                    {
                        Console.Write($"STR\t");
                        continue;
                    }
                    if (x == end.X && y == end.Y)
                    {
                        Console.Write($"END\t");
                        continue;
                    }
                    if (path.Any(point => point.X == x && point.Y == y))
                    {
                        Console.Write($"===\t");
                        continue;
                    }
                    Console.Write($"{array[x, y],3}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
