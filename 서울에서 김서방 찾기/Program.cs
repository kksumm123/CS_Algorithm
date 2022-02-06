using System;
using System.Linq;

namespace 서울에서_김서방_찾기
{
    public class Solution
    {
        public string solution(string[] seoul) => $"김서방은 {seoul.ToList().IndexOf("Kim")}에 있다";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
