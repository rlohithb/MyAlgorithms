using System;

namespace SumOfFirrstNNaturalNumbers
{
    class MainClass
    {
        static int function(int n)
        {
            //Time taken is C1.
            //Constant work of 3 operations for any input you pass.
            return n * (n + 1) / 2;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine($"Sum is :{function(1000)}");
            //Console.WriteLine("Hello World!");
        }
    }
}
