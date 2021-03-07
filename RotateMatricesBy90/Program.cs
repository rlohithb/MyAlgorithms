using System;

namespace RotateMatricesBy90
{
    class MainClass
    {
        public static void PrintMatrix(int[][] arr,int len)
        {
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public static void Main(string[] args)
        {
            //int[,] arr = new int[5,5];
            //Console.WriteLine("Total length: " + arr.Length);
            //double len = Math.Sqrt(arr.Length);
            //for (int i = 0; i < len; i++)
            //{
            //    for (int j = 0; j < len; j++)
            //    {
            //        if (i % 2 == 0 || j % 2 == 0)
            //            arr[i, j] = 1;
            //        else
            //            arr[i, j] = 0;
            //    }
            //}
            //for (int i = 0; i < len; i++)
            //{
            //    for (int j = 0; j < len; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Hello World!");
            int[][] arr = new int[4][];
            arr[0] = new int[4] { 1, 2, 3, 4 };
            arr[1] = new int[4] { 5, 6, 7, 8 };
            arr[2] = new int[4] { 9, 10, 11, 12 };
            arr[3] = new int[4] { 13, 14, 15, 16 };

            var len = arr.Length;
            Console.WriteLine("*****Given Matrix**********");
            PrintMatrix(arr, arr.Length);
            Console.WriteLine("*************************");
            Console.WriteLine("********Swap Matrix*************");
            for (int i = 0; i < len; i++)
            {
                for (int j = i; j < len; j++)
                {
                    var temp = arr[i][j];
                    arr[i][j] = arr[j][i];
                    arr[j][i] = temp;
                }
            }
            PrintMatrix(arr, len);
            Console.WriteLine("*********************************");
            Console.WriteLine("*************Flip Matrix*************");
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j<len/2; j++)
                {
                    var temp = arr[i][j];
                    arr[i][j] = arr[i][len - 1 - j];
                    arr[i][len - 1 - j] = temp;
                }
            }
            PrintMatrix(arr, len);
            Console.WriteLine("*************************************");
            //Console.WriteLine(arr.Length);
        }
    }
}
