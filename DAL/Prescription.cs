using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.DAL
{
    public class Prescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrescriptionId { get; set; }
        public string PrescriptionDate { get; set; }
        public string Drugnamedosage { get; set; }
        public string DrugDuration { get; set; }
        public string patientname { get; set; }
        public string doctorname { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<int> Column_Age { get; set; }

        public virtual managedoctor managedoctor { get; set; }
        public virtual patient patient { get; set; }
    }
}