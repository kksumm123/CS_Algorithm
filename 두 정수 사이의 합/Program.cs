using System;

namespace 두_정수_사이의_합
{
    public class Solution
    {
        public long solution(int a, int b)
        {
            if (a < b)
                return SumBetween(a, b);
            else if (a > b)
                return SumBetween(b, a);
            else
                return a;

        }
        long SumBetween(int x, int y)
        {
            long sumValue = y - x + 1;
            if (sumValue % 2 == 0)
                return sumValue / 2 * (x + y);
            else
            {
                sumValue -= 1;
                return (x + y) / 2 * (1 + sumValue);
            }
        }
    }
}
//return sumValue / 2 * (x + y) + (x + y) / 2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(solution(5, 3));

        long solution(int a, int b)
        {
            if (a < b)
                return SumBetween(a, b);
            else if (a > b)
                return SumBetween(b, a);
            else
                return a;

        }
        long SumBetween(int x, int y)
        {
            long sumValue = y - x + 1;
            if (sumValue % 2 == 0)
                return sumValue / 2 * (x + y);
            else
            {
                sumValue -= 1;
                return (x + y) / 2 * (1 + sumValue);
            }
        }
    }
}
