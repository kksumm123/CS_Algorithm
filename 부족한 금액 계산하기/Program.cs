using System;

namespace 부족한_금액_계산하기
{
    class Program
    {
        class Solution
        {
            public long solution(int price, int money, int count)
            {
                long accumulatePrice = 0;
                int currentPrice = 0;
                for (int i = 1; i <= count; i++)
                {
                    currentPrice = price * i;
                    accumulatePrice += currentPrice;
                }

                if (money > accumulatePrice)
                {
                    return 0;
                }
                else
                {
                    return accumulatePrice - money;
                }
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
