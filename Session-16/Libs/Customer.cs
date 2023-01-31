using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs {
    [Serializable]

    public class Customer {

        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }

        public Transaction Transaction { get; set; }

        public Customer() {
            ID = Guid.NewGuid();
            Code = "001";
            Description = "Retail Customer";
        }

    } 

}
