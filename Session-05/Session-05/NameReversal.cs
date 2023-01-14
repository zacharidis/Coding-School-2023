using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_05
{
    internal class NameReversal
    {
        // Exercise 1
        // Reverse a string -- my name --

        public string Reverse(string name)
        {
            char[] reversedName = name.ToCharArray();
            string reName = "";

            for (int i = reversedName.Length - 1; i >= 0; i--)
            {
                reName+= reversedName[i];
            }



                return reName;
        }

    }
}
