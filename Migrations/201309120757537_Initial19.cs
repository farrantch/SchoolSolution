namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial19 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LibraryItem", "UserProfile_UserId", "dbo.UserProfile");
            DropForeignKey("dbo.Equipment", "UserProfile_UserId", "dbo.UserProfile");
            DropIndex("dbo.LibraryItem", new[] { "UserProfile_UserId" });
            DropIndex("dbo.Equipment", new[] { "UserProfile_UserId" });
            CreateTable(
                "dbo.CheckoutLibraryTicket",
                c => new
                    {
                        CheckoutLibraryTicketId = c.Int(nullable: false, identity: true),
                        CheckedOut = c.DateTime(nullable: false),
                        CheckedIn = c.DateTime(nullable: false),
                        User_UserId = c.Int(),
                        Item_LibraryItemID = c.Int(),
                    })
                .PrimaryKey(t => t.CheckoutLibraryTicketId)
                .ForeignKey("dbo.UserProfile", t => t.User_UserId)
                .ForeignKey("dbo.LibraryItem", t => t.Item_LibraryItemID)
                .Index(t => t.User_UserId)
                .Index(t => t.Item_LibraryItemID);
            
            CreateTable(
                "dbo.CheckoutEquipmentTicket",
                c => new
                    {
                        CheckoutEquipmentTicketId = c.Int(nullable: false, identity: true),
                        CheckedOut = c.DateTime(nullable: false),
                        CheckedIn = c.DateTime(nullable: false),
                        User_UserId = c.Int(),
                        Item_EquipmentId = c.Int(),
                    })
                .PrimaryKey(t => t.CheckoutEquipmentTicketId)
                .ForeignKey("dbo.UserProfile", t => t.User_UserId)
                .ForeignKey("dbo.Equipment", t => t.Item_EquipmentId)
                .Index(t => t.User_UserId)
                .Index(t => t.Item_EquipmentId);
            
            AddColumn("dbo.LibraryItem", "DatePublished", c => c.DateTime(nullable: false));
            AddColumn("dbo.LibraryItem", "Barcode", c => c.Int(nullable: false));
            AddColumn("dbo.LibraryItem", "Description", c => c.String());
            DropColumn("dbo.LibraryItem", "UserProfile_UserId");
            DropColumn("dbo.Equipment", "UserProfile_UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipment", "UserProfile_UserId", c => c.Int());
            AddColumn("dbo.LibraryItem", "UserProfile_UserId", c => c.Int());
            DropIndex("dbo.CheckoutEquipmentTicket", new[] { "Item_EquipmentId" });
            DropIndex("dbo.CheckoutEquipmentTicket", new[] { "User_UserId" });
            DropIndex("dbo.CheckoutLibraryTicket", new[] { "Item_LibraryItemID" });
            DropIndex("dbo.CheckoutLibraryTicket", new[] { "User_UserId" });
            DropForeignKey("dbo.CheckoutEquipmentTicket", "Item_EquipmentId", "dbo.Equipment");
            DropForeignKey("dbo.CheckoutEquipmentTicket", "User_UserId", "dbo.UserProfile");
            DropForeignKey("dbo.CheckoutLibraryTicket", "Item_LibraryItemID", "dbo.LibraryItem");
            DropForeignKey("dbo.CheckoutLibraryTicket", "User_UserId", "dbo.UserProfile");
            DropColumn("dbo.LibraryItem", "Description");
            DropColumn("dbo.LibraryItem", "Barcode");
            DropColumn("dbo.LibraryItem", "DatePublished");
            DropTable("dbo.CheckoutEquipmentTicket");
            DropTable("dbo.CheckoutLibraryTicket");
            CreateIndex("dbo.Equipment", "UserProfile_UserId");
            CreateIndex("dbo.LibraryItem", "UserProfile_UserId");
            AddForeignKey("dbo.Equipment", "UserProfile_UserId", "dbo.UserProfile", "UserId");
            AddForeignKey("dbo.LibraryItem", "UserProfile_UserId", "dbo.UserProfile", "UserId");
        }
    }
}
