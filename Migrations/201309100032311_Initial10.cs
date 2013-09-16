namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "CountryIdSelected", c => c.String());
            AddColumn("dbo.UserProfile", "StateProvinceIdSelected", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfile", "StateProvinceIdSelected");
            DropColumn("dbo.UserProfile", "CountryIdSelected");
        }
    }
}
