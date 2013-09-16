namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "GenderIdSelected", c => c.String());
            DropColumn("dbo.UserProfile", "SelectedGenderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "SelectedGenderId", c => c.String());
            DropColumn("dbo.UserProfile", "GenderIdSelected");
        }
    }
}
