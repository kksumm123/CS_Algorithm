using System;

namespace 정수_제곱근_판별
{
    public class Solution
    {
        public long solution(long n)
        {
            long answer = 0;

            int sqrtInt = Convert.ToInt32(Math.Sqrt(n));
            if (Math.Pow(sqrtInt, 2) == n)
            {
                answer = (long)Math.Pow(sqrtInt + 1, 2);
                return answer;
            }

            return -1;
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
