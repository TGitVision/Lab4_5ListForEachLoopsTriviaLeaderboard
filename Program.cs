using System;
using System.Collections.Generic;

namespace Lab4_5ListForEachLoopTriviaLeaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab4_5ListForEachLoopTriviaLeaderboard!\r\n");

            Console.WriteLine("1. Create a list that holds the scores you've been given.\r\n");
            List<int> Scores = new List<int>();
            Scores.Add(4400);
            Scores.Add(8900);
            Scores.Add(1200);
            Scores.Add(3700);
            Scores.Add(7200);

            foreach (int score in Scores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("\r\n");

            Console.WriteLine("2. Sort the scores lowest to highest and output to the screen.\r\n");
            Scores.Sort();

            foreach (int score in Scores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("\r\n");

            Console.WriteLine("3. Sort the scores highest to lowest and output to the screen.\r\n");
            Scores.Reverse();

            foreach (int score in Scores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("\r\n");

            Console.WriteLine("4. You've just been given a new score that wasn't part of the " +
                                "original list. Add the score 2400 to the list.\r\n");

            Scores.Add(2400);

            foreach (int score in Scores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("\r\n");

            Console.WriteLine("5. You've just been given a new score that wasn't part of the " +
                                "original list. Add the score 2400 to the list.\r\n");

            Scores.Add(2400);

            foreach (int score in Scores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("\r\n");

            Console.WriteLine("6. A user has closed their account and needs to have all of " +
                                " their information deleted. Remove the score 4400 from the list.\r\n");

            Scores.Remove(4400);

            foreach (int score in Scores)
            {
                Console.WriteLine(score);
            }

        }
    }
}
