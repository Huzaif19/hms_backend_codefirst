using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.DAL
{
    public class managetip
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }
        
        public string Title { get; set; }
        
        public string WellnessTips { get; set; }

        public string BlogLink { get; set; }

        public string Youtubelink { get; set; }

        public string Symptoms { get; set; }

        public string Prevention { get; set; }

    }
}