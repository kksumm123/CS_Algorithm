using System;

namespace 이상한문자만들기
{
    public class Solution
    {
        public string solution(string s)
        {
            var splits = s.Split(" ");
            string result = string.Empty;
            for (int i = 0; i < splits.Length; i++)
            {
                var arr = splits[i].ToCharArray();

                for (int j = 0; j < arr.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        if (arr[j] >= 'a' && arr[j] <= 'z')
                            arr[j] = (char)(arr[j] - 32);
                    }
                    else
                    {
                        if (arr[j] >= 'A' && arr[j] <= 'Z')
                            arr[j] = (char)(arr[j] + 32);
                    }
                }
                result += (i == 0 ? "" : " ") + new string(arr);
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "try hello world";
            var arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (arr[i] >= 'a' && arr[i] <= 'z')
                        arr[i] = (char)(arr[i] - 32);
                }
            }
            Console.WriteLine(arr.ToString());
        }
    }
}
