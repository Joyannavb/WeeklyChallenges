using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var count = vals.Length;
            return count % 2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 == 0 ? false : true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
                return 0;

            else
                foreach (var number in numbers)
                {
                    sum += number;
                }
                return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
                return 0;

            else
                foreach (var number in numbers)
                {
                    if (number % 2 == 0)
                        sum += number;
                }
                return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;

            if (numbers == null)
                return false;

            else

                foreach (var number in numbers)
                {
                    sum += number;
                }
                return sum % 2 != 0 ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
                return 0;
            else
                return number / 2;
        }
    }
}
