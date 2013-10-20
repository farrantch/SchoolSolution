namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial31 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Course", "Instructor_UserId", "dbo.UserProfile");
            DropIndex("dbo.Course", new[] { "Instructor_UserId" });
            CreateTable(
                "dbo.CourseTickets",
                c => new
                    {
                        CourseTicketId = c.Int(nullable: false, identity: true),
                        TimeStart = c.DateTime(nullable: false),
                        TimeLength = c.Time(nullable: false),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        FinalExamDateTime = c.DateTime(nullable: false),
                        FinalExamLength = c.Time(nullable: false),
                        Instructor_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.CourseTicketId)
                .ForeignKey("dbo.UserProfile", t => t.Instructor_UserId)
                .Index(t => t.Instructor_UserId);
            
            DropColumn("dbo.Course", "TimeStart");
            DropColumn("dbo.Course", "TimeLength");
            DropColumn("dbo.Course", "DateStart");
            DropColumn("dbo.Course", "DateEnd");
            DropColumn("dbo.Course", "FinalExamDateTime");
            DropColumn("dbo.Course", "FinalExamLength");
            DropColumn("dbo.Course", "Instructor_UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Course", "Instructor_UserId", c => c.Int());
            AddColumn("dbo.Course", "FinalExamLength", c => c.Time(nullable: false));
            AddColumn("dbo.Course", "FinalExamDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Course", "DateEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Course", "DateStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Course", "TimeLength", c => c.Time(nullable: false));
            AddColumn("dbo.Course", "TimeStart", c => c.DateTime(nullable: false));
            DropIndex("dbo.CourseTickets", new[] { "Instructor_UserId" });
            DropForeignKey("dbo.CourseTickets", "Instructor_UserId", "dbo.UserProfile");
            DropTable("dbo.CourseTickets");
            CreateIndex("dbo.Course", "Instructor_UserId");
            AddForeignKey("dbo.Course", "Instructor_UserId", "dbo.UserProfile", "UserId");
        }
    }
}
