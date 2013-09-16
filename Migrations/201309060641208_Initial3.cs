namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LibraryItem",
                c => new
                    {
                        LibraryItemID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Title1 = c.String(),
                        Title2 = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.LibraryItemID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LibraryItem");
        }
    }
}
