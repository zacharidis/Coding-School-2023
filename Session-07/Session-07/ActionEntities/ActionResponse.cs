using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.ActionEntities
{
    internal class ActionResponse
    {
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }    
        public String Output { get; set; }


        public ActionResponse()
        {

        }
    }
}
