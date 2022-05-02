using System;

namespace 가운데_글자_가져오기
{
    class Program
    {
        public class Solution
        {
            public string solution(string s)
            {
                string answer = "";

                var length = s.Length;
                if ((length & 1) == 0)
                {
                    var targetIndex = length / 2;
                    answer = $"{s[targetIndex - 1]}{s[targetIndex]}";
                }
                else
                {
                    var targetIndex = (length / 2);
                    answer = $"{s[targetIndex]}";
                }

                return answer;
            }
        }

        static void Main(string[] args)
        {
            var test = new Solution();

            Console.WriteLine(test.solution("abcde"));
        }
    }
}
