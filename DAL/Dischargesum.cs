using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.DAL
{
    public class Dischargesum
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DischargeId { get; set; }
        [Required]
        [MaxLength(25)]
        public string Patientname { get; set; }
        [Required]
        [MaxLength(25)]
        public string AdmissionDate { get; set; }
        [Required]
        [MaxLength(25)]
        public string DischargeDate { get; set; }
        public string Doctorname { get; set; }
        public string DischargeDiagnosis { get; set; }
        public string Complications { get; set; }
        public Nullable<int> InPatientId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string ConditionOnDischarge { get; set; }

        public virtual managedoctor managedoctor { get; set; }
        public virtual InPatient InPatient { get; set; }
    }
}