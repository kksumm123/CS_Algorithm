using System;
using System.Linq;

namespace 직사각형별찍기
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);


            Console.WriteLine(string.Concat(Enumerable.Repeat(string.Concat(Enumerable.Repeat("*", a)) + "\n", b)));
        }
    }
}
