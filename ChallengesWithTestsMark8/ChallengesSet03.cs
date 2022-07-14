using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool val in vals)
            {
                if (val == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                foreach (int n in numbers)
                {
                    if (n % 2 != 0)
                    {
                        sum += n;
                    }
                }
                if (sum % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;
            
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i]) == true)
                {
                    hasUpper = true;
                }
                if (Char.IsLower(password[i]) == true)
                {
                    hasLower = true;
                }
                if (Char.IsNumber(password[i]) == true)
                {
                    hasNumber = true;
                }
                if (hasUpper && hasLower && hasNumber)
                {
                return true;
                }
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return char.Parse(val.Substring(0, 1));
        }

        public char GetLastLetterOfString(string val)
        {
            return char.Parse(val.Substring(val.Length-1, 1));
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddList.Add(i);
                }
            }
            int[] odds = oddList.ToArray();
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
