using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    // Exercise 3
    internal class PrimeCalculator
    {

        public string Find(int inputNumber)
        {
            
            StringBuilder sb= new StringBuilder();
            bool isPrime = true; // flag for a number being prime or not


            for (int i = 2; i<= inputNumber; i++)
            {

                for (int j = 2; j <= inputNumber; j++)
                {

                    if(  i != j && i % j == 0  )
                    {
                        isPrime = false;
                        break;
                    }

                   

                   
                }


                if (isPrime)
                {
                    sb.Append(i);
                    sb.Append(',');
                }
                isPrime = true;

            }

            
          


            
            return sb.ToString();




        }



    }
}
