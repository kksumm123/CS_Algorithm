using System;
using System.Collections.Generic;
using System.Linq;


//Dictionary<string, string> stringMap = new Dictionary<string, string>();
//foreach (var item in stringList)
//{
//    stringMap[item] = item.Substring(n, 1);
//    resultList.Add(stringMap[item]);
//}

namespace 문자열_내_마음대로_정렬하기
{
    public class Solution
    {
        public string[] solution(string[] strings, int n)
        {
            var stringList = strings.ToList();
            var resultList = new List<string>();
            stringList.Sort();

            foreach (var item in stringList)
                resultList.Add(item.Substring(n, 1));
            resultList.Sort();

            string targetString = string.Empty;
            for (int i = 0; i < resultList.Count(); i++)
            {
                targetString = resultList[i];
                for (int j = 0; j < stringList.Count(); j++)
                {
                    if (stringList[j] == "")
                        continue;
    
                    if (stringList[j].Substring(n, 1) == targetString)
                    {
                        resultList[i] = stringList[j];
                        stringList[j] = "";
                        break;
                    }
                }
            }
            return resultList.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] testArr = new string[] { "sun", "bed", "car" };
            Console.WriteLine(solution(testArr, 1));

            string[] solution(string[] strings, int n)
            {
                var stringList = strings.ToList();
                var resultList = new List<string>();
                stringList.Sort();

                foreach (var item in stringList)
                    resultList.Add(item.Substring(n, 1));
                resultList.Sort();

                string targetString = string.Empty;
                for (int i = 0; i < resultList.Count(); i++)
                {
                    targetString = resultList[i];
                    for (int j = 0; j < stringList.Count(); j++)
                    {
                        if (stringList[j] == "")
                            continue

                        if (stringList[j].Substring(n, 1) == targetString)
                        {
                            resultList[i] = stringList[j];
                            stringList[j] = "";
                            break;
                        }
                    }
                }
                return resultList.ToArray();
            }
        }
    }
}
