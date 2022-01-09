using System;
using System.Collections.Generic;
using System.Linq;

namespace x만큼간격이있는n개의숫자
{
    public class Solution
    {
        public long[] solution(int x, int n)
        {
            long[] answer = new long[n];
            for (int i = 0; i < n; i++)
                answer[i] = x + (i * (long)x);

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
