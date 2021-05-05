using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    class FindMax<T> where T : IComparable<T>
    {
        private T input1;
        private T input2;
        private T input3;
        public FindMax(T input1, T input2, T input3) 
        {
            this.input1 = input1;
            this.input2 = input2;
            this.input3 = input3;
        }
        public T findMaximum()
        {
            if (input1.CompareTo(input2) > 0 && input1.CompareTo(input3) > 0) return input1;
            else if (input2.CompareTo(input1) > 0 && input2.CompareTo(input3) > 0) return input2;
            else if (input3.CompareTo(input1) > 0 && input3.CompareTo(input2) > 0) return input3;
            else throw new Exception("Values are same");
        }
    }
}
