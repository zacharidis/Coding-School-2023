using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpsilonRevision.Model.Entities
{
    public class Consultation
    {
        public int ConsultationId { get; set; }
        public DateTime Date { get; set; }

        public string Diagnosis { get; set; }

        public string Treatment { get; set; }

       


       

      

        public Consultation(Doctor doctor, string diagnosis, string treatment , Patient patient)
        {
            Doctor = doctor;
            Diagnosis = diagnosis;
            Treatment = treatment;
            Date = DateTime.Now;
            Patient = patient;
        }


        //relationships
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

    }
}
