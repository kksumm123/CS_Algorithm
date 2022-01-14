using System;

namespace 하샤드수
{
    public class Solution
    {
        public bool solution(int x)
        {
            if (x < 10)
                return true;
            else
            {
                int sumResult = GetNum(x);

                if (x % sumResult == 0)
                    return true;

                return false;
            }
        }

        int GetNum(int n)
        {
            if (n != 0)
                return n % 10 + GetNum(n /= 10);

            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sum(11));

            int sum(int v)
            {
                if (v == 0)
                    return 0;

                return v % 10 + sum(v / 10);
            }
        }
    }
}
