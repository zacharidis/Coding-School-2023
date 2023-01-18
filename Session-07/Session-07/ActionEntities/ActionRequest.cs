using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.ActionEntities
{

  
    internal class ActionRequest
    {

     

        public ActionEnum Action { get; set; }
        // properties 
        public Guid RequestID { get; set; }
        public String Input { get; set; }
        


        public ActionRequest()
        {

        }
    }
}
