using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DAL;

namespace WebApplication1.Models
{
    public class PatientLogin
    {
        public string PatientName { get; set; }
        public string Password { get; set; }
    }
}