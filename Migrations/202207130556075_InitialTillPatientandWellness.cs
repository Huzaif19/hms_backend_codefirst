namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialTillPatientandWellness : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Password = c.String(nullable: false, maxLength: 25),
                        EmployeeName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.managedoctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        DoctorName = c.String(nullable: false, maxLength: 25),
                        PhoneNo = c.Int(),
                        Specialization = c.String(nullable: false, maxLength: 255),
                        Experience = c.Int(nullable: false),
                        Qualification = c.String(nullable: false, maxLength: 255),
                        ConsultationFee = c.Int(nullable: false),
                        PhoneNum = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.DoctorId);
            
            CreateTable(
                "dbo.managenurses",
                c => new
                    {
                        NurseId = c.Int(nullable: false, identity: true),
                        NurseName = c.String(nullable: false, maxLength: 25),
                        PhoneNo = c.String(nullable: false),
                        Specialization = c.String(nullable: false, maxLength: 255),
                        Experience = c.Int(nullable: false),
                        Qualification = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.NurseId);
            
            CreateTable(
                "dbo.managetips",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        WellnessTips = c.String(),
                        BlogLink = c.String(),
                        Youtubelink = c.String(),
                        Symptoms = c.String(),
                        Prevention = c.String(),
                    })
                .PrimaryKey(t => t.PostId);
            
            CreateTable(
                "dbo.patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        PatientName = c.String(nullable: false, maxLength: 25),
                        PhoneNo = c.String(nullable: false),
                        Dob = c.String(nullable: false, maxLength: 10),
                        Age = c.Int(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 25),
                        Address = c.String(nullable: false, maxLength: 255),
                        Zipcode = c.Int(nullable: false),
                        City = c.String(nullable: false, maxLength: 25),
                        State = c.String(nullable: false, maxLength: 25),
                        Nationality = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.patients");
            DropTable("dbo.managetips");
            DropTable("dbo.managenurses");
            DropTable("dbo.managedoctors");
            DropTable("dbo.EmployeeLogins");
        }
    }
}
