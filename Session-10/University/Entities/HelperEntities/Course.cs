using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Helpers
{
    public class Course
    {
        // properties
        public Guid ID { get; set; }
        public string? Code { get; set; }    
        public string? Subject { get; set; }

        // Constructors 

        public Course()
        {
            Guid ID = Guid.NewGuid();
        }

       

     

        // helper methods



    }
}
