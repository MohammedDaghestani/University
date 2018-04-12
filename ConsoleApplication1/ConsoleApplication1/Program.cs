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
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("Inter the items a[{0},{1}] of array : ", i,j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.WriteLine("You array is : \n");
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
            Console.WriteLine("Columns with odd numbers : \n");
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


            Console.WriteLine("The lines after sum : \n");
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
