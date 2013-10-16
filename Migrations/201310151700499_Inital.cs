namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inital : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "LastLogon", c => c.DateTime(nullable: false));
            AddColumn("dbo.Settings", "NumberDaysUntilsCheckoutItemsDeleted", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "NumberDaysUntilsCheckoutItemsDeleted");
            DropColumn("dbo.UserProfile", "LastLogon");
        }
    }
}
