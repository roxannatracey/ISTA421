using System;

namespace MathGamesExercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            Nav();
        }

        private static void Nav()
        {
            int numRight;
            Console.WriteLine("This is a Math Game");
            Console.Write("What math problem do you want to solve? Chose from addition, subtraction, multiplication, division): ");
            var choice = Console.ReadLine().ToLower();
            Console.Write("how many problems do you want to solve? ");
            var numProbs = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (choice == "add")
                numRight = flashAdd(numProbs);
            else if (choice == "subtract")
                numRight = flashSubtract(numProbs);
            else if (choice == "multiply")
                numRight = flashMultiply(numProbs);
            else if (choice == "divide")
                numRight = flashDivide(numProbs);
            else
            {
                Console.WriteLine("invalid input");
                numRight = -1;
            }
            if (numRight == -1)
                Environment.Exit(0);
            var score = ((double)numRight / numProbs) * 100;
            score = (int)score;
            Console.WriteLine($"Your score is {score}%");
        }

        private static int flashDivide(int numProbs)
        {
            int numRight = 0;
            Console.WriteLine("division answers should be accurate out to the second decimal place");
            if (numProbs <= 0)
            {
                Console.WriteLine("Fin");
                return -1;
            }
            do
            {
                var rando = new Random();
                double one = rando.Next(1, 100);
                double two = rando.Next(1, 100);
                Console.Write($"{one} / {two} = ");
                double answer = double.Parse(Console.ReadLine());
                if (Math.Abs(answer - (one / two)) < .009)
                {
                    Console.WriteLine("Correct!");
                    numRight++;
                }
                else
                    Console.WriteLine("Incorrect!");
                numProbs--;
            }
            while (numProbs > 0);
            return numRight;
        }

        private static int flashMultiply(int numProbs)
        {
            int numRight = 0;
            if (numProbs <= 0)
            {
                Console.WriteLine("Fin!");
                return -1;
            }
            do
            {
                var rando = new Random();
                int one = rando.Next(1, 100);
                int two = rando.Next(1, 100);
                Console.Write($"{one} * {two} = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == one * two)
                {
                    Console.WriteLine("Correct!");
                    numRight++;
                }
                else
                    Console.WriteLine("Incorrect!");
                numProbs--;
            }
            while (numProbs > 0);
            return numRight;
        }

        private static int flashSubtract(int numProbs)
        {
            int numRight = 0;
            if (numProbs <= 0)
            {
                Console.WriteLine("Fin!");
                return -1;
            }
            do
            {
                var rando = new Random();
                int one = rando.Next(50, 100);
                int two = rando.Next(1, 50);
                Console.Write($"{one} - {two} = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == one - two)
                {
                    Console.WriteLine("Correct!");
                    numRight++;
                }
                else
                    Console.WriteLine("Incorrect!");
                numProbs--;
            }
            while (numProbs > 0);
            return numRight;
        }

        private static int flashAdd(int numProbs)
        {
            int numRight = 0;
            if (numProbs <= 0)
            {
                Console.WriteLine("Fin!");
                return -1;
            }
            do
            {
                var rando = new Random();
                int one = rando.Next(1, 100);
                int two = rando.Next(1, 100);
                Console.Write($"{one} + {two} = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == one + two)
                {
                    Console.WriteLine("Correct!");
                    numRight++;
                }
                else
                    Console.WriteLine("Incorrect!");
                numProbs--;
            }
            while (numProbs > 0);
            return numRight;
        }
    }
}