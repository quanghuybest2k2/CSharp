using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Planets
{
    class Planets
    {
        enum Planet
        {
            MERCURY = 1, VENUS, EARTH, MARS,
            JUPITER, SATURN, URANUS, NEPTUNE
        }
        static void Main(string[] args)
        {
            WriteLine("===============Planets================");
            WriteLine("Moi nhap vao mot so tu 1 den 8: ");

            Planet inputNum = (Planet)int.Parse(Console.ReadLine());

            WriteLine("Hanh tinh thu {0} la {1}", (int)inputNum, inputNum);
            
        }
    }
}
