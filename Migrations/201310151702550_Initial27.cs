namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial27 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Settings", "NumberDaysUntilsCheckoutItemsDeleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "NumberDaysUntilsCheckoutItemsDeleted", c => c.Int(nullable: false));
        }
    }
}
