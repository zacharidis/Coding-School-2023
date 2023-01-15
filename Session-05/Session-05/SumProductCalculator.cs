using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    //Excersice 2
    internal class SumProductCalculator
    {

        public int CalculateSum(int inputNumber)
        {
            int sum = 0;

            for (int i = 1; i <= inputNumber; i++)
            {
                sum += i;
            }

            return sum;
        }

        public int CalculateProduct(int inputNumber) 
        {
            int product = 1; // 0 would cause 0 * 1 = 0 

            for(int i = 1; i <= inputNumber; i++)
            {
                product *= i;
            }
            
            
            return product; }



    }
}
