using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    // Exercise 3
    internal class AdvancedCalculator
    {


         
        public int  CalculationOne() {
            int result = (int)(-1 + (5 * 6));
            return (result);
        }

        public int CalculationTwo()
        {
            int result = (int)(38 + (5 % 7));
            return (result);
        }

        public double CalculationThree()
        {
            double result = (14 + ((-3 * 6)/7));
            return (result);
        }

        public double CalculationFour()
        {
            double result = 2 + ((13/6)*6) + Math.Sqrt(7);
            return (result);

        }
        public double CalculationFive()
        {
            double result = (Math.Pow(6, 4) + Math.Pow(5,7)) / (9 % 4);
            return (result);
        }
    }
}
