using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day2
    {
        private const string TestCaseInputFilePath = ".\\test_input.txt";
        private const string InputFilePath = ".\\input.txt";

        public static int Solve(bool runTestCase = true)
        {
            string path = runTestCase ? TestCaseInputFilePath : InputFilePath;

            int sum = 0;
            foreach (string line in File.ReadAllLines(path))
            {
                Game game = Game.Parse(line);

                sum += ((game.MaxGreen == 0 ? 1 : game.MaxGreen) * (game.MaxRed == 0 ? 1 : game.MaxRed) * (game.MaxBlue == 0 ? 1 : game.MaxBlue));

                //if (game.MaxRed <= 12 && game.MaxGreen <= 13 && game.MaxBlue <= 14)
                //{
                //    sum += game.Id; // part 1
                //}
            }

            return sum;
        }
    }

    class Game
    {
        public int Id;

        public int MaxRed;
        public int MaxBlue;
        public int MaxGreen;

        private Game()
        {
        }

        public static Game Parse(string gameRecord)
        {
            var game = new Game();

            string[] gameData = gameRecord.Split(':');

            game.Id = int.Parse(gameData[0].Substring(5));

            string[] gameSets = gameData[1].Split(';');
            foreach (var gameSet in gameSets)
            {
                string[] pulledCubes = gameSet.Split(',', StringSplitOptions.RemoveEmptyEntries);
                foreach (var pulledCube in pulledCubes)
                {
                    string[] cubeData = pulledCube.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    var count = int.Parse(cubeData[0]);
                    var cube = cubeData[1].ToLower();

                    if (cube == "red")
                    {
                        game.MaxRed = Math.Max(game.MaxRed, count);
                    }else if (cube == "green")
                    {
                        game.MaxGreen = Math.Max(game.MaxGreen, count);
                    } else if (cube == "blue")
                    {
                        game.MaxBlue = Math.Max(game.MaxBlue, count);
                    }
                    else
                    {
                        throw new NotSupportedException($"The {cube} cube is not supported.");
                    }
                }
            }

            return game;
        }
    }
}
