using System;
using System.Collections.Generic;
namespace GenericMethodMaxOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMaximum<int> obj1 = new GetMaximum<int>(11,34,5);
            obj1.ReturnMax();
            GetMaximum<double> obj2 = new GetMaximum<double>(11.4,5.7,78.4);
            obj2.ReturnMax();

            GetMaximum<string> obj3 = new GetMaximum<string>("Monkey","money","Banana");
            obj3.ReturnMax();

        }
    }
}
