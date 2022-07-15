namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addednewafterpatient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookAppointmnets",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        Patientname = c.String(nullable: false, maxLength: 25),
                        Specialization = c.String(nullable: false, maxLength: 255),
                        ConsultingDoctor = c.String(nullable: false, maxLength: 25),
                        AppointmentDate = c.String(nullable: false, maxLength: 25),
                        AppointmentTime = c.String(nullable: false, maxLength: 25),
                        PatientId = c.Int(),
                        DoctorId = c.Int(),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.managedoctors", t => t.DoctorId)
                .ForeignKey("dbo.patients", t => t.PatientId)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Dischargesums",
                c => new
                    {
                        DischargeId = c.Int(nullable: false, identity: true),
                        Patientname = c.String(nullable: false, maxLength: 25),
                        AdmissionDate = c.String(nullable: false, maxLength: 25),
                        DischargeDate = c.String(nullable: false, maxLength: 25),
                        Doctorname = c.String(),
                        DischargeDiagnosis = c.String(),
                        Complications = c.String(),
                        InPatientId = c.Int(),
                        DoctorId = c.Int(),
                        ConditionOnDischarge = c.String(),
                    })
                .PrimaryKey(t => t.DischargeId)
                .ForeignKey("dbo.InPatients", t => t.InPatientId)
                .ForeignKey("dbo.managedoctors", t => t.DoctorId)
                .Index(t => t.InPatientId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.InPatients",
                c => new
                    {
                        InPatientId = c.Int(nullable: false, identity: true),
                        PatientName = c.String(),
                        PhoneNum = c.String(),
                        DateOfBirth = c.String(),
                        Age = c.Int(),
                        Gender = c.String(),
                        InPatientAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Nationality = c.String(),
                        AdmissionDate = c.String(),
                        DischargeDate = c.String(),
                        RoomNo = c.Int(),
                        NurseId = c.Int(),
                    })
                .PrimaryKey(t => t.InPatientId)
                .ForeignKey("dbo.managenurses", t => t.NurseId)
                .Index(t => t.NurseId);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        PrescriptionId = c.Int(nullable: false, identity: true),
                        PrescriptionDate = c.String(),
                        Drugnamedosage = c.String(),
                        DrugDuration = c.String(),
                        patientname = c.String(),
                        doctorname = c.String(),
                        PatientId = c.Int(),
                        DoctorId = c.Int(),
                        Column_Age = c.Int(),
                    })
                .PrimaryKey(t => t.PrescriptionId)
                .ForeignKey("dbo.managedoctors", t => t.DoctorId)
                .ForeignKey("dbo.patients", t => t.PatientId)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        FeedbackId = c.Int(nullable: false, identity: true),
                        patientname = c.String(),
                        GiveFeedback = c.String(),
                    })
                .PrimaryKey(t => t.FeedbackId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prescriptions", "PatientId", "dbo.patients");
            DropForeignKey("dbo.BookAppointmnets", "PatientId", "dbo.patients");
            DropForeignKey("dbo.Prescriptions", "DoctorId", "dbo.managedoctors");
            DropForeignKey("dbo.Dischargesums", "DoctorId", "dbo.managedoctors");
            DropForeignKey("dbo.InPatients", "NurseId", "dbo.managenurses");
            DropForeignKey("dbo.Dischargesums", "InPatientId", "dbo.InPatients");
            DropForeignKey("dbo.BookAppointmnets", "DoctorId", "dbo.managedoctors");
            DropIndex("dbo.Prescriptions", new[] { "DoctorId" });
            DropIndex("dbo.Prescriptions", new[] { "PatientId" });
            DropIndex("dbo.InPatients", new[] { "NurseId" });
            DropIndex("dbo.Dischargesums", new[] { "DoctorId" });
            DropIndex("dbo.Dischargesums", new[] { "InPatientId" });
            DropIndex("dbo.BookAppointmnets", new[] { "DoctorId" });
            DropIndex("dbo.BookAppointmnets", new[] { "PatientId" });
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.InPatients");
            DropTable("dbo.Dischargesums");
            DropTable("dbo.BookAppointmnets");
        }
    }
}
