using EpsilonRevision.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpsilonRevision.Model.Entities
{
    public class HospitalAdmission
    {
        
        public int Id { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }

        public bool IsDischarged { get; set; }

        //enum type
        public Clinic Clinic { get; set; }

        public Doctor SuperVisingDoctor { get; set; }


        public HospitalAdmission( Clinic clinic , string diagnosis) {

            AdmissionDate = DateTime.Now;
            Clinic = clinic;
            Diagnosis = diagnosis;
            IsDischarged = false;
        

            
        }


        //relationships

        
        public Patient Patient { get; set; }



    }
}
