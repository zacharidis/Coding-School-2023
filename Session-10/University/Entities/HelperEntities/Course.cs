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

        }

        public Course(Guid id)
        {
               this.ID = id;
        }

        public Course(Guid id, string? code)
        {
            this.ID = id;   
            this.Code = code;
        }

        public Course(Guid iD, string? code, string? subject) 
        {
            
            this.ID = iD;
            this.Code = code;
            this.Subject = subject;
                
             
        }

        // helper methods



    }
}
