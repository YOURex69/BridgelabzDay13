using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMaxOfN
{
    public class GenericMax<T> where T: IComparable
    {
       
       
       
        public void FindMax(T[] values)
        {
            Array.Sort(values);
            Console.WriteLine(values[^1]);
            Console.WriteLine(values[values.Length-1]);
            return;

        }



    }
}
