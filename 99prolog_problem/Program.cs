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
            Console.ReadLine();
        }
    }
}
