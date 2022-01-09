using System;
using System.Collections.Generic;

namespace 행렬의덧셈
{
    public class Solution
    {
        public static int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
                for (int j = 0; j < arr1.GetLength(1); j++)
                    answer[i, j] = arr1[i, j] + arr2[i, j];

            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var result = Solution.solution(new int[,] { { 1 }, { 2 } }, new int[,] { { 3 }, { 4 } });
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
