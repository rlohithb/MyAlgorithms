using System;

namespace PermutationOfStringInString
{
    class MainClass
    {
        
        public static bool CheckArr(int[] s1,int[] s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                    return false;
            }
            return true;
        }

        public static bool IsPermutation(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;
            int[] s1Data = new int[26];
            int[] s2Data = new int[26];

            int wEnd = s1.Length;

            for (int i = 0; i < s1.Length; i++)
            {
                s1Data[(int)s1[i] - (int)'a'] += 1;
                s2Data[(int)s2[i] - (int)'a'] += 1;
            }
            for (int i = 0; i < s2.Length-wEnd; i++)
            {
                if (CheckArr(s1Data, s2Data))
                    return true;
                s2Data[(int)s2[i] - (int)'a'] -= 1;
                s2Data[(int)s2[i + wEnd] - (int)'a'] += 1;
            }

            return false;
        }
        
        public static void Main(string[] args)
        {
            string s1 = "cat";
            string s2 = "smartavbcd";

            Console.WriteLine(IsPermutation(s1, s2));
        }
    }
}
