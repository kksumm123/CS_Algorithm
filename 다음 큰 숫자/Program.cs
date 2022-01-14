using System;

class Solution
{
    public int solution(int n)
    {
        int inputNumBitCount = GetBitCount(n);
        int newBitCount = 0;
        while (true)
        {
            newBitCount = GetBitCount(++n);
            if (inputNumBitCount == newBitCount)
                return n;
        }
    }

    int GetBitCount(int n)
    {
        if (n == 0)
            return 0;

        return n % 2 + GetBitCount(n / 2);
    }
}

namespace 다음_큰_숫자
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
