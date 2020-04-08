using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise12A
{
    class Program
    {
        static void main (int[] args)
        {
            // // Print the even numbers in a list — 10 pts
            // int[] n1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //IEnumerable<int> numbers = n1.Where(n => n%2 == 0 );
            // foreach (int n in numbers)
            //     Console.WriteLine(n);
            // //  Print the positive numbers in a list — 20 pts
            // int[] n2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            // IEnumerable<int> Positivenumbers = n1.Where(n => n > 0).Where(n => n < 12);
            // foreach (int n in numbers)
            //     Console.WriteLine(n);
            // Given the list below print all the integers and their squares where the square of the integer is greater than
            // 20. For example, this will ot include 4(square is 16) but will include 5(square is 25)
            //int[] n3 =  { 3, 9, 2, 8, 6, 5 }; // 5, 6, 7, 8, 9 
            //IEnumerable<int> square = n3.Select(n => n).Where(n => n*n > 20);
            //foreach (int n in square)
            //    Console.WriteLine($"Number = {n}. SqrNo = {n * n}");
            // Number of times a digit appears — 40 pts
            // Given the list below print a report listing each digit and the number of times that digit appears in the list.
            int[] n4 =  { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            IEnumerable<int>  counting = n4.GroupBy(n => n).Where(n => n.Count()==4).First();
            foreach (int n in n4)  
             Console.WriteLine($" Number {n4} appears {counting} times");

        }
    }
}

