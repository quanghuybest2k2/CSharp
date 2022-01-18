using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace EggsInteractive
{
    class EggsInteractive
    {
        static void Main(string[] args)
        {
            WriteLine("===============EggsInteractive===============");

            int eggs1 = 0;
            int eggs2 = 0;
            int eggs3 = 0;
            int eggs4 = 0;
            int calculatedSum = 0;
            int calculatedDozen = 0;
            int calculatedLeftover = 0;

            //skip error checking
            Write("chicken1 eggs:");
            eggs1 = int.Parse(ReadLine());
            Write("chicken2 eggs:");
            eggs2 = int.Parse(ReadLine());
            Write("chicken3 eggs:");
            eggs3 = int.Parse(ReadLine());
            Write("chicken4 eggs:");
            eggs4 = int.Parse(ReadLine());

            calculatedSum = eggs1 + eggs2 + eggs3 + eggs4;

            calculatedDozen = calculatedSum / 12;
            calculatedLeftover = calculatedSum % 12;

            WriteLine("{0} eggs comes to {1} dozen and {2} eggs.", calculatedSum, calculatedDozen, calculatedLeftover);
        }
    }
}
