namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LibraryItem", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LibraryItem", "Title");
        }
    }
}
