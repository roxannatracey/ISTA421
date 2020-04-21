using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise13HistoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var Questions = buildDB();
            var numbers = pickQuestions(Questions.Count);
            test(Questions, numbers);
        }

        private static void test(Dictionary<int, TestQuestions> Questions, List<int> numbers)
        {
            double score = 0, numProbs = numbers.Count();
            do
            {
                int n = numbers.First();
                Console.WriteLine(Questions[n]);
                Console.Write("Answer: ");
                var answer = Console.ReadLine();
                if (answer.ToLower() == Questions[n].Answer.ToLower())
                {
                    Console.WriteLine("You are correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("sorry, that is not correct");
                    Console.WriteLine($"The Correct answer is {Questions[n].Answer}");
                }
                numbers.Remove(n);
            }
            while (numbers != null && numbers.Any());
            score = (score / numProbs) * 100;
            Console.WriteLine($"Your score is: {(int)score}%");
        }

        public static Dictionary<int, TestQuestions> buildDB()
        {
            var Questions = new Dictionary<int, TestQuestions>();
            using (TextFieldParser reader = new TextFieldParser(@"C:\Users\roxan\OneDrive\Documents\OneDrive\MSSA  CLOUD APP\ISTA421\Exercises\Exercise13HistoryTest\questionsCSV.CSV"))
            {
                reader.CommentTokens = new string[] { "#" };
                reader.SetDelimiters(new string[] { "," });
                reader.HasFieldsEnclosedInQuotes = true;
                int i = 1;
                while (!reader.EndOfData)
                {
                    string[] fields = reader.ReadFields();
                    string Question = fields[0];
                    string Answer = fields[1];
                    string[] falseAs = { fields[2], fields[3], fields[4] };
                    Questions.Add(i, new TestQuestions(Question, Answer, falseAs));
                    i++;
                }
            }
            return Questions;
        }
        public static List<int> pickQuestions(int DbSize)
        {
            var rando = new Random();
            List<int> possible = Enumerable.Range(1, DbSize).ToList();
            var numbers = new List<int>();
            Console.Write($"How Many Questions do you want(1 - {DbSize})? ");
            int numQuestions = int.Parse(Console.ReadLine());
            for (int i = 0; i < numQuestions; i++)
            {
                int index = rando.Next(0, possible.Count);
                numbers.Add(possible[index]);
                possible.RemoveAt(index);
            }
            return numbers;
        }
    }
}