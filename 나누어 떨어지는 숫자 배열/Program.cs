using System;
using System.Collections.Generic;

namespace 나누어_떨어지는_숫자_배열
{
    class Program
    {
        public class Solution
        {
            public int[] solution(int[] arr, int divisor)
            {
                List<int> ints = new List<int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if ((arr[i] % divisor) == 0)
                    {
                        ints.Add(arr[i]);
                    }
                }

                if (ints.Count > 0)
                {
                    ints.Sort();
                }
                else
                {
                    ints.Add(-1);
                }
                return ints.ToArray();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
