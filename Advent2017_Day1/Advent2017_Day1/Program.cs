using System;

namespace Advent2017_Day1
{
    public static class Program
    {
        private static void Main()
        {
            const string test1 = "1122";

            Console.WriteLine($"{test1} = {Solver.Solve(test1)}");
        }
    }
}