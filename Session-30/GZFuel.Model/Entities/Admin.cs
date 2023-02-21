using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Model.Entities
{

    // this entity is just for experimental reasons , maybe a way to implement the admin login on the windows forms app. 
    public class Admin : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string Surname { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }


        public Admin(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Username = "admin";
            Password = "admin";
        }

        public Admin() { }
        
    }
}
