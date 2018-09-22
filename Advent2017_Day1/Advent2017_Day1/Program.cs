using System;

namespace Advent2017_Day1
{
    public static class Program
    {
        private static void Main()
        {
            const string test1 = "1122";
            const string test2 = "1111";
            const string test3 = "1234";
            const string test4 = "91212129";

            Console.WriteLine($"{test1} = {Solver.Solve(test1)}");
            Console.WriteLine($"{test2} = {Solver.Solve(test2)}");
            Console.WriteLine($"{test3} = {Solver.Solve(test3)}");
            Console.WriteLine($"{test4} = {Solver.Solve(test4)}");
        }
    }
}