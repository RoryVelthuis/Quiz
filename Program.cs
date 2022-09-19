using System;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = { "How many elements are in the periodic table?","Which planet in the milky way is the hottest?" };
            string[] answers = { "118","Venus" };
            int score = 0;


            do
            {
                score = 0;
                for(int i = 0; i < questions.Length; i++)
                {
                    Console.WriteLine(questions[i]);
                    string answer = Console.ReadLine();
                    if(answer == answers[i])
                    {
                        Console.WriteLine("Correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                    Console.WriteLine($"score {score}");
                }
            } while (true);

        }
    }
}
