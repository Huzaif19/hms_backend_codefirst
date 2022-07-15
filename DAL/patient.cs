using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.DAL
{
    public class patient
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public patient()
        {
            this.BookAppointmnets = new HashSet<BookAppointmnet>();
            this.Prescriptions = new HashSet<Prescription>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int PatientId { get; set; }
        [Required]
        [MaxLength(25)]
        public string PatientName { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        [MaxLength(10)]
        public string Dob { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [MaxLength(25)]
        public string Gender { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
        [Required]
        public int Zipcode { get; set; }
        [Required]
        [MaxLength(25)]
        public string City { get; set; }
        [Required]
        [MaxLength(25)]
        public string State { get; set; }
        [Required]
        [MaxLength(25)]
        public string Nationality { get; set; }
        [Required]
        [MaxLength(25)]
        public string Password { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookAppointmnet> BookAppointmnets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}