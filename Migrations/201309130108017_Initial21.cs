namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial21 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserProfile", "Country");
            DropColumn("dbo.UserProfile", "StateProvince");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "StateProvince", c => c.String());
            AddColumn("dbo.UserProfile", "Country", c => c.String());
        }
    }
}
