using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 == 0) ? false : true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double max = 0;
            double min = 0;
            if (numbers != null)
            {
                foreach (double number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                    if (number < min)
                    {
                        min = number;
                    }
                }
            }
            return max + min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i];
                    }
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
            }
            return (sum % 2 == 0) ? false : true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number > 0) ? number / 2 : 0;
        }
    }
}
