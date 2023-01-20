using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Helpers
{
    public class Grade
    {
        // properties
        public Guid ID { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseID { get; set; }  

        public int GradeValue { get; set; }

        // Constructors
        public Grade() {
            ID = Guid.NewGuid();
        }

      

     

        // methods 





    }
}
