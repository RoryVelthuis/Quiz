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
            string playing = "y";
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
                Console.WriteLine($"Quiz complete\nYour score was {score}/{questions.Length}");
                Console.WriteLine("Do you want to take the quiz again? (Y / N)");
                playing = Console.ReadLine();

            } while (true);

        }
    }
}
