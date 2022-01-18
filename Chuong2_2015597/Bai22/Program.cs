using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace MoveEstimator
{
    class MoveEstimator
    {
        static void Main(string[] args)
        {
            WriteLine("=============MoveEstimator=================");

            //double so we can use decimal rates and inputs
            const double BASE_RATE = 200;
            const double HOUR_RATE = 150; //wow
            const double MILE_RATE = 2; //wow
            double inputHours = 0;
            double inputMiles = 0;
            double calculatedEstimate = 0;

            //skip error checking
            Write("Estimated Hours:");
            inputHours = double.Parse(ReadLine());
            Write("Estimated Miles:");
            inputMiles = double.Parse(ReadLine());

            calculatedEstimate = BASE_RATE +
                                    (HOUR_RATE * inputHours) +
                                    (MILE_RATE * inputMiles);

            WriteLine("{0} + {1}*{2} + {3}*{4}", BASE_RATE,
                                                    HOUR_RATE, inputHours,
                                                    MILE_RATE, inputMiles);
            WriteLine("Estimated Cost:{0}", calculatedEstimate);
        }
    }
}