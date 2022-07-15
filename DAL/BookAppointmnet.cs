using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.DAL
{
    public class BookAppointmnet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentId { get; set; }
        [Required]
        [MaxLength(25)]
        public string Patientname { get; set; }
        [Required]
        [MaxLength(255)]
        public string Specialization { get; set; }
        [Required]
        [MaxLength(25)]
        public string ConsultingDoctor { get; set; }
        [Required]
        [MaxLength(25)]
        public string AppointmentDate { get; set; }
        [Required]
        [MaxLength(25)]
        public string AppointmentTime { get; set; }
        
        public Nullable<int> PatientId { get; set; }
        public Nullable<int> DoctorId { get; set; }

        public virtual managedoctor managedoctor { get; set; }
        public virtual patient patient { get; set; }

    }
}