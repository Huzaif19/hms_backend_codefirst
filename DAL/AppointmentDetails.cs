using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.DAL
{
    [Table("AppointmentInfo")]
    public class AppointmentDetails

        {
            [Key]
            public int appointment_ID { get; set; }



            [Required(ErrorMessage = "PatientName is required.")]
            public String patientName { get; set; }


            [Required(ErrorMessage = "Email is required.")]
            public String email { get; set; }



            [Required(ErrorMessage = "Specialist is required.")]
            public string Speciality { get; set; }


            [Required(ErrorMessage = "DoctorName is required.")]
            public string doctorName { get; set; }


            [Required(ErrorMessage = "Day is required.")]
            public string day { get; set; }


            [Required(ErrorMessage = "Date is required.")]
            public string date { get; set; }


            [Column(TypeName = "VARCHAR")]
            [StringLength(50)]
            [Required(ErrorMessage = "Time is required.")]
            public string time { get; set; }
        }


 }
