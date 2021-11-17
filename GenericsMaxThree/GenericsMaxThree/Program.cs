using System;

namespace GenericsMaxThree
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericsMax<int> obj1 = new GenericsMax<int>();
            obj1.ReturnMax(22, 233, 99);
            GenericsMax<double> obj2 = new GenericsMax<double>();
            obj2.ReturnMax(23.4, 565, 99.5);
            GenericsMax<string> obj3 = new GenericsMax<string>();
            obj3.ReturnMax("Seven", "Eleven", "Supreme");
        }
    }
}
