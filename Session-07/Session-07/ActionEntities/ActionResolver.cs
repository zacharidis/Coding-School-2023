using Session_07.MessagingEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.ActionEntities
{
    internal class ActionResolver
    {
      

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


       
         public void Convert(ActionRequest request)
        {
            decimal inputNumber = 0m;

            if(Decimal.TryParse(request.Input, out inputNumber))
            {
                //convert to binary 
            }

           
        }

         
         public void Uppercase(ActionRequest request)
        {



        }






    }
}
