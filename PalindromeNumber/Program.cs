using System;

namespace PalindromeNumber
{
    class MainClass
    {
        public static bool IsPalindrome(int n)
        {
            int rem = 0, rev = 0, temp = n;
            while (temp != 0)
            {
                rem = temp % 10;
                rev = rem + 10 * rev;
                temp = temp / 10;
            }
            return n == rev; 
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(131));

            //Time complexity if Theta(d)
            //Where d is the no. of digits in our number
            Console.WriteLine("Hello World!");
        }
    }
}
