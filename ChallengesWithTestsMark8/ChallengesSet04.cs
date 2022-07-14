using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        sum += number;
                    }
                    else
                    {
                        sum -= number;
                    }
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortest = str1.Length;
            if (shortest > str2.Length)
            {
                shortest = str2.Length;
            }
            if (shortest > str3.Length)
            {
                shortest = str3.Length;
            }
            if (shortest > str4.Length)
            {
                shortest = str4.Length;
            }
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNum = number1;
            if (smallestNum > number2)
            {
                smallestNum = number2;
            }
            if (smallestNum > number3)
            {
                smallestNum = number3;
            }
            if (smallestNum > number4)
            {
                smallestNum = number4;
            }
            return smallestNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1^2 + sideLength2^2 == sideLength3^2)
            {

            }
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
