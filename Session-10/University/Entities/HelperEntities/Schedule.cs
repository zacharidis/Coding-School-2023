using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Helpers
{
    public class Schedule
    {

        public Guid ID { get; set; }
        public Guid CourseID     { get; set; }

        public Guid ProfessorID { get; set; }
        public Calendar? DateTime { get; set; }

        public Schedule()
        {
        }

        public Schedule(Guid id)
        {
            this.ID = id;
        }

       



    }
}
