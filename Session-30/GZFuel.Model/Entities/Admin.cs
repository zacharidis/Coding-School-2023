using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Model.Entities
{

    // this entity is just for experimental reasons , maybe a way to implement the admin login on the windows forms app. 
    public class Admin
    {
        public int Id { get; set; }
        public int Name { get; set; }  
        public int Surname { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }


        public Admin(int id, int name, int surname)
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
