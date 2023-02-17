using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Model.Entities
{
    public class Customer
    {
        //ID, Name, Surname, CardNumber
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }

        //Customer Constructor 
        public Customer(int id, string name, string surname, string cardNumber)
        {
             //   ID = id; not here , the ID is auto generated bty the database
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
        }

    }
}
