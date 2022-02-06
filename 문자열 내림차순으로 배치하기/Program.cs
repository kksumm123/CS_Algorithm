using System;
using System.Linq;

namespace 문자열_내림차순으로_배치하기
{
public class Solution
{
    public string solution(string s)
    {
        var list = s.ToList();
        list.Sort();
        list.Reverse();
        return new string(list.ToArray());
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
