namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "Graduate", c => c.Boolean(nullable: false));
            AlterColumn("dbo.UserProfile", "ApartmentNumber", c => c.Int());
            AlterColumn("dbo.UserProfile", "ZipCodeExtension", c => c.Int());
            DropColumn("dbo.UserProfile", "HaveGraduated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "HaveGraduated", c => c.Boolean(nullable: false));
            AlterColumn("dbo.UserProfile", "ZipCodeExtension", c => c.Int(nullable: false));
            AlterColumn("dbo.UserProfile", "ApartmentNumber", c => c.Int(nullable: false));
            DropColumn("dbo.UserProfile", "Graduate");
        }
    }
}
