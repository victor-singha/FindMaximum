﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int maxInt = findMaximum(1, 2, 3);
            //float maxFloat = findMaximum(1.1f, 9.4f, 5.7f);
            //string maxString = findMaximum("Apple", "Peach", "Banana");
           
            //GENERIC METHODS
            int maxInt = findMaximum<int>(1, 2, 3);
            float maxFloat = findMaximum<float>(1.1f, 9.4f, 5.7f);
            string maxString = findMaximum<string>("Apple", "Peach", "Banana");

            Console.WriteLine(maxInt);
            Console.WriteLine(maxFloat);
            Console.WriteLine(maxString);

            //GENERIC CLASS
            int maxIntc = new FindMax<int>(3, 4, 9).findMaximum();
            double maxDoublec = new FindMax<double>(3.6, 4.9, 5.7).findMaximum();
            string maxStringc = new FindMax<string>("apple","peach","orange").findMaximum();
            
            Console.WriteLine(maxIntc);
            Console.WriteLine(maxDoublec);
            Console.WriteLine(maxStringc);

            Console.ReadKey();          
        }
        //static int findMaximum(int num1, int num2, int num3)
        //{
        //    if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0) return num1;
        //    if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0) return num2;
        //    if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0) return num3;
        //    else throw new Exception("Values are same");
        //}
        //static float findMaximum(float num1, float num2, float num3)
        //{
        //    if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0) return num1;
        //    if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0) return num2;
        //    if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0) return num3;
        //    else throw new Exception("Values are same");
        //}
        //static string findMaximum(string input1, string input2, string input3)
        //{
        //    if (input1.CompareTo(input2) > 0 && input1.CompareTo(input3) > 0) return input1;
        //    if (input2.CompareTo(input1) > 0 && input2.CompareTo(input3) > 0) return input2;
        //    if (input3.CompareTo(input1) > 0 && input3.CompareTo(input2) > 0) return input3;
        //    else throw new Exception("Values are same");
        //}
        static T findMaximum<T>(T input1, T input2, T input3) where T : IComparable<T>
        {
            if (input1.CompareTo(input2) > 0 && input1.CompareTo(input3) > 0) return input1;
            if (input2.CompareTo(input1) > 0 && input2.CompareTo(input3) > 0) return input2;
            if (input3.CompareTo(input1) > 0 && input3.CompareTo(input2) > 0) return input3;
            else throw new Exception("Values are same");
        }
    }
}
