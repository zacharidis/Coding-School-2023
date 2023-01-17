using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.ActionEntities
{
    internal class ActionRequest
    {
        // properties 
        public Guid RequestID { get; set; }
        public String Input { get; set; }
        public Action ActionEnum { get; set; }


        public ActionRequest()
        {

        }
    }
}
