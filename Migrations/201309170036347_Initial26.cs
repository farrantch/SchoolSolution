namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial26 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Area", "UserProfile_UserId", "dbo.UserProfile");
            DropIndex("dbo.Area", new[] { "UserProfile_UserId" });
            CreateTable(
                "dbo.CheckoutLibraryItemTicket",
                c => new
                    {
                        CheckoutLibraryItemTicketId = c.Int(nullable: false, identity: true),
                        CheckedOut = c.DateTime(nullable: false),
                        CheckedIn = c.DateTime(nullable: false),
                        Due = c.DateTime(nullable: false),
                        User_UserId = c.Int(),
                        LibraryItem_LibraryItemID = c.Int(),
                    })
                .PrimaryKey(t => t.CheckoutLibraryItemTicketId)
                .ForeignKey("dbo.UserProfile", t => t.User_UserId)
                .ForeignKey("dbo.LibraryItem", t => t.LibraryItem_LibraryItemID)
                .Index(t => t.User_UserId)
                .Index(t => t.LibraryItem_LibraryItemID);
            
            CreateTable(
                "dbo.LibraryItem",
                c => new
                    {
                        LibraryItemID = c.Int(nullable: false, identity: true),
                        DatePublished = c.DateTime(nullable: false),
                        Barcode = c.Int(nullable: false),
                        Description = c.String(),
                        Title = c.String(),
                        ISBN = c.String(),
                        DateAdded = c.DateTime(),
                        Publisher = c.String(),
                        MagazineName = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.LibraryItemID);
            
            CreateTable(
                "dbo.CheckoutAreaTicket",
                c => new
                    {
                        CheckoutAreaTicketId = c.Int(nullable: false, identity: true),
                        CheckedOut = c.DateTime(nullable: false),
                        CheckedIn = c.DateTime(nullable: false),
                        Due = c.DateTime(nullable: false),
                        User_UserId = c.Int(),
                        Area_AreaId = c.Int(),
                    })
                .PrimaryKey(t => t.CheckoutAreaTicketId)
                .ForeignKey("dbo.UserProfile", t => t.User_UserId)
                .ForeignKey("dbo.Area", t => t.Area_AreaId)
                .Index(t => t.User_UserId)
                .Index(t => t.Area_AreaId);
            
            AddColumn("dbo.Equipment", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Equipment", "Description", c => c.String());
            AddColumn("dbo.Area", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Area", "Description", c => c.String());
            DropColumn("dbo.Area", "UserProfile_UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Area", "UserProfile_UserId", c => c.Int());
            DropIndex("dbo.CheckoutAreaTicket", new[] { "Area_AreaId" });
            DropIndex("dbo.CheckoutAreaTicket", new[] { "User_UserId" });
            DropIndex("dbo.CheckoutLibraryItemTicket", new[] { "LibraryItem_LibraryItemID" });
            DropIndex("dbo.CheckoutLibraryItemTicket", new[] { "User_UserId" });
            DropForeignKey("dbo.CheckoutAreaTicket", "Area_AreaId", "dbo.Area");
            DropForeignKey("dbo.CheckoutAreaTicket", "User_UserId", "dbo.UserProfile");
            DropForeignKey("dbo.CheckoutLibraryItemTicket", "LibraryItem_LibraryItemID", "dbo.LibraryItem");
            DropForeignKey("dbo.CheckoutLibraryItemTicket", "User_UserId", "dbo.UserProfile");
            DropColumn("dbo.Area", "Description");
            DropColumn("dbo.Area", "Name");
            DropColumn("dbo.Equipment", "Description");
            DropColumn("dbo.Equipment", "Name");
            DropTable("dbo.CheckoutAreaTicket");
            DropTable("dbo.LibraryItem");
            DropTable("dbo.CheckoutLibraryItemTicket");
            CreateIndex("dbo.Area", "UserProfile_UserId");
            AddForeignKey("dbo.Area", "UserProfile_UserId", "dbo.UserProfile", "UserId");
        }
    }
}
