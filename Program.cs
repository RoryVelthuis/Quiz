using System;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = { "How many elements are in the periodic table?" };
            string[] answers = { "118" };
            int score = 0;

            do
            {
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
                }
            } while (true);

        }
    }
}
