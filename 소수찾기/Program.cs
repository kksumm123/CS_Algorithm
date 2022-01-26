using System;

namespace 소수찾기
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            int[] nums = new int[n + 1];
            for (int i = 0; i < nums.Length; i++)
                nums[i] = 1;

            nums[0] = nums[1] = 0;

            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (nums[i * i] == 0)
                    continue;

                for (int j = i * i; j <= n; j += i)
                    nums[j] = 0;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    answer++;
            }
            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(20));

            int solution(int n)
            {
                int answer = 0;

                int[] nums = new int[n + 1];
                for (int i = 0; i < nums.Length; i++)
                    nums[i] = 1;

                nums[0] = nums[1] = 0;

                for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                {
                    if (nums[i * i] == 0)
                        continue;

                    for (int j = i * i; j <= n; j += i)
                        nums[j] = 0;
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                        answer++;
                }
                return answer;
            }
        }
    }
}
