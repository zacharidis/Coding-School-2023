using Session_06.Helpers;
using Session_06.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Academics
{
    internal class University:Institute
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

        public University(Guid id ,string name , int yearsInService): base(id,name,yearsInService) {
            this.ID = id;
            this.Name = name;
            this.YearsInService = yearsInService;

        }
        
        public University(Guid id, string name , int yearsInService , Student[] students): base(id, name, yearsInService) {}

        public University(Guid id , string name , int yearsInService , Student[] students, Grade[] grades, Course[] courses, Schedule[] scheduledCourses) : base(id,name,yearsInService)
        {

        }

        // methods 


        public Student[] GetStudents()
        {
            return this.Students;
        }
        
        public Grade[] GetGrades()
        {
            return this.Grades;
        }

        public Course[] GetCourses()
        {
            return this.Courses;
        }
        

        public void SetSchedule(Course courseId , Professor professorId , DateTime dateTime)
        {
            // business logic goes here
        }


    }
}
