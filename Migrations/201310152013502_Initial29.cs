namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial29 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserProfile", "LastActivityOn");
            DropColumn("dbo.UserProfile", "LastLogon");
            DropColumn("dbo.UserProfile", "AccountCreatedOn");
            DropColumn("dbo.UserProfile", "PasswordChangedOn");
            DropColumn("dbo.UserProfile", "Disabled");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "Disabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserProfile", "PasswordChangedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserProfile", "AccountCreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserProfile", "LastLogon", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserProfile", "LastActivityOn", c => c.DateTime(nullable: false));
        }
    }
}
