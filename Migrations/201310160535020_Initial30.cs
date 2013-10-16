namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial30 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "ExchangeStudent", c => c.Boolean(nullable: false));
            AddColumn("dbo.Course", "Name", c => c.String());
            AddColumn("dbo.Course", "Number", c => c.Int(nullable: false));
            AddColumn("dbo.Course", "Department", c => c.String());
            AddColumn("dbo.Course", "TimeStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Course", "TimeLength", c => c.Time(nullable: false));
            AddColumn("dbo.Course", "DateStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Course", "DateEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Course", "FinalExamDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Course", "FinalExamLength", c => c.Time(nullable: false));
            AddColumn("dbo.Course", "Instructor_UserId", c => c.Int());
            AddForeignKey("dbo.Course", "Instructor_UserId", "dbo.UserProfile", "UserId");
            CreateIndex("dbo.Course", "Instructor_UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Course", new[] { "Instructor_UserId" });
            DropForeignKey("dbo.Course", "Instructor_UserId", "dbo.UserProfile");
            DropColumn("dbo.Course", "Instructor_UserId");
            DropColumn("dbo.Course", "FinalExamLength");
            DropColumn("dbo.Course", "FinalExamDateTime");
            DropColumn("dbo.Course", "DateEnd");
            DropColumn("dbo.Course", "DateStart");
            DropColumn("dbo.Course", "TimeLength");
            DropColumn("dbo.Course", "TimeStart");
            DropColumn("dbo.Course", "Department");
            DropColumn("dbo.Course", "Number");
            DropColumn("dbo.Course", "Name");
            DropColumn("dbo.UserProfile", "ExchangeStudent");
        }
    }
}
