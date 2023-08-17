using System;
using System.Collections.Generic;

namespace MathQuizApp
{
    public class QuizQuestion
    {
        // only setting default value so VS stops yelling at me,
        // works perfectly fine without the default value assignment.
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
                new QuizQuestion { QuestionText = "What is 2 + 2?", CorrectAnswer = 4 },
                new QuizQuestion { QuestionText = "What is 5 - 3?", CorrectAnswer = 2 },
                // Add more math questions here...
                // user generated questions
                new QuizQuestion { QuestionText = "What is 16 - 8?", CorrectAnswer = 8 },
                new QuizQuestion { QuestionText = "What is 12 - 4?", CorrectAnswer = 8 },
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