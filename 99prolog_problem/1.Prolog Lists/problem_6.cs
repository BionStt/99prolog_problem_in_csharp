using System;
using System.Collections.Generic;
using System.Text;

namespace _99prolog_problem._1.Prolog_Lists
{
    class problem_6
    {
        public static bool IsPalindrome(int[] numbers)
        {
            bool isPalindrome = false;
            var reverse = problem_5.ReverseNumber(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (reverse[i] == numbers[i])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                }
                   
                
            }
            return isPalindrome;
        }
    }
}
