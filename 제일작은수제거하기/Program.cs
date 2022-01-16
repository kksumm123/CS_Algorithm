using System;
using System.Linq;

namespace 제일작은수제거하기
{
    public class Solution
    {
        public int[] solution(int[] arr)
        {
            if (arr.Length == 1)
            {
                arr[0] = -1;
                return arr;
            }
            var lii = arr.ToList();
            lii.Remove(lii.Min());

            return lii.ToArray();
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
