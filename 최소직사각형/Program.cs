using System;

namespace 최소직사각형
{
    class Program
    {
        public class Solution
        {
            public int solution(int[,] sizes)
            {
                int horizontal = 0;
                int vertical = 0;
                int tmpHorizontal = 0;
                int tmpVertical = 0;

                for (int i = 0; i < sizes.Length / 2; i++)
                {
                    tmpHorizontal = Math.Max(sizes[i, 0], sizes[i, 1]);
                    tmpVertical = Math.Min(sizes[i, 0], sizes[i, 1]);
                    if (tmpHorizontal > horizontal)
                    {
                        horizontal = tmpHorizontal;
                    }
                    if (tmpVertical > vertical)
                    {
                        vertical = tmpVertical;
                    }
                }

                return horizontal * vertical;
            }
        }

        static void Main(string[] args)
        {
            var sln = new Solution();
            int[,] adsa = new int[,] { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };

            Console.WriteLine(sln.solution(adsa));
        }
    }
}
