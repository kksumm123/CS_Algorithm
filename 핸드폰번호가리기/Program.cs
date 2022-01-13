using System;
using System.Linq;

namespace 핸드폰번호가리기
{
    public class Solution
    {
        public string solution(string phone_number) => string.Concat(string.Concat(Enumerable.Repeat("*", phone_number.Length - 4)), phone_number.Substring(phone_number.Length - 4, 4));
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("01033334444"));


            string solution(string phone_number)
            {
                return string.Concat(string.Concat(Enumerable.Repeat("*", phone_number.Length - 4)), phone_number.Substring(phone_number.Length - 4, 4));
            }
        }
    }
}
