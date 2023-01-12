using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    // Exercise 2
    internal class SumDiv

    {
         public string Sum()
        {
            int numberOne = 10; 
            int numberTwo =5;
            return ("The sum of : " + numberOne +" and  " +  numberTwo +" = " + ( numberOne + numberTwo)) ;
        }

        public string Div()
        {
            int numberOne = 10;
            int numberTwo = 5;
                
            return ("The division  of : "  + numberOne + " and " + numberTwo + " = " + numberOne / numberTwo) ; 

        }
    }
}
