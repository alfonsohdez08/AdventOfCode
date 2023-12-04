namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int answerPart1 = Day1.SolvePart1(false);

            //Console.WriteLine(answerPart1);

            //int answerPart2 = Day1.SolvePart2(false);
            //Console.WriteLine(answerPart2);

            //var (part1, part2) = Day3.Solve(false);
            //Console.WriteLine(part1);
            //Console.WriteLine(part2);

            var answer = Day4.Solve(false);
            
            Console.WriteLine(answer.part1);
            Console.WriteLine(answer.part2);

            Console.ReadKey();
        }
    }
}
