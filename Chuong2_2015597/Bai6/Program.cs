using System;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            // inch * 0.39370
            double inch;
            double cm;
            double d = 2.54;
            Console.WriteLine("===============InchesToCentmeters=================");
            Console.WriteLine("Nhap inch: ");
            inch = double.Parse(Console.ReadLine());
            cm = inch * d;
            Console.WriteLine("{0} inch la {1} cm", inch,cm);
            Console.ReadLine();
        }
    }
}
