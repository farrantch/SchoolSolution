namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial20 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LibraryItem", "ISBN", c => c.String());
            AddColumn("dbo.LibraryItem", "DateAdded", c => c.DateTime());
            AddColumn("dbo.LibraryItem", "Publisher", c => c.String());
            AddColumn("dbo.LibraryItem", "MagazineName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LibraryItem", "MagazineName");
            DropColumn("dbo.LibraryItem", "Publisher");
            DropColumn("dbo.LibraryItem", "DateAdded");
            DropColumn("dbo.LibraryItem", "ISBN");
        }
    }
}
