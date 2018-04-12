using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inter number of lines : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inter number of cloumns : ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            Console.WriteLine("Inter the items of array : ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // this code to print odd column 

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j % 2 != 0)
                        Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[] b = new int[n];
            for (int i = 0; i < b.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += a[i, j];
                }
                b[i] = sum;
                Console.WriteLine(b[i]);
            }
            Console.WriteLine();
        }
    }
}
