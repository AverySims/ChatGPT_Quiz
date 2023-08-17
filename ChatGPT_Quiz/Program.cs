using System;
using System.Collections.Generic;

namespace MathQuizApp
{
    public class QuizQuestion
    {
        // only setting default value so VS stops yelling at me,
        // works perfectly fine without the default value assignment.
        // test comment
        public string QuestionText { get; set; } = "Question: ";
        public int CorrectAnswer { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<QuizQuestion> mathQuestions = new List<QuizQuestion>
            {
                // GPT generated questions
                new QuizQuestion { QuestionText = "What is 9 + 10?", CorrectAnswer = 19 },
                new QuizQuestion { QuestionText = "What is 50 x 3 ?", CorrectAnswer = 150 },
                // Add more math questions here...
                // user generated questions
                new QuizQuestion { QuestionText = "What is 3 / 1?", CorrectAnswer = 3 },
                new QuizQuestion { QuestionText = "What is 128 x 2?", CorrectAnswer = 256 },
            };

            Console.WriteLine("Welcome to the Math Quiz!");

            foreach (var question in mathQuestions)
            {
                Console.WriteLine(question.QuestionText);

                Console.Write("Enter your answer: ");
                int userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == question.CorrectAnswer)
                {
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is: " + question.CorrectAnswer + "\n");
                }
            }

            Console.WriteLine("Math Quiz completed!");
        }
    }
}