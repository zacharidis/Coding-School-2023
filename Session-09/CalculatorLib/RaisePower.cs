using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    internal class RaisePower
    {

        public string Calculate(double inputOne, double inputTwo)
        {
            return (Math.Pow(inputOne, inputTwo)).ToString();
        }
    }
}
