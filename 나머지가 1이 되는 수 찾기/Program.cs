using System;

namespace 나머지가_1이_되는_수_찾기
{
    class Program
    {

        public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;
                for (answer = 2; answer < n; answer++)
                {
                    if (n % answer == 1)
                    {
                        break;
                    }
                }

                return answer;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
