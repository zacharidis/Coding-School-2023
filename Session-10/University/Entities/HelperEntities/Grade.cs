using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Helpers
{
    internal class Grade
    {
        // properties
        public Guid ID { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseID { get; set; }  

        public int GradeValue { get; set; }

        // Constructors
        public Grade() { }

        public Grade(Guid id)
        {
            this.ID = id;   
        }

        public Grade(Guid id , Guid studentId)
        {

            this.ID = id;
            this.StudentId = studentId;

              
        }

        public Grade(Guid id  , Guid  studentId , Guid courseId )
        {
            this.ID= id;
            this.StudentId = studentId;
            this.CourseID = courseId;
        }


        public Grade(Guid iD, Guid studentId, Guid courseID, int gradeValue) 
        {
            this .ID = iD;
            this .StudentId = studentId;
            this.CourseID = courseID;
            this.GradeValue = gradeValue;

        }


        // methods 





    }
}
