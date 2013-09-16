namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "LastActivityOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfile", "LastActivityOn");
        }
    }
}
