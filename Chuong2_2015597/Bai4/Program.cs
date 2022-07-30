using System;

namespace DoubleDecimalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const double d = 4f/3;
            const decimal m = 4m/3;

            Console.WriteLine("=============DoubleDecimalTest=============");
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: "+ m);
            Console.ReadLine();
        }
    }
}
