using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Model.Entities
{
    public class Customer : BaseEntity
    {
        //ID, Name, Surname, CardNumber
            public int ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string CardNumber { get; set; }

        //Customer Constructor 
        public Customer(string name, string surname, string cardNumber)
        {
             //   ID = id; not here , the ID is auto generated bty the database
            Name = name;
            Surname = surname;

            // get the ID and then add the letter A in front of it . 
            CardNumber = "A" + ID.ToString();
            
            
            Transactions= new List<Transaction>();
        }

        // Transactions is a relationship between Customer and Transaction ( one to many)

        public List<Transaction> Transactions { get; set; } 


    }
}
