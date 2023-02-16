using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpsilonRevision.Model.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Specialization { get; set; }
        public string Email { get; set; }
       

        public Doctor(string name, string address, string phoneNumber, string specialization, string email)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Specialization = specialization;
            Email = email;

            Consultations = new List<Consultation>();
            
        }

        public Doctor()
        {
        }

        // relationhips 

        public List<Consultation> Consultations { get; set; } 



    }
}
