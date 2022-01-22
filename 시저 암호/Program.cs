using System;

namespace 시저_암호
{
    public class Solution
    {
        public string solution(string s, int n)
        {
            var arr = s.ToCharArray();

            n %= 26;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'a' && arr[i] <= 'z')
                {
                    int alphValue = (int)arr[i] - 'a';
                    alphValue += n;
                    alphValue %= 26;
                    alphValue += 'a';
                    arr[i] = (char)alphValue;
                }
                else if (arr[i] >= 'A' && arr[i] <= 'Z')
                {
                    int alphValue = (int)arr[i] - 'A';
                    alphValue += n;
                    alphValue %= 26;
                    alphValue += 'A';
                    arr[i] = (char)alphValue;
                }
            }

            return new string(arr);
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
