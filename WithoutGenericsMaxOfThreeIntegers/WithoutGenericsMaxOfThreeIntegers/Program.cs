using System;

namespace WithoutGenericsMaxOfThreeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxOfThree obj1 = new MaxOfThree();
            obj1.ReturnMax(25, 56, 11);
        }
    }
}
