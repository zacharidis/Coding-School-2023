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
        public Student[]? Students { get; set; }
        public Course[] Courses { get; set; }

        public Grade[] Grades { get; set; }

        public Schedule[] ScheduledCourse { get; set; }

    }
}
