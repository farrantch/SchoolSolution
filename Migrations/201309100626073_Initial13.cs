namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial13 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserProfile", "ZipCode");
            DropColumn("dbo.UserProfile", "ZipCodeExtension");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "ZipCodeExtension", c => c.Int());
            AddColumn("dbo.UserProfile", "ZipCode", c => c.Int(nullable: false));
        }
    }
}
