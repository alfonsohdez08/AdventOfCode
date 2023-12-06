using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day6
    {
        private const string TestFileName = "day6_test_input.txt";
        private const string ProdFileName = "day6_input.txt";

        public static (long part1, long part2) Solve(bool runTestCase = true)
        {
            string[] input = File.ReadAllLines(Path.Combine(".", runTestCase ? TestFileName : ProdFileName));
            
            var times = input[0].Substring(input[0].IndexOf(':') + 1).Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var distances = input[1].Substring(input[1].IndexOf(':') + 1).Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var races = times.Zip(distances, (t, d) => (time: int.Parse(t), distance: int.Parse(d)));

            long resultPart1 = 1;
            foreach (var (time, distance) in races)
            {
                // Console.WriteLine();

                long ways = CountWays(time, distance);

                resultPart1 *= (ways == 0 ? 1 : ways);
            }

            long resultPart2 = CountWays(long.Parse(string.Join("", times)), long.Parse(string.Join("", distances)));
            return (resultPart1 == 1 ? 0 : resultPart1, resultPart2);
        }

        private static long CountWays(long time, long distance)
        {
            long ways = 0;
            for (int chargeTime = 0; chargeTime <= time; chargeTime++)
            {
                long leftTime = time - chargeTime;
                if (chargeTime * leftTime > distance)
                {
                    // Console.WriteLine("Time: {0} | Charge time / Speed: {1} | Left Time: {2} | Distance: {3}", time, chargeTime, leftTime, distance);

                    ways++;
                }
            }

            return ways;
        }
    }
}
