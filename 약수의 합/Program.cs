using System;

namespace 약수의_합
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            for (int i = 1; i <= n; i++)
            {
                var r = n % i;
                if (r == 0)
                    answer += i;
            }

            return answer;
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
