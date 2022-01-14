using System;

namespace 평균구하기
{
    public class Solution
    {
        public double solution(int[] arr)
        {
            double answer = 0;
            for (int i = 0; i < arr.Length; i++)
                answer += arr[i];

            return answer / arr.Length;
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
