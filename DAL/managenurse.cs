using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace WebApplication1.DAL
{
    public class managenurse
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         
        public int NurseId { get; set; }
        [Required]
        [MaxLength(25)]

        public string NurseName { get; set; }
        
        [Required]

        public string PhoneNo { get; set; }
        [Required]
        [MaxLength(255)]
        public string Specialization { get; set; }
        [Required]
        
        public int Experience { get; set; }
        [Required]
        [MaxLength(255)]
        public string Qualification { get; set; }


    }
}