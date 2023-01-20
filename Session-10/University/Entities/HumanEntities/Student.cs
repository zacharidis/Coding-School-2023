using Session_06.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Stuff
{
    internal class Student : Person
    {
        //properties
        public int RegistrationNumber { get; set; }
        public Course[]? Courses { get; set; } 

        //constructors
        public Student() { }

    

        public Student (Guid id) : base(id)
        {
            this.Id = id;
        }


        public Student(Guid id, string name) : base(id, name)
        {
            this.Id = id;
            this.Name = name;

        }

        public Student(Guid id, string name, int age) : base(id, name, age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public Student(int registrationNumber, Course[]? courses)
        {
            this.RegistrationNumber = registrationNumber;
            this.Courses = courses;
        }

        public Student(int registrationNumber)
        {
            this.RegistrationNumber = registrationNumber;
        }

        public Student(Guid id, string name, int age , int registrationNumber) : base(id, name, age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.RegistrationNumber = registrationNumber;
        }

        public Student(Guid id, string name, int age,int registrationNumber , Course[] courses) : base(id, name, age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.RegistrationNumber = registrationNumber;
            this.Courses = courses;
        }

        // methods

        public void Attend(Course course, DateTime datetime)
        {

        }

        public void WriteExam(Course course , DateTime datetime) {}


    }
}
