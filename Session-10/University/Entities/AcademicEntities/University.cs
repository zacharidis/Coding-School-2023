using Session_06.Helpers;
using Session_06.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Academics
{
    public class University:Institute
    {
        // properties

        public Student[] Students = new Student[30];

        public Course[] Courses = new Course[20];
        
        public Schedule[] Schedules = new Schedule[60];

        public Grade[]? Grades { get; set; }

     


        // Constructor 

        public University()
        {

        }

        public University(Guid id) : base(id) { 
            this.ID = id;

        }

  
        }
        

        


    }

