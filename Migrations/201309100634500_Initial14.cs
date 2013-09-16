namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial14 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "ZipCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfile", "ZipCode");
        }
    }
}
