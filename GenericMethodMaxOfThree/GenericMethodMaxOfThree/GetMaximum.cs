using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethodMaxOfThree
{
    public class GetMaximum<T> where T:IComparable
    {
       public T v1, v2, v3;
      public GetMaximum(T v1,T v2,T v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }



        public void ReturnMax()
        {
            if ((v1.CompareTo(v2) > 0 && v1.CompareTo(v3) > 0) || v1.CompareTo(v2) >= 0 && v1.CompareTo(v3) > 0 || v1.CompareTo(v2) > 0 && v1.CompareTo(v3) >= 0)
            {
                Console.WriteLine(v1 + " is greter than " + v2 + " " + v3);
            }
            else if ((v2.CompareTo(v1) > 0 && v2.CompareTo(v3) > 0) || v2.CompareTo(v1) >= 0 && v2.CompareTo(v3) > 0 || v2.CompareTo(v1) > 0 && v2.CompareTo(v3) >= 0)
            {
                Console.WriteLine(v2 + " is greter than " + v1 + " " + v3);
            }
            else if ((v3.CompareTo(v1) > 0 && v3.CompareTo(v2) > 0) || v3.CompareTo(v2) >= 0 && v3.CompareTo(v1) > 0 || v3.CompareTo(v2) > 0 && v3.CompareTo(v2) >= 0)
            {
                Console.WriteLine(v3 + " is greter than " + v2 + " " + v1);
            }
        }

    }
}
