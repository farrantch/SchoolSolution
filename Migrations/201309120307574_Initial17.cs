namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial17 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserProfile", "LastActivity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "LastActivity", c => c.DateTime(nullable: false));
        }
    }
}
