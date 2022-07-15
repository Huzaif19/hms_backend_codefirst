using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.DAL
{
    


        public class EmployeesEntities : DbContext
        {
            // Your context has been configured to use a 'DataContext' connection string from your application's 
            // configuration file (App.config or Web.config). By default, this connection string targets the 
            // 'HMS.DAL.DataContext' database on your LocalDb instance. 
            // 
            // If you wish to target a different database and/or database provider, modify the 'DataContext' 
            // connection string in the application configuration file.
            public EmployeesEntities()
                : base("name=EmployeesEntities")
            {
            }

            // Add a DbSet for each entity type that you want to include in your model. For more information 
            // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

       
        public virtual DbSet<EmployeeLogin> EmployeeLogins { get; set; }

        public virtual DbSet<managedoctor> managedoctors { get; set; }

        public virtual DbSet<managenurse> managenurses { get; set; }

        public virtual DbSet<managetip> managetips { get; set; }

        public virtual DbSet<patient> patients { get; set; }
        public virtual DbSet<AppointmentDetails> AppointmentInfo { get; set; }
        public virtual DbSet<InPatient> InPatients { get; set; }
        public virtual DbSet<BookAppointmnet> BookAppointmnets { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<Dischargesum> Dischargesums { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }

    }




}