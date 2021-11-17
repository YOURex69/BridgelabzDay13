using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsMaxThree
{
    public class GenericsMax<T> where T:IComparable
    {
        public void ReturnMax(T v1, T v2, T v3)
        {
            if (v1.CompareTo(v2) > 0 && v1.CompareTo(v3) > 0 || v1.CompareTo(v2) >= 0 && v1.CompareTo(v3) > 0 || v1.CompareTo(v2) > 0 && v1.CompareTo(v3) >= 0)
            {
                Console.WriteLine(v1 + " is greter than " + v2 + " " + v3);
            }
            else if (v2.CompareTo(v1) > 0 && v2.CompareTo(v3) > 0 || v2.CompareTo(v1) >= 0 && v2.CompareTo(v3) > 0 || v2.CompareTo(v1) > 0 && v2.CompareTo(v3) >= 0)
            {
                Console.WriteLine(v2 + " is greter than " + v1 + " " + v3);
            }
            else if (v3.CompareTo(v1) > 0 && v3.CompareTo(v2) > 0 || v3.CompareTo(v2) >= 0 && v3.CompareTo(v1) > 0 || v3.CompareTo(v2) > 0 && v3.CompareTo(v2) >= 0)
            {
                Console.WriteLine(v3 + " is greter than " + v2 + " " + v1);
            }
        }
    }
}
