using Session_07.MessagingEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.ActionEntities
{
    internal class ActionResolver
    {
        public enum ActionEnum
        {
            Convert,
            Uppercase,
            Reverse
        }

        //methods
        public MessageLogger? Logger{ get; set; }

        // Constuctors 

        public ActionResolver()
        {

        }

        

    }
}
