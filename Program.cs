using System;

namespace LeePathSearchAlgorithm
{
    //TODO тесты
    class ExampleProgram
    {
        static int[,] testMap = new int[,]{
            {0,0,0,0,0,0,0},
            {0,0,1,1,0,0,1},
            {1,1,1,1,1,0,1},
            {0,0,1,0,0,0,0},
            {0,0,1,0,1,0,0},
            {0,0,0,0,1,0,0},
        };

        static void Main(string[] args)
        {
            //для иллюстрации того, как повёрнуты координаты
            DebugHelpers.PrintToConsole2DCoordinates(testMap);

            var searcher = new PathSearchLee(PathSearchLee.SearchMethod.Path4);
            var start = new PathSearchLee.Point(5, 0);
            var end = new PathSearchLee.Point(0, 6);
            var path = searcher.Search(testMap, start, end);

            if (path.Length == 0)
                Console.WriteLine("Нет пути");
            else
            {
                DebugHelpers.PrintPath(testMap, path, start, end);
                Console.WriteLine("\nПуть по шагам:");

                foreach (var step in path)
                    Console.WriteLine($"X:{step.X} Y:{step.Y}");
            }
        }
    }
}
