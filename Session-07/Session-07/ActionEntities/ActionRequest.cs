using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.ActionEntities
{

     public class ActionEntity
    {
        public Guid RequestID { get; set; }
    }
  
    internal class ActionRequest : ActionEntity 
    {

     

        public string Input { get; set; }
        public ActionEnum Action { get; set; }

        


        public ActionRequest()
        {
            RequestId= Guid.NewGuid();
        }
    }
}
