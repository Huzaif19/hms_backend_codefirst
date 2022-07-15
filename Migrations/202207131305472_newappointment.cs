namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newappointment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppointmentInfo",
                c => new
                    {
                        appointment_ID = c.Int(nullable: false, identity: true),
                        patientName = c.String(nullable: false),
                        email = c.String(nullable: false),
                        Speciality = c.String(nullable: false),
                        doctorName = c.String(nullable: false),
                        day = c.String(nullable: false),
                        date = c.String(nullable: false),
                        time = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.appointment_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AppointmentInfo");
        }
    }
}
