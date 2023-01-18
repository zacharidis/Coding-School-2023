using Session_07.MessagingEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
      
        

        //properties
        public MessageLogger? Logger{ get; set; }

        // Constuctors 

        public ActionResolver()
        {
            Logger = new MessageLogger();

        }

        // methods 

      

        
        public ActionResponse Execute(ActionRequest request)
        {

            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();  // the guid gets initialized
            response.RequestID = request.RequestID;

            //TODO add logger functionality

            try
            {
                switch (request.Action)
                {
                    case ActionEnum.Convert:
                        Log("CONVERT:");
                        response.Output = Convert(request.Input);
                        break;

                        case ActionEnum.Uppercase:
                        Log("UPPERCASE");
                        response.Output = Uppercase(request.Input);
                        break; 
                        case ActionEnum.Reverse:
                        Log("RERVERSE");
                        response.Output = Reverse(request.Input); 
                        break;

                         default:

                        // show an error message 
                        break;

                }
            } catch (Exception ex)
            {
               // goes to logger Log(ex.Message);
            } 
             finally
            {
                // log the end of execution 
            }





            return response;

        }


         private void Log(string text)
        {
            Logger.Write(new Message("----------"));

            Message message = new Message(text);
            Logger.Write(message);
        }


        public string Convert(string input)
        {
            string converted = input.ToString();
            return converted;

           
        }

         
         public string Uppercase(string input)
        {
            string converted = input.ToString();

            return converted.ToUpper();
        }

         public string Reverse(string input)
        {
            //

            return string.Empty;
        }





    }
}
