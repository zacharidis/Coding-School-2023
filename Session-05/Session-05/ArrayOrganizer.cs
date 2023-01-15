using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ArrayOrganizer
    {


        public int[] Sort(int[] array)

        {

            int tempValue = array[0];

            for (int i = 0; i < array.Length ; i++)
            {
                for (int j = i+1 ; j < array.Length ; j++)
                {
                    if (array[i] > array[j])
                    {
                        tempValue = array[i];
                        array[i] = array[j];
                        array[j] = tempValue;
                    }
                }




            }

            return array;
        }
    }
}
