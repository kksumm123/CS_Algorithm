using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int[] answer;

        List<int> myList;
        List<int> myList2 = new List<int>();
        int cmdRow = commands.GetLength(0);

        for (int i = 0; i < cmdRow; i++)
        {
            myList = array.ToList()
                .GetRange(commands[i, 0] - 1
                        , commands[i, 1] - commands[i, 0] + 1);
            myList.Sort();
            myList2.Add(myList[commands[i, 2] - 1]);
        }

        answer = myList2.ToArray();
        return answer;
    }
}

class Program
{
    static void Main()
    {
        int[] answer = new int[] { 1, 5, 2, 6, 3, 7, 4 };
        int[,] cmd = new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
        Solution test = new Solution();
        foreach (var item in test.solution(answer, cmd))
        {
            Console.WriteLine(item);
        }
    }
}