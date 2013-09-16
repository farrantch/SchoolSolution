namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "SelectedGenderId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfile", "SelectedGenderId");
        }
    }
}
