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




      // the enum for possible actions 
    public enum ActionEnum { 
    Convert,
    Uppercase,
    Reverse 
    
     }

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

        
        public ActionResponse Execute(ActionEnum actionEnum)
        {

            ActionResponse response;
          




            if (actionEnum == ActionEnum.Uppercase) {

              
            
            } else if(actionEnum == ActionEnum.Convert)
            {


            } else if (actionEnum==ActionEnum.Reverse)
            {

            }
            else
            {
                response = new ActionResponse();
            }



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

         public void Reverse(ActionRequest request)
        {



        }





    }
}
