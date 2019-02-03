using _99prolog_problem._1.Prolog_Lists;
using System;
using System.Collections.Generic;

namespace _99prolog_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine(problem_1.FindLastElementFromList(numbers));
            Console.WriteLine(problem_2.FindSecondLastElement(numbers));
            Console.WriteLine(problem_3.FindKthElement(numbers, 5));
            Console.WriteLine(problem_4.NumberCount(numbers));
            problem_5.ReverseNumber(numbers);
            //var reverseNumber = problem_5.ReverseNumber(numbers);
            //for (int i = 0; i < reverseNumber.Length; i++)
            //{
            //    Console.WriteLine(reverseNumber[i]);
            //}

            Console.ReadLine();
        }
    }
}
