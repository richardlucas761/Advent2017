namespace Advent2017_Day1
{
    public static class Solver
    {
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