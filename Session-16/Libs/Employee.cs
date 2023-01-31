using System;
using System.Linq;

namespace Libs {
    [Serializable]

    public class Employee {

        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public decimal Salary { get; set; }

        public Transaction Transaction { get; set; }

        public EmployeeType EmployeeType { get; set; }


        public Employee() {
            ID = Guid.NewGuid();
        }

    }

}
