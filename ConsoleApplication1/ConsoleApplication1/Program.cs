﻿using System;
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

            //Console.WriteLine("Inter number of lines : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Inter number of cloumns : ");
            //int m = Convert.ToInt32(Console.ReadLine());
            //int[,] a = new int[n, m];

            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Inter the items a[{0},{1}] of array : ", i, j);
            //        a[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine();

            //Console.WriteLine("You array is : \n");
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write(a[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //// this code to print odd column 
            //Console.WriteLine("Columns with odd numbers : \n");
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        if (j % 2 != 0)
            //            Console.Write(a[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


            //Console.WriteLine("The lines after sum : \n");
            //int[] b = new int[n];
            //for (int i = 0; i < b.Length; i++)
            //{
            //    int sum = 0;
            //    for (int j = 0; j < m; j++)
            //    {
            //        sum += a[i, j];
            //    }
            //    b[i] = sum;
            //    Console.WriteLine(b[i]);
            //}
            //Console.WriteLine();

            //// Print The main diameter
            //Console.WriteLine("The main diameter is : \n");
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        if (i == j)
            //            Console.Write(a[i, j]);
            //        else
            //            Console.Write("\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //// Elements located above the main diameter

            //Console.WriteLine("Elements located above the main diameter : \n");
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        if (i < j)
            //            Console.Write(a[i, j] + "\t");
            //        else
            //            Console.Write("\t");
            //    }
            //    Console.WriteLine();

            //}
            //// Elements located under the main diameter

            //Console.WriteLine("Elements located under the main diameter : \n");

            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        if (i > j)
            //            Console.Write(a[i, j] + "\t");
            //        else
            //            Console.Write("\t");
            //    }
            //    Console.WriteLine("\n");
            //}


            ////Factor code for any number

            //Console.WriteLine("Please inter a number");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int s = x;
            //for (int i = x; i > 1; i--)
            //    s *= (i - 1);
            //Console.WriteLine(x + "! = " + s);


            //Switch statement : build a calculator using switch

            //double x, y; char op;
            //Console.WriteLine("Inter the first number : ");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Inter the operator like this (+ - * /) : ");
            //op = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Inter the second number : ");
            //y = Convert.ToDouble(Console.ReadLine());
            //switch (op)
            //{
            //    case '+': Console.WriteLine("The result is : " + (x + y));
            //        break;
            //    case '-': Console.WriteLine("The result is : " + (x - y));
            //        break;
            //    case '*': Console.WriteLine("The result is : " + (x * y));
            //        break;
            //    case '/': if (y != 0)
            //            Console.WriteLine("The result is : " + (x / y));
            //        else
            //            Console.WriteLine("You Dividing on Zero !");
            //        break;
            //    default:
            //        Console.WriteLine("The operation is wrong ..");
            //        break;
            //}


            // Total squares of numbers

            //Console.WriteLine("Inter your number : ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int n = 0;
            //for (int i = 1; i <= x; i++)
            //{
            //    n += (i * i);
            //}
            //Console.WriteLine("The total squares of number " + x + " is : " + n);


            //range for result

            //Console.WriteLine("Please write your score here : ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //if (x < 55)
            //    Console.WriteLine("Failed");
            //else if (x < 65)
            //    Console.WriteLine("Accepted");
            //else if (x < 75)
            //    Console.WriteLine("Good");
            //else if (x < 85)
            //    Console.WriteLine("Very Good");
            //else if (x < 95)
            //    Console.WriteLine("Oner");


            // The prime number

            //Console.WriteLine("Please inter a number");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int f = x - 1;
            //for (int i = 2; i < x; i++)
            //{
            //    if (x % i != 0)
            //    {
            //        if (i == f)
            //        {
            //            Console.WriteLine("The Number you intered is prime");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number you intered is not Prime");
            //        break;
            //    }
            //}



            // Test the max number

            Console.WriteLine("Inter The first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inter the second number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inter the therd number");
            int z = Convert.ToInt32(Console.ReadLine());
            int max;
            if (x > y)
                max = x;
            else
                max = y;
            if (z > max)
                max = z;
            Console.WriteLine("The maximum Number is: " + max);



        }
    }
}
