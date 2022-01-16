using System;

namespace 최대공약수와최소공배수
{
    public class Solution
    {
        public int[] solution(int n, int m)
        {
            var gcd = GCD(n, m);
            return new int[] { gcd, n * m / gcd }; ;
        }

        int GCD(int a, int b)
        {
            while (b != 0)
            {
                var result = a % b;
                a = b;
                b = result;
            }
            return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 % 12);
        }
    }
}
