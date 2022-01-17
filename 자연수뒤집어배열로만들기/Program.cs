using System;
using System.Collections.Generic;

namespace 자연수뒤집어배열로만들기
{
    public class Solution
    {
        public int[] solution(long n) => SplitNumToArray(n);
        int[] SplitNumToArray(long n)
        {
            List<int> nums = new List<int>();
            while (n != 0)
            {
                int result = (int)(n % 10);

                nums.Add(result);
                n /= 10;
            }

            return nums.ToArray();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
