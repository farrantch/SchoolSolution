namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial15 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "PasswordChangedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserProfile", "Verified", c => c.Boolean(nullable: false));
            DropColumn("dbo.UserProfile", "DateCreated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "DateCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.UserProfile", "Verified");
            DropColumn("dbo.UserProfile", "PasswordChangedOn");
        }
    }
}
