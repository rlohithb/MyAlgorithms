using System;

namespace Factorial
{
    class MainClass
    {
        public static int Factorial(int n)
        {

            return (n == 0) ? 1 : n * Factorial(n - 1);
        }
        public static void Main(string[] args)
        {
            //Time Complexity of Theta(n)
            //Space Complexity is Theta(n) Auxilary space.
            //This is causing extra overhead.
            //So, an iterative solution is better in this case as it
            //takes an Auxilary space of Theta(1)
            Console.WriteLine(Factorial(3));
            Console.WriteLine("Hello World!");
        }
    }
}
