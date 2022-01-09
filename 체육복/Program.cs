using System;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        int answer = 0;
        // 전체 학생배열 생성
        // List<int> Student = new List<int>();
        int[] Student = new int[n];

        // 배열 값채우기
        // 체육복 없는 사람 0
        // 체육복 가진 사람 1
        // 여벌이 있는 사람 2
        for (int i = 0; i < Student.Length; i++)
            Student[i] = 1;
        foreach (var idx in reserve)
            Student[idx - 1] += 1;
        foreach (var idx in lost)
            Student[idx - 1] -= 1;

        // 여벌이 있는 사람이 없는 사람 빌려주기
        for (int i = 0; i < Student.Length; i++)
        {
            if (Student[i] == 0)
            {
                if (IsOverCheck(i - 1, Student) == false
                    && Student[i - 1] == 2)
                {
                    Student[i - 1] -= 1;
                    Student[i] += 1;
                }
                else if (IsOverCheck(i + 1, Student) == false
                     && Student[i + 1] == 2)
                {
                    Student[i + 1] -= 1;
                    Student[i] += 1;
                }
            }
            if (Student[i] >= 1)
                answer++;
        }

        return answer;
    }
    public bool IsOverCheck(int _SelectIndex, int[] _Arr)
    {
        if (0 > _SelectIndex || _SelectIndex >= _Arr.Length)
        {
            return true;
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Solution sl = new Solution();
        int[] lost = new int[] { 2, 4 };
        int[] res = new int[] { 1, 3, 5 };
        Console.WriteLine($"Result : {sl.solution(5, lost, res)}");
    }
}