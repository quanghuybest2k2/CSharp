using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class InchesToCentimeterslnteractive
{
    static void Main()
    {
        //Cm = inch/0.39370 ( công thức)
        int inch;
        double cm;
        double d = 1/2.54;
        Console.WriteLine("================InchesToCentimeterslnteractive===================");
        Console.Write("Moi ban nhap inch: ");
        inch = int.Parse(Console.ReadLine());
        cm = inch / d; //Chuyển đổi
        Console.WriteLine("{0} inch la {1} cm",inch,cm);
        Console.ReadLine();
        // 1 inch la 2.54cm
    }

}