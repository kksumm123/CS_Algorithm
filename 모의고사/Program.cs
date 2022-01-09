using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] answers)
    {
        int[] answer = new int[] { };

        int A_CorCnt = 0;
        int B_CorCnt = 0;
        int[] B_Pattern = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int C_CorCnt = 0;
        int[] C_Pattern = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == (i % 5 + 1)) // 나머지 연산을 이용한 인덱스 1 2 3 4 5
                A_CorCnt++;

            if (answers[i] == B_Pattern[i % 8])
                B_CorCnt++;

            if (answers[i] == C_Pattern[i % 10])
                C_CorCnt++;
        }

        // 각 유저의 정답 카운트 받기
        int[] Userarr = new int[] { A_CorCnt, B_CorCnt, C_CorCnt };
        // Add, Max 와 같은 함수를 사용하기위한 list 선언
        List<int> mylist = new List<int>();
        // 초기 Max값 할당
        int Max = Userarr.Max();


        // 각 A B C 유저 중복 Max 체크
        for (int i = 0; i < Userarr.Length; i++)
            if (Max == Userarr[i])
                mylist.Add(i + 1);

        // 오름차순 정렬
        mylist.Sort();
        // list -> array 변환
        answer = mylist.ToArray();
        return answer;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution test = new Solution();
        // 1,2,3,4,5
        // 1,3,2,4,2
        int[] arr = new int[] { 1, 3, 2, 4, 2 };
        int[] result = new int[] { };

        result = test.solution(arr);

        for (int i = 0; i < result.Length; i++)
            Console.WriteLine(result[i]);
    }
}