using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class AgeGenderPrinter

        //Exercise 4
    {
        public string Print()
        {
            int age = 20;
            string myGender = "Male";

            string result = ("You are " + myGender + " and look younger than " + age +".");
            return result;
        }
    }
}
