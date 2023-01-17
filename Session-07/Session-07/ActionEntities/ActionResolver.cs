using Session_07.MessagingEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
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

        public ActionResolver(MessageLogger messageLogger)
        {

        }

        
        public ActionResponse Execute(ActionRequest request)
        {

            



            return null;

        }


        public void Convert(Message message)
        {
            decimal inputValue;
           
            String inputMessage = message.MessageBody.ToString(); 

            if(Decimal.TryParse(inputMessage, out inputValue))
            {

            }

          




        }







    }
}
