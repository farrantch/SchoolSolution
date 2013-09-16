namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "FirstName", c => c.String());
            AddColumn("dbo.UserProfile", "MiddleName", c => c.String());
            AddColumn("dbo.UserProfile", "LastName", c => c.String());
            AddColumn("dbo.UserProfile", "Address", c => c.String());
            AddColumn("dbo.UserProfile", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfile", "ApartmentNumber", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfile", "ZipCodeExtension", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfile", "ZipCodeExtension");
            DropColumn("dbo.UserProfile", "ApartmentNumber");
            DropColumn("dbo.UserProfile", "ZipCode");
            DropColumn("dbo.UserProfile", "Address");
            DropColumn("dbo.UserProfile", "LastName");
            DropColumn("dbo.UserProfile", "MiddleName");
            DropColumn("dbo.UserProfile", "FirstName");
        }
    }
}
