namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial23 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "Country", c => c.String());
            AddColumn("dbo.UserProfile", "StateProvince", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfile", "StateProvince");
            DropColumn("dbo.UserProfile", "Country");
        }
    }
}
