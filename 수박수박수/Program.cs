using System;

namespace 수박수박수
{
    public class Solution
    {
        public string solution(int n)
        {
            char[] result = new char[n];
            for (int i = 0; i < n; i++)
                result[i] = i % 2 == 0 ? '수' : '박';
            return new string(result);
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
