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
            int num1 = 6;
            int num2 = 8;
            int num3 = 3;
            int max = findMaxumum(num1, num2, num3);
            Console.WriteLine(max);
            Console.ReadKey();
            
        }
        static int findMaxumum(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0) return num1;
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0) return num2;
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0) return num3;
            else throw new Exception("Values are same");
        }


    }
}
