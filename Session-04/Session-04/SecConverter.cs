using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{

    // Exercise 5
    internal class SecConverter
    {
           public string Convert() {

            int seconds = 45678;

            int minutes = (int) seconds/60;

            int hours = (int)minutes / 60;

            int days = (int) hours / 24;
            
            int years = (int)hours / 365;

            return ("The amount of : " + seconds + " seconds is equivalent to : " + minutes + " minutes," + hours + " hours," + days + " days," + years + " years.");


                    

      

            
        }
    }
}
