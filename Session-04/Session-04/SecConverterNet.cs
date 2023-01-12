using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04


{

    //Exercise 6
    internal class SecConverterNet
    {

        public String Convert()
        {
            int seconds = 45678;
            TimeSpan t = TimeSpan.FromSeconds(seconds);

            

            string result = ("The amount of : " + seconds + " seconds is equivalent to : " + t.TotalMinutes + " minutes," + t.TotalHours + " hours," + t.TotalDays + " days," + (t.TotalDays/365) + " years.");
            return result;
        }




    }
}
