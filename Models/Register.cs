using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DAL;

namespace WebApplication1.Models
{
    public class Register
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string EmployeeName { get; set; }
    }
}