namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "FirstName", c => c.String(nullable: false, maxLength: 21));
            AddColumn("dbo.UserProfile", "MiddleName", c => c.String(nullable: false, maxLength: 21));
            AddColumn("dbo.UserProfile", "LastName", c => c.String(nullable: false, maxLength: 25));
            AddColumn("dbo.UserProfile", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserProfile", "Address", c => c.String(nullable: false, maxLength: 24));
            AddColumn("dbo.UserProfile", "ApartmentNumber", c => c.Int());
            AddColumn("dbo.UserProfile", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfile", "ZipCodeExtension", c => c.Int());
            AddColumn("dbo.UserProfile", "LastActivity", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserProfile", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.UserProfile", "Disabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserProfile", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.UserProfile", "UserName", c => c.String(nullable: false, maxLength: 21));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserProfile", "UserName", c => c.String());
            DropColumn("dbo.UserProfile", "Discriminator");
            DropColumn("dbo.UserProfile", "Disabled");
            DropColumn("dbo.UserProfile", "Balance");
            DropColumn("dbo.UserProfile", "LastActivity");
            DropColumn("dbo.UserProfile", "ZipCodeExtension");
            DropColumn("dbo.UserProfile", "ZipCode");
            DropColumn("dbo.UserProfile", "ApartmentNumber");
            DropColumn("dbo.UserProfile", "Address");
            DropColumn("dbo.UserProfile", "BirthDate");
            DropColumn("dbo.UserProfile", "LastName");
            DropColumn("dbo.UserProfile", "MiddleName");
            DropColumn("dbo.UserProfile", "FirstName");
        }
    }
}
