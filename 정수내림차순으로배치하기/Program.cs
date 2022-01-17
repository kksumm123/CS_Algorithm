using System;
using System.Collections.Generic;

namespace 정수내림차순으로배치하기
{
    public class Solution
    {
        public long solution(long n)
        {
            var list = SplitNum(n);
            list.Sort();

            return ListToLong(list);
        }

        List<int> SplitNum(long n)
        {
            List<int> nums = new List<int>();
            while (n != 0)
            {
                int result = (int)(n % 10);

                nums.Add(result);
                n /= 10;
            }

            return nums;
        }
        long ListToLong(List<int> listInt)
        {
            long result = 0;

            for (int i = 0; i < listInt.Count; i++)
                result += (long)(listInt[i] * Math.Pow(10, i));

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
