using System;
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
           

            string maxInt = findMaximum<int>(1, 2, 3);
            string maxFloat = findMaximum<float>(1.1f, 9.4f, 5.7f);
            string maxString = findMaximum<string>("Apple", "Peach", "Banana");

            Console.WriteLine(maxInt);
            Console.WriteLine(maxFloat);
            Console.WriteLine(maxString);

            Console.ReadKey();
            
        }
        static int findMaximum(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0) return num1;
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0) return num2;
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0) return num3;
            else throw new Exception("Values are same");
        }
        static float findMaximum(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0) return num1;
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0) return num2;
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0) return num3;
            else throw new Exception("Values are same");
        }
        static string findMaximum(string input1, string input2, string input3)
        {
            if (input1.CompareTo(input2) > 0 && input1.CompareTo(input3) > 0) return input1;
            else if (input2.CompareTo(input1) > 0 && input2.CompareTo(input3) > 0) return input2;
            else if (input3.CompareTo(input1) > 0 && input3.CompareTo(input2) > 0) return input3;
            else throw new Exception("Values are same");
        }
        static string findMaximum<T>(T input1, T input2, T input3) where T : IComparable<T>
        {
            if (input1.CompareTo(input2) > 0 && input1.CompareTo(input3) > 0) return input1.ToString();
            else if (input2.CompareTo(input1) > 0 && input2.CompareTo(input3) > 0) return input2.ToString();
            else if (input3.CompareTo(input1) > 0 && input3.CompareTo(input2) > 0) return input3.ToString();
            else throw new Exception("Values are same");
        }


    }
}
