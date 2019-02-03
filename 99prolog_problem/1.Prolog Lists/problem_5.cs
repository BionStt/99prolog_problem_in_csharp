using System;
using System.Collections.Generic;
using System.Text;

namespace _99prolog_problem._1.Prolog_Lists
{
    class problem_5
    {
        public static int[] ReverseNumber(int[] numbers)
        {
            int[] reverse = new int[numbers.Length];
            int j = 0; 
            for (int i = numbers.Length -1 ; i >= 0; i--)
            {
                reverse[j] = numbers[i];
                j++;
            }
            return reverse;
        }
    }
}
