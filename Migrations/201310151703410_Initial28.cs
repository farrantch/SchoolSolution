namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial28 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "NumberDaysUntilCheckoutItemsDeleted", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "NumberDaysUntilCheckoutItemsDeleted");
        }
    }
}
