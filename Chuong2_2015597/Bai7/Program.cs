using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace ProjectedRaisesInteractive
{
    class ProjectedRaisesInteractive
    {
        static void Main(string[] args)
        {
            WriteLine("ProjectedRaisesInteractive");

            const double PCT_CHANGE = 1.04; // 1.00 being none
            double inputSalary1 = 0;
            double inputSalary2 = 0;
            double inputSalary3 = 0;
            double outputSalary1 = 0;
            double outputSalary2 = 0;
            double outputSalary3 = 0;

            //skip error checking
            Write("Input salary 1:");
            inputSalary1 = double.Parse(ReadLine());
            Write("Input salary 2:");
            inputSalary2 = double.Parse(ReadLine());
            Write("Input salary 3:");
            inputSalary3 = double.Parse(ReadLine());

            outputSalary1 = inputSalary1 * PCT_CHANGE;
            outputSalary2 = inputSalary2 * PCT_CHANGE;
            outputSalary3 = inputSalary3 * PCT_CHANGE;

            WriteLine("Expected change multiplier:{0}", PCT_CHANGE);
            WriteLine("{0} will be {1} next year.", inputSalary1, outputSalary1);
            WriteLine("{0} will be {1} next year.", inputSalary2, outputSalary2);
            WriteLine("{0} will be {1} next year.", inputSalary3, outputSalary3);
        }
    }
}