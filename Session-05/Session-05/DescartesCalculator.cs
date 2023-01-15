using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class DescartesCalculator
    {

        public int[] Calculate(int[] arrayOne , int[] arrayTwo , int arrayLength)
        {
            int[] finalArray = new int[arrayLength];
            int arrayPointer = 0; // keep track of the filled array 

            for (int i = 0; i < arrayOne.Length; i++) {
            
                    for (int j = 0; j < arrayTwo.Length; j++)
                {

                    finalArray[arrayPointer] = arrayOne[i] * arrayTwo[j];
                    arrayPointer++;

                }

              
                    
            
            }


            return finalArray ;

        }
       
    }
}
