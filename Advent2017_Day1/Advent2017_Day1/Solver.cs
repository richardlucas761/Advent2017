using System;
using System.Linq;

namespace Advent2017
{
    public static class Solver
    {
        public static int SolveDay2(string spreadsheet)
        {
            return spreadsheet.Split(Environment.NewLine).Sum(CheckSumForRow);
        }

        public static int CheckSumForRow(string row)
        {
            // Nothing found in the row so the difference between the highest and lowest values is 0
            if (string.IsNullOrEmpty(row))
            {
                return 0;
            }

            // Only white space found in the row so the difference between highest and lowest is 0
            if (string.IsNullOrWhiteSpace(row))
            {
                return 0;
            }

            // Determine highest and lowest values in this row
            var highest = int.MinValue;
            var lowest = int.MaxValue;

            foreach (var number in row.Split('\t'))
            {
                var numberInt = Convert.ToInt16(number);

                if (Convert.ToInt16(numberInt) > highest)
                {
                    highest = numberInt;
                }

                if (Convert.ToInt16(numberInt) < lowest)
                {
                    lowest = numberInt;
                }
            }

            return highest - lowest;
        }

        public static int SolveDay1Part2(string puzzle)
        {
            var sum = 0;

            for (var i = 0; i < puzzle.Length; i++)
            {
                var offset = puzzle.Length / 2;

                if (i + offset > puzzle.Length - 1)
                {
                    offset = offset * -1;
                }

                if (puzzle[i] == puzzle[i + offset])
                {
                    sum = UpdateSum(puzzle, sum, i);
                }
            }

            return sum;
        }

        public static int SolveDay1Part1(string puzzle)
        {
            var sum = 0;

            for (var i = 0; i < puzzle.Length; i++)
            {
                if (i + 1 == puzzle.Length)
                {
                    if (puzzle[i] == puzzle[0])
                    {
                        sum = UpdateSum(puzzle, sum, i);
                    }
                }
                else
                {
                    if (puzzle[i] == puzzle[i + 1])
                    {
                        sum = UpdateSum(puzzle, sum, i);
                    }
                }
            }

            return sum;
        }

        private static int UpdateSum(string puzzle, int sum, int i)
        {
            sum = (int) (sum + char.GetNumericValue(puzzle[i]));
            return sum;
        }
    }
}