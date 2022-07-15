using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.DAL
{
    public class managedoctor
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public managedoctor()
        {
            this.BookAppointmnets = new HashSet<BookAppointmnet>();
            this.Prescriptions = new HashSet<Prescription>();
            this.Dischargesums = new HashSet<Dischargesum>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }
        [Required]
        [MaxLength(25)]

        public string DoctorName { get; set; }

        public Nullable<int> PhoneNo { get; set; }
        [Required]
        [MaxLength(255)]

        public string Specialization { get; set; }
        [Required]
        public int Experience { get; set; }
        [Required]
        [MaxLength(255)]

        public string Qualification { get; set; }
        [Required]
        public int ConsultationFee { get; set; }
        [Required]
        [MaxLength(10)]

        public string PhoneNum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookAppointmnet> BookAppointmnets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dischargesum> Dischargesums { get; set; }

    }
}