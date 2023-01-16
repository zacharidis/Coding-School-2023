using Session_06.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Stuff
{
    internal class Professor : Person
    {
        // properties
        public string? Rank { get; set; }
        public Course[]? Courses    { get; set; }

        // constructors 

        public Professor()
        {


        }


        public Professor(Guid id) : base(id)
        {
            this.Id = id;
        }


        public Professor(Guid id, string name) : base(id,name)
        {
            this.Id = id;
            this.Name = name;
            
        }

        public Professor(Guid id , string name , int age) :base(id,name,age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public Professor(Guid id, string name, int age ,string rank) : base(id, name, age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Rank = rank;
        }

        public Professor(Guid id, string name, int age,string rank , Course[] courses) : base(id, name, age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Rank = rank;
            this.Courses = courses;
        }



        // methods 

        public void Teach(Course course , DateTime datetime){}

        public void SetGrade(Student studentId , Course courseId , int grade){}

        public string GetName()
        {
            return "Dr." + this.Name;

        }





    }

