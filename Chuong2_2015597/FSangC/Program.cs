using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace FahrenheitToCelsius
{
    class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            
            WriteLine("================FahrenheitToCelsius==================");

            double inputTemp = 0;
            double calculatedTemp = 0;

            Write("Temp (in F):");
            inputTemp = double.Parse(ReadLine());
            calculatedTemp = (inputTemp - 32) * (5.0 / 9.0);

            WriteLine("{0} Fahrenheit = {1} Celsius", inputTemp.ToString("#0.0"), calculatedTemp.ToString("#0.0"));
            ReadLine();
        }
    }
}
