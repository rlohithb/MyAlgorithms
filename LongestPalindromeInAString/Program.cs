using System;
using System.Text;

namespace PalindromeInAString
{
    class MainClass
    {
        //Check if a string is Palindrome
        public static bool IsPalindrome(string str)
        {
            if (str.Length == 1 || str.Length==0)
            { 
                return true;
            }
            if (str[0] == str[str.Length - 1])
            {
                return IsPalindrome(str.Substring(1, str.Length - 2));
            }
            return false;
        }

#region //Inefficient duplicate coding.
        public static string PalindromeSubString(string str)
        {
            if (str.Length <= 1)
                return str;
            int max_len = 1;
            int st = 0, end = 0;

            //for odd sized palindrome
            for (int i = 0; i < str.Length; i++)
            {
                int l = i;
                int r = i;
                while(l>=0 && r<str.Length)
                {
                    if (str[l] == str[r])
                    {
                        l -= 1;
                        r += 1;
                    }
                    else
                        break;
                }
                int len = r - l - 1;
                if(len>max_len)
                {
                    max_len = len;
                    st = l + 1;
                    end = r - 1;
                }
            }

            //for even sized palindrome
            for (int i = 0; i < str.Length; i++)
            {
                int l = i;
                int r = i + 1;
                while (l >= 0 && r < str.Length)
                {
                    if (str[l] == str[r])
                    {
                        l -= 1;
                        r += 1;
                    }
                    else
                        break;
                }
                int len = r - l - 1;
                if (len > max_len)
                {
                    max_len = len;
                    st = l + 1;
                    end = r - 1;
                }
            }
            
            return str.Substring(st, max_len);
        }
        #endregion

        #region //clean code

        //constants for tracking
        static int resultStart;
        static int resultLength;

        //Initialize the check
        public static string longPalindrome(string s)
        {
            int strLength = s.Length;
            
            if (strLength < 2)
            {
                return s;
            }
            for (int i = 0; i < strLength; i++)
            {
                //Call the expand range twice to check for both even and odd palindrome's
                expandRange(s, i, i);
                expandRange(s, i, i + 1);
            }

            return s.Substring(resultStart, resultLength);
        }
        //check if a given part of a string is a palindrome
        private static void expandRange(string str, int begin,int end)
        {
            while(begin>=0 && end<str.Length &&  str[begin] == str[end])
            {
                begin--;
                end++; 
            }
            if(resultLength < end - begin - 1)
            {
                resultStart = begin + 1;
                resultLength = end - begin - 1;
            }
        }
        #endregion
        //trigger
        public static void Main(string[] args)
        {

            //string str = "forgeeksskeegfor";

            //Console.WriteLine("Length is: " + longestPalSubstr(str));

            string str = "KAYAK";
            Console.WriteLine("Palindrome is: " + PalindromeSubString(str));
            string str2 = "x23abccba89y";
            Console.WriteLine("Palindrome is: " + PalindromeSubString(str2));
            //for(int i=0;i<str.Length;i++)
            //{
            //    for(int j = str.Length - 1; j >= 0; j--)
            //    {

            //    }
            //}
            string str3 = "Funkeye";
            Console.WriteLine("Palindrome is: " + longPalindrome(str3));
        }
        
    }
}
