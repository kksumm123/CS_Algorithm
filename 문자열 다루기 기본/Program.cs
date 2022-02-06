using System;

namespace 문자열_다루기_기본
{
public class Solution
{
    public bool solution(string s)
    {
        if ((s.Length == 4 || s.Length == 6) == false)
            return false;

        int num = 0;
        for (int i = 0; i < s.Length; i++)
        {
            num = (int)(s[i] - '0');
            if (num < 0 || num > 9)
                return false;
        }

        return true;
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1);
        }
    }
}
