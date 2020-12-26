using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace i.EncodingError
{
    class EncodingError
    {
        static void Main(string[] args)
        {
            string input = Input.GetInput(9);
            List<long> parsedInput = input.Split("\n").Select(i => long.Parse(i)).ToList();
            HashSet<long> sumCache = new HashSet<long>();
            long invalidValue = 0;
            for (int i = 0; i < parsedInput.Count-26; i++)
            {
                sumCache.Clear();
                long checkVal = parsedInput.Skip(i + 25).First();
                List<long> checkRange = parsedInput.Skip(i).Take(25).ToList();
                bool valid = CheckValid(sumCache, checkRange, checkVal);
                if (!valid)
                {
                    invalidValue = checkVal;
                    Console.WriteLine($"{checkVal} is invalid!");
                    break;
                }
            }

            List<long> contiguousSum = FindContiguous(invalidValue, parsedInput);
            var ordered = contiguousSum.OrderByDescending( itm => itm);
            var answerPartTwo = ordered.First() + ordered.Last();
            Console.WriteLine($"Answer to part two is {answerPartTwo}");
        }

        private static List<long> FindContiguous(long target, List<long> numbers)
        {
            long sum;
            List<long> nums = new List<long>();
            for (int i = 0; i < numbers.Count; i++)
            {
                sum = 0;
                nums.Clear();
                for (int j = i; j < numbers.Count; j++)
                {
                    sum += numbers[j];
                    nums.Add(numbers[j]);
                    if (sum == target)
                    {
                        return nums;
                    }
                    if (sum > target)
                    {
                        break;
                    }
                }
            }
            return new List<long>();
        }

        private static bool CheckValid(HashSet<long> sumList, List<long> previousNumbers, long next)
        {
            sumList.Clear();
            for (int i = 0; i < previousNumbers.Count; i++)
            {
                for (int j = 0; j < previousNumbers.Count; j++)
                {
                    if (i == j) continue;
                    long sum = previousNumbers[i] + previousNumbers[j];
                    if (!sumList.Contains(sum))
                    {
                        sumList.Add(sum);
                    }
                }
            }
            return sumList.Contains(next);
        }
    }
}