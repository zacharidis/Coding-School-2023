using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class TemperatureConverter
    {

        public double ConvertFarenheit()


        {
            int celcius = 35;
            double result = 0;
           

            result = ((celcius * 1.8) + 32);



            return result;
            
        }

        public double ConvertKelvin()
        {
            int celcius = 35; 
            double result = 0;
            

            result = celcius + 271.15; 


            return result;

        }
    }
}
