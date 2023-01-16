using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Academics
{
    internal class Institute
    {
        // properties
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }


        // constructor

        public Institute()
        {

        }

        public Institute(Guid id)
        {
            this.ID = id;
        }

        public Institute(string name)
        {
            this.Name = name;
        }

        public Institute(Guid iD, string name, int yearsInService)
        {
            this.YearsInService = yearsInService;
            this.Name = name;
            
        }


        public string GetName() { return this.Name; }

        public void SetName(string name) { this.Name = name;}


    }
}
