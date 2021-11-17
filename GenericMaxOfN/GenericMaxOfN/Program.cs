using System;

namespace GenericMaxOfN
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericMax<int> obj1 = new GenericMax<int>();
            int[] arr = {122,2323,121,33,45 };
            obj1.FindMax(arr);

            GenericMax<double> obj2 = new GenericMax<double>();
            double[] arr2 = { 122.3, 23.23, 121.67, 33.3, 45 };
            obj2.FindMax(arr2);

            GenericMax<string> obj3 = new GenericMax<string>();
            string[] arr3 = { "lion","monkey","deer","cobra" };
            obj3.FindMax(arr3);
        }
    }
}
