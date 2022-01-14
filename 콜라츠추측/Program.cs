using System;

namespace 콜라츠추측
{
    public class Solution
    {
        public int solution(int _num)
        {
            long num = _num;
            int index = 0;
            while (index < 500)
            {
                if (num == 1)
                    return index;
                else if (num % 2 == 0)
                    num /= 2;
                else
                {
                    num *= 3;
                    num++;
                }

                index++;
            }

            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            solution(626331);

            int solution(int num)
            {
                int index = 0;
                while (index < 500)
                {
                    if (num == 1)
                        return index;
                    else if (num % 2 == 0)
                        num /= 2;
                    else
                    {
                        num *= 3;
                        num++;
                    }
                    index++;

                    Console.WriteLine($"{index} : {num}");
                }

                return -1;
            }
        }
    }
}
